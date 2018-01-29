#include <SoftwareSerial.h>
#include <Canbus.h>
#include <defaults.h>
#include <global.h>
#include <mcp2515.h>
#include <mcp2515_defs.h>


SoftwareSerial BT = SoftwareSerial(3, 4);   //RX, TX

String company[9];
String company_out[9];
String rev_version[9];
String rev_version_out[9];
String state[8];
String state_out[8]; 
String voltage[7];
String voltage_out[7];
String current[7];
String current_out[7];
String energy[9];
String energy_out[9];
String charge[8];
String temp[7];
String resistance[7];

void setup() {
  BT.begin(9600);
  Serial.begin(9600);
  delay(1000);
  Serial.println("CAN bluetooth send test");
  //BT.listen();

  if (Canbus.init(CANSPEED_500)) {
    Serial.println("CAN Init ok");
  }
  else
  {
    Serial.println("Can't init CAN");
  }
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
          int x = i + 1;
          company[x] = message.data[i];
        }

      }

      else if (message.id == 0x621)
      {
        for (int i = 0; i < message.header.length; i++)
        {
          int x = i + 1;
          rev_version[x] = message.data[i];
        }

      }

      else if (message.id == 0x622)
      {
        for (int i = 0; i < message.header.length; i++)
        {
          int x = i + 1;
          state[x] = message.data[i];
        }

      }

      else if (message.id == 0x623)
      {
        for (int i = 0; i < message.header.length; i++)
        {
          int x = i + 1;
          voltage[x] = message.data[i];
        }

      }

      else if (message.id == 0x624)
      {
        for (int i = 0; i < message.header.length; i++)
        {
          int x = i + 1;
          current[x] = message.data[i];
        }

      }

      else if (message.id == 0x625)
      {
        for (int i = 0; i < message.header.length; i++)
        {
          int x = i + 1;
          energy[x] = message.data[i];
        }

      }

      else if (message.id == 0x626)
      {
        for (int i = 0; i < message.header.length; i++)
        {
          int x = i + 1;
          charge[x] = message.data[i];
        }

      }

      else if (message.id == 0x627)
      {
        for (int i = 0; i < message.header.length; i++)
        {
          int x = i + 1;
          temp[x] = message.data[i];
        }

      }

      else if (message.id == 0x628)
      {
        for (int i = 0; i < message.header.length; i++)
        {
          int x = i + 1;
          rev_version[x] = message.data[i];
        }

      }

    }
  }
  calculate_and_format();
  bluetooth_out();
  delay(1000);
}

void calculate_and_format() {
  company[0] = "#";
  rev_version[0] = "#";
  state[0] = "#";
  voltage[0] = #";
  current[0] = "#";
  energy[0] = "#";
  charge[0] = "#";
  temp[0] = "#";
  resistance[0] = "#";

    
}

void bluetooth_out() {

}
