#include <ESP8266WiFi.h>

//IPAddress ip(192, 168, 43, 150);
//IPAddress gateway(192, 168, 43, 1);
//IPAddress subnet(255, 255, 255, 0);
//IPAddress dns(192, 168, 43, 1);

int led1 = -1;
const char* ssid     = "TeleCentro-9d10";
const char* password = "KZM4EWYJRTM5";

WiFiServer server(80);

void setup()
{
  Serial.begin(9600);
  delay(10);
  connectWifi();
  server.begin();
}


void loop() {
  WiFiClient client = server.available();

  if (client) {
    Serial.println("Nuevo cliente.");

    while (client.connected()) {
     
      //Example: "9,true"
      String request = client.readStringUntil('\r');
      Serial.println(request);
      request.toLowerCase();
      int indSplit = request.indexOf(',');
      int dataLength = request.length();
      String rta = request.substring(indSplit + 1, dataLength);
      
      if (led1 == -1) {
        led1 = request.substring(0, indSplit).toInt();
        Serial.print("Pin:");
        Serial.println(led1);
        pinMode(led1, OUTPUT);
      }      
      if (rta == "true"){
        Serial.print("HIGH")
        digitalWrite(led1, HIGH);
      }else{
        Serial.print("LOW")
        digitalWrite(led1, LOW);
      }
    }
    client.println("HTTP/1.1 200 OK");
    client.println("Content-type:text/html");
    client.println("");
    //client.println("<meta http-equiv=\"refresh\" content=\"5\" >");
    client.print(",");

    delay(1);
    client.stop();
    Serial.println("Cliente desconectado");

  }
}
void connectWifi() {
  Serial.println();
  Serial.println();
  Serial.print("Conectando a: ");
  Serial.println(ssid);
  // WiFi.config(ip,dns,gateway,subnet);
  WiFi.begin(ssid, password);
  while (WiFi.status() != WL_CONNECTED) {
    delay(500);
    Serial.print(".");
  }
  Serial.println("");
  Serial.println("WiFi Conectado.");
  Serial.println("IP address: ");
  Serial.println(WiFi.localIP());

}
