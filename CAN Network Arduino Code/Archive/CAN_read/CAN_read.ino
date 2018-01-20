#include <Canbus.h>
#include <defaults.h>
#include <global.h>
#include <mcp2515.h>
#include <mcp2515_defs.h>


void setup() {
  Serial.begin(57600);
  Serial.println("CAN read - Testing program to read BMS for IFE");
  delay(1000);

  if (Canbus.init(CANSPEED_500))
    Serial.println("CAN Shield Initialized ok ");
  else
    Serial.println("CAN Shield Initialization failed - feels bad man. [Must be a shield/arduino error]");

  delay(1000);

  
}

void loop() {

  tCAN message;

  if (mcp2515_check_message())
  {
    if (mcp2515_get_message(&message))
    {
    /*  
      if (message.id == 0x620) {
        Serial.print("Manufacturer: ");
        Serial.write(message.id);
        Serial.print("Data: ");
        for (int i = 0; i < message.header.length; i++)
        {
          Serial.write(message.data[i]);
        }
        Serial.println("");
      }

      if (message.id == 0x621) {
        Serial.print("Version and revision information: "); 
        //Serial.write(message.id);  
        for (int i = 0; i < message.header.length; i++)
        {
          Serial.write(message.data[i]);
        }
        Serial.println("");
        }

    if (message.id == 0x622) {
        Serial.print("Fault Codes: ");  
        for (int i = 0; i < message.header.length; i++)
        {
          Serial.print(message.data[i],BIN);
          Serial.print(" ");
        }
        Serial.println("");
        }
*/

     if (message.id == 0x623) {
        Serial.print("Voltage information: "); 
        for (int i = 0; i < message.header.length; i++)
        {
          Serial.print(message.data[i]);
        }
        Serial.println("");
        }


    delay(1000);
  }
}}
  
