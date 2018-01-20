#include <Canbus.h>
#include <defaults.h>
#include <global.h>
#include <mcp2515.h>
#include <mcp2515_defs.h>

void setup() {
  Serial.begin(9600);
  Serial.println("CAN Read - Testing receival of CAN Bus message");
  delay(1000);

  if (Canbus.init(CANSPEED_500))
    Serial.println("CAN Init ok");
  else
    Serial.println("Can't init CAN");

  delay(1000);
}



void loop() {

  tCAN message;
  if (mcp2515_check_message())
  {
    if (mcp2515_get_message(&message))
    {
      if (message.id == 0x620)
      {
        for (int i = 0; i < message.header.length; i++)
        {
          Serial.write(message.data[i]);
          Serial.print(" ");
        }
      }


      else if (message.id == 0x621)
      {

        Serial.print("This should say '2CN' + Rev Level: ");
        for (int i = 0; i < message.header.length; i++)
        {
          Serial.print(message.data[i], HEX);
          Serial.print(" ");
        }
        Serial.println("");
      }

      else if (message.id == 0x622)
      {

        Serial.print("This should be some hex numbers: ");
        for (int i = 0; i < message.header.length; i++)
        {
          Serial.print(message.data[i], HEX);
          Serial.print(" ");
        }
        Serial.println("");
      }

      else if (message.id == 0x623)
      {

        Serial.print("This should be more hex numbers: ");
        for (int i = 0; i < message.header.length; i++)
        {
          Serial.print(message.data[i], HEX);
          Serial.print(" ");
        }
        Serial.println("");
      }

      else if (message.id == 0x624)
      {

        Serial.print("Even more different hex numbers: ");
        for (int i = 0; i < message.header.length; i++)
        {
          Serial.print(message.data[i], HEX);
          Serial.print(" ");
        }
        Serial.println("");
      }

      else if (message.id == 0x625)
      {

        Serial.print("More: ");
        for (int i = 0; i < message.header.length; i++)
        {
          Serial.print(message.data[i], HEX);
          Serial.print(" ");
        }
        Serial.println("");
      }

      else if (message.id == 0x626)
      {

        Serial.print("More! : ");
        for (int i = 0; i < message.header.length; i++)
        {
          Serial.print(message.data[i], HEX);
          Serial.print(" ");
        }
        Serial.println("");
      }

      else if (message.id == 0x627)
      {

        Serial.print("Almost done: ");
        Serial.print(message.header.length, DEC);
        for (int i = 0; i < message.header.length; i++)
        {
          Serial.print(message.data[i], HEX);
          Serial.print(" ");
        }
        Serial.println("");
      }

      else if (message.id == 0x628)
      {

        Serial.print("The end: ");
        for (int i = 0; i < message.header.length; i++)
        {
          Serial.print(message.data[i], HEX);
          Serial.print(" ");
        }
        Serial.println("");
      }

    }
  }

}
