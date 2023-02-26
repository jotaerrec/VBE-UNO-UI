#include <map>
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
int contadorPin = 0;

struct Pin {
  int pin = -1;
  int modo;
  int tipo;
};
std::map<byte, bool> pinesUtilizados;
Pin pinesDeEntrada[MAX_PINES_DE_ENTRADA];


void setup()
{
  Serial.begin(9600);
  delay(10);
  Serial.setDebugOutput(false);
  conectarWifi(WIFI_SSID, WIFI_PASSWORD);
  imprimirDetallesConexion();
  server.begin();
}

void loop() {
  manejarSolicitudesHTTP();
  client.stop();
}


// Función principal para manejar solicitudes HTTP
void manejarSolicitudesHTTP() {
  client = server.available();
  if (client) {
    saludar();
    Serial.println("Nuevo cliente.");

    while (client.connected()) {
      manejarSolicitudHTTP();
    }
  }
}
void saludar(){
  client.println("Hola!");

  
}
// Función para manejar una solicitud HTTP
void manejarSolicitudHTTP() {
  String request = client.readStringUntil(CR);
  if (!request.isEmpty()) {
    request.toLowerCase();
    Serial.println(request);
    if (request.startsWith("ag")) {
      Serial.println("Agregando Pin!!");
      agregarPin(request);
    }
    if (request.startsWith("es")) {
      Serial.println("Escribiendo Pin!!");
      escribirPin(request);
    }
  }
  if (contadorPin != 0)
    leerPinesDeEntrada();
}


void escribirPin(String datos) {
  byte pinNumber;
  String pinStr = datos.substring(datos.indexOf("pin:") + 4, datos.indexOf(","));
  if(pinStr.charAt(0) == 'A') { 
    pinNumber = A0; 
  } else {
    pinNumber = (byte)pinStr.toInt();
  }
  
  String valorStr = datos.substring(datos.indexOf("valor:") + 6, datos.indexOf(",", datos.indexOf("valor:")));
  String tipoStr = datos.substring(datos.indexOf("tipo:") + 5, datos.length());
  int tipo = tipoStr == "digital" ? DIGITAL : ANALOGICO;
  if (tipo == DIGITAL) {
    bool estado = valorStr == "true" ?  HIGH : LOW;
    digitalWrite(pinNumber, estado);
  } else {
    int valor = valorStr.toInt();
    analogWrite(pinNumber, valor);
  }
  Serial.println("Listen");
}

void agregarPin(String datos) {
  byte pinNumber;
  String pinStr = datos.substring(datos.indexOf("pin:") + 4, datos.indexOf(","));
  if( pinStr.charAt(0) == 'A') { 
    pinNumber = A0; 
  } else {
    pinNumber = (byte)pinStr.toInt();
  }  
  verificarPin(pinNumber);

  String modoStr = datos.substring(datos.indexOf("modo:") + 5, datos.indexOf(",", datos.indexOf("modo:")));
  int modo = modoStr == "entrada" ? ENTRADA : SALIDA;

  if (modo == SALIDA) {
    pinMode(pinNumber, OUTPUT);
    Serial.println("Working");
    return;
  }

  if (contadorPin == MAX_PINES_DE_ENTRADA) {
    client.println("Error: Ya están todos los pines de Entrada en uso.");
    return;
  }

  String tipoStr = datos.substring(datos.indexOf("tipo:") + 5, datos.length());
  int tipo = tipoStr == "digital" ? DIGITAL : ANALOGICO;

  Pin nuevoPin;
  nuevoPin.pin = pinNumber;
  nuevoPin.tipo = tipo;
  nuevoPin.modo = modo;
  pinesDeEntrada[contadorPin] = nuevoPin;
  pinMode(pinNumber, INPUT);
  contadorPin++;
  Serial.println("Se guardo");

}

void verificarPin(byte pinNumber) {
  if (pinesUtilizados.count(pinNumber) > 0) {
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
      Serial.print("El valor leido en pin:");
      Serial.print(pin.pin);
      Serial.println("es:");
      Serial.println(valorPin);
    } else if (pin.tipo == ANALOGICO) {
      valorPin = analogRead(pin.pin);
    }
    imprimirValorPin(pin.pin, valorPin);
  }
}

void imprimirValorPin(int pin, int valor) {
  client.print("valoresDeEntrada:");
  client.print("Pin:");
  client.print(pin);
  client.print(":Valor:");
  client.println(valor);
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
