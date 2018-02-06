#include <SoftwareSerial.h>
#include <Canbus.h>
#include <defaults.h>
#include <global.h>
#include <mcp2515.h>
#include <mcp2515_defs.h>


SoftwareSerial BT = SoftwareSerial(3, 4);   //RX, TX

String company[8];
String company_out[9];
String rev_version[8];
String rev_version_out[9];
String state[7];
String state_out[8];
String voltage[6];
String voltage_out[7];
String current[7];
String current_out[3];
String energy[8];
String energy_out[9];
String charge[7];
String charge_out[8];
String temp[6];
String temp_out[7];
String resistance[6];
String resistance_out[7];

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
          company[i] = message.data[i];
        }

      }

      else if (message.id == 0x621)
      {
        for (int i = 0; i < message.header.length; i++)
        {
          rev_version[i] = message.data[i];
        }

      }

      else if (message.id == 0x622)
      {
        for (int i = 0; i < message.header.length; i++)
        {
          state[i] = message.data[i];
        }

      }

      else if (message.id == 0x623)
      {
        for (int i = 0; i < message.header.length; i++)
        {
          voltage[i] = message.data[i];
        }

      }

      else if (message.id == 0x624)
      {
        for (int i = 0; i < message.header.length; i++)
        {
          current[i] = message.data[i];
        }

      }

      else if (message.id == 0x625)
      {
        for (int i = 0; i < message.header.length; i++)
        {
          energy[i] = message.data[i];
        }

      }

      else if (message.id == 0x626)
      {
        for (int i = 0; i < message.header.length; i++)
        {
          charge[i] = message.data[i];
        }

      }

      else if (message.id == 0x627)
      {
        for (int i = 0; i < message.header.length; i++)
        {
          temp[i] = message.data[i];
        }

      }

      else if (message.id == 0x628)
      {
        for (int i = 0; i < message.header.length; i++)
        {
          rev_version[i] = message.data[i];
        }

      }

    }
  }
  calculate_and_format();
  bluetooth_out();
  delay(1000);
}

void calculate_and_format() {
  company_out[0] = "#";
  rev_version_out[0] = "#";
  state_out[0] = "#";
  voltage_out[0] = "#";
  current_out[0] = "#";
  energy_out[0] = "#";
  charge_out[0] = "#";
  temp_out[0] = "#";
  resistance_out[0] = "#";

  unsigned int timeon_highbyte, timeon_lowbyte, powerup_time;
  String converted_time;

  for (int x = 0; x < 8; x++) {
    company[x] = company_out[x + 1];
    rev_version[x] = rev_version_out[x + 1];
  }

  timeon_highbyte = state[1].toInt();
  timeon_lowbyte = state[2].toInt();
  powerup_time = ((timeon_highbyte << 8) || timeon_lowbyte);
  converted_time = (String) powerup_time;
  state_out[1] = converted_time;

  unsigned int voltage_highbyte, voltage_lowbyte, voltage_actual;
  String converted_voltage;

  voltage_highbyte = voltage[0].toInt();
  voltage_lowbyte = voltage[1].toInt();
  voltage_actual = ((voltage_highbyte << 8) || voltage_lowbyte);
  converted_voltage = (String) voltage_actual;

  voltage_out[0] = converted_voltage;
  for (int x = 1; x < 8; x++) {
    voltage_out[x] = voltage_out[x - 1];
  }

  signed int current_highbyte, current_lowbyte, current_actual, charge_highbyte;
  signed int charge_lowbyte, charge_actual, discharge_highbyte, discharge_lowbyte;
  signed int discharge_actual;
  String converted_current, converted_charge, converted_discharge; 

  current_highbyte = current[0].toInt();
  current_lowbyte = current[1].toInt();
  current_actual = ((current_highbyte << 8) || current_lowbyte); 
  converted_current = (String) current_actual;

  charge_highbyte = current[2].toInt();
  charge_lowbyte = current[3].toInt();
  charge_actual = ((charge_highbyte << 8) || charge_lowbyte);
  converted_charge = (String) charge_actual; 

  discharge_highbyte = current[4].toInt();
  discharge_lowbyte = current[5].toInt(); 
  discharge_actual = ((discharge_highbyte << 8) || discharge_lowbyte); 
  converted_discharge = (String) discharge_actual; 

  current_out[0] = converted_current;
  current_out[1] = converted_charge;
  current_out[2] = converted_discharge;
}

void bluetooth_out() {

}
