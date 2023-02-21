#include <ESP8266WiFi.h>

WiFiServer server(80);
WiFiClient client;
const char* WIFI_SSID     = "TeleCentro-9d10";
const char* WIFI_PASSWORD = "KZM4EWYJRTM5";
const int MAX_PINES_DE_ENTRADA = 5;
const int DIGITAL = 0;
const int ANALOGICO = 1;
const int ENTRADA = 0;
const int SALIDA = 1;
const char CR = '\r';

bool pinesUtilizados[10] = {false};
int contadorPin = 0;

struct Pin {
  int pin = -1;
  int modo;
  int tipo;
};
Pin pinesDeEntrada[MAX_PINES_DE_ENTRADA];


void setup()
{
  Serial.begin(9600);
  delay(10);
  conectarWifi(WIFI_SSID, WIFI_PASSWORD);
  imprimirDetallesConexion();
  server.begin();
}

void loop() {
  manejarSolicitudesHTTP();
  delay(1);
  client.stop();
  Serial.println("Cliente desconectado");
}


// Función principal para manejar solicitudes HTTP
void manejarSolicitudesHTTP() {
  WiFiClient client = server.available();

  if (client) {
    Serial.println("Nuevo cliente.");

    while (client.connected()) {
      manejarSolicitudHTTP(client);
    }
  }
}
// Función para manejar una solicitud HTTP
void manejarSolicitudHTTP(WiFiClient& client) {
  String request = client.readStringUntil(CR);
  if (!request.isEmpty()) {
    Serial.println(request);
    request.toLowerCase();
    procesarSolicitudHTTP(request);
  } else {
    // Devolver respuesta de error HTTP
    // ...
  }

  // Leer pines de entrada
  leerPinesDeEntrada();
}

// Función para manejar solicitudes HTTP
void procesarSolicitudHTTP(const String& request) {
  if (request.startsWith("agregarpin:")) {
    agregarPin(request);
  }

}

void conectarWifi(const char* ssid, const char* password) {
  Serial.println();
  Serial.println();
  Serial.print("Conectando a: ");
  Serial.println(ssid);

  WiFi.begin(ssid, password);
  while (WiFi.status() != WL_CONNECTED) {
    delay(500);
    Serial.print(".");
  }
}

void imprimirDetallesConexion() {
  Serial.println("");
  Serial.println("WiFi Conectado.");
  Serial.print("SSID: ");
  Serial.println(WiFi.SSID());
  Serial.print("Dirección IP: ");
  Serial.println(WiFi.localIP());
}

void agregarPin(String datos) {

  // Verifica que los datos sean válidos
  int pinNumber = datos.substring(datos.indexOf("Pin:") + 4, datos.indexOf(",")).toInt();
  verificarPin(pinNumber);

  String modoStr = datos.substring(datos.indexOf("Modo:") + 5);
  int modo = modoStr == "entrada" ? ENTRADA : SALIDA;

  if (modo == SALIDA) {
    pinMode(pinNumber, SALIDA);
    return;
  }

  if (contadorPin == MAX_PINES_DE_ENTRADA) {
    client.println("Error: Ya están todos los pines de Entrada en uso.");
    return;
  }

  String tipoStr = datos.substring(datos.indexOf("Tipo:") + 5, datos.lastIndexOf(","));
  int tipo = tipoStr == "digital" ? DIGITAL : ANALOGICO;

  Pin nuevoPin;
  nuevoPin.pin = pinNumber;
  nuevoPin.tipo = tipo;
  nuevoPin.modo = modo;
  pinesDeEntrada[contadorPin] = nuevoPin;

  pinMode(pinNumber, ENTRADA);

  contadorPin++;
}

void verificarPin(int pinNumber) {
  if (pinesUtilizados[pinNumber]) {
    client.println("Error: Este pin ya está en uso.");
    return;
  }

  pinesUtilizados[pinNumber] = true;
}

void leerPinesDeEntrada() {
  for (int i = 0; i < contadorPin; i++) {
    Pin pin = pinesDeEntrada[i];
    if (pin.pin == -1) {
      break;
    }

    int valorPin;
    if (pin.tipo == DIGITAL) {
      valorPin = digitalRead(pin.pin);
    } else if (pin.tipo == ANALOGICO) {
      valorPin = analogRead(pin.pin);
    }

    imprimirValorPin(pin.pin, valorPin);
  }
}

void imprimirValorPin(int pin, int valor) {
  client.print("Pin:");
  client.print(pin);
  client.print(",Valor:");
  client.println(valor);
}
