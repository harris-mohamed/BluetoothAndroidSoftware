#include <Canbus.h>
#include <defaults.h>
#include <global.h>
#include <mcp2515.h>
#include <mcp2515_defs.h>

int check = 0;
int error = 0;
byte id[7];
byte rev[7];
byte fault[6];
byte voltage[5];
byte current[5];
byte energy[7];
byte capacity[6];
byte temp[4];
byte resistance[4];

void setup() {
  Serial.begin(57600);
  Serial.println("CAN read - Testing program to read BMS for IFE");
  delay(1000);

  if (Canbus.init(CANSPEED_500))
    Serial.println("CAN Shield Initialized ok - Awesome!");
  else
    Serial.println("CAN Shield Initialization failed - feels bad man. Problem is in the shield or arduino.");

  delay(1000);
}

void loop() {

  tCAN message;

  if (mcp2515_check_message())
  {
    if (mcp2515_get_message(&message))
    {
    
      if (check == 0) {
        if (message.id == 0x620) {
          for (int i = 0; i < message.header.length; i++)id[i] = message.data[i];
        }
        Serial.println("Manufacturer: ");
        for (int i = 0; i < 8; i++)Serial.write(id[i]);
        check = 1;
      }

      if (check == 1) {
        if (message.id == 0x621) {
          for (int i = 0; i < message.header.length; i++)rev[i] = message.data[i];
        }
        Serial.println("Pack info: ");
        for (int i = 0; i < 3; i++)Serial.write(rev[i]);
        Serial.println("Hardware rev level: "); Serial.write(rev[3]);
        Serial.println("Software rev level: ");
        for (int i = 4; i < 8; i++)Serial.write(rev[i]);
        check = 2;
      }

      if (check == 2) {
        if (message.id == 0x622) {
          for (int i = 0; i < message.header.length; i++)fault[i] = message.data[i];
        }
        Serial.println("State: ");
        if (fault[0] & 0b0 == 0) {
          Serial.print("No state detected by BMS.");
        } else {
          Serial.print("State(s) detected by BMS:");
          error = 1;
        }
        if (error = 1) {
          if (fault[0]&0b00000011 == 0b00000011)Serial.print(" Contactor K1 is on. Refer to documentation for more information. "); 
          if (fault[0]&0b00000101 == 0b00000101)Serial.print(" Contactor K2 is on. Refer to documentation for more information. "); 
          if (fault[0]&0b00001001 == 0b00001001)Serial.print(" Contactor K3 is on. Refer to documentation for more information. "); 
          if (fault[0]&0b00010001 == 0b00010001)Serial.print(" Relay fault detected. Refer to documentation for more information. "); 
        }
        Serial.println("Powerup time: ");
        int timer = 0b0000000000000000; 
        int top_timer, bottom_timer; 
        bottom_timer = (int) fault[2];
        top_timer = (int) fault[1];
        timer = (top_timer<<8)|bottom_timer; 
        Serial.print(timer, DEC);Serial.print(" seconds."); 
        Serial.println("BMS flags : "); 
        if (fault[3]&0b00000001 == 0b00000001)Serial.print("There is power from the source. "); 
        if (fault[3]&0b00000010 == 0b00000010)Serial.print("There is power from the load. ");
        if (fault[3]&0b00000100 == 0b00000100)Serial.print("The interlock is tripped. "); 
        if (fault[3]&0b00001000 == 0b00001000)Serial.print("Hard wire contactor request. "); 
        if (fault[3]&0b00010000 == 0b00010000)Serial.print("CAN contactor request. "); 
        if (fault[3]&0b00100000 == 0b00100000)Serial.print("The HLIM is set and cannot charge. "); 
        if (fault[3]&0b01000000 == 0b01000000)Serial.print("The LLIM is set and cannot discharge. "); 
        if (fault[3]&0b10000000 == 0b10000000)Serial.print("The fan is on. ");  

        Serial.println("BMS Fault code: "); 
        if (fault[4] == 1)Serial.print("Driving off while plugged in. "); 
        if (fault[4] == 2)Serial.print("Interlock tripped. "); 
        if (fault[4] == 3)Serial.print("Communication fault with a bank or cell. "); 
        if (fault[4] == 4)Serial.print("Charge overcurrent. "); 
        if (fault[4] == 5)Serial.print("Discharge overcurrent. "); 
        /*
        if (fault[4] == 6)Serial.print("Over-temperature. "); 
        if (fault[4] == 7)Serial.print("Under voltage. "); 
        if (fault[4] == 8)Serial.print("Over voltage. "); 
        if (fault[4] == 9)Serial.print("No battery voltage. "); 
        if (fault[4] == 10)Serial.print("High voltage B- leak to chassis. "); 
        if (fault[4] == 11)Serial.print("High voltage B+ leak to chassis. "); 
        if (fault[4] == 12)Serial.print("Relay K1 is shorted. "); 
        if (fault[4] == 13)Serial.print("Contactor K2 is shorted. "); 
        if (fault[4] == 14)Serial.print("Contactor K3 is shorted. "); 
        if (fault[4] == 15)Serial.print("Open K1 or K3, or shorted K2. "); 
        if (fault[4] == 16)Serial.print("Open K2. "); 
        if (fault[4] == 17)Serial.print("Excessive precharge time. "); 
        if (fault[4] == 18)Serial.print("EEPROM stack overflow. "); 
        if (fault[4] == 19)Serial.print("Loss of CAN from HVFE. "); 
        */
        check = 3;
      }
      if (check == 3) {
        if (message.id == 0x623) {
          for (int i = 0; i < message.header.length; i++)voltage[i] = message.data[i];
        }
        Serial.println("Pack Voltage: "); 
        int volts; 
        int upper_volts, lower_volts; 
        lower_volts = (int) voltage[0]; 
        upper_volts = (int) voltage[1]; 
        volts = (upper_volts<<8)|(lower_volts); 
        Serial.print(volts,DEC);Serial.print(" kV."); 

        Serial.println("Lowest voltage: ");Serial.print(voltage[2],DEC);Serial.print("V");
        Serial.println("ID of lowest voltage cell: ");Serial.print(voltage[3],DEC);
        Serial.println("Highest voltage: ");Serial.print(voltage[4],DEC);Serial.print("V");
        Serial.println("ID of highest voltage cell: ");Serial.print(voltage[5],DEC);
        check = 4;
      }
      if (check == 4) {
        if (message.id == 0x624) {
          for (int i = 0; i < message.header.length; i++)current[i] = message.data[i];
        }
        int amps; 
        int upper_current, lower_current; 
        lower_current = (int) current[0]; 
        upper_current = (int) current[1]; 
        amps = (upper_current<<8)|lower_current;
        Serial.println("Current on the car is: ");Serial.print(amps,DEC);Serial.print(" kA.");
        check = 5;
      }
      if (check == 5) {
        if (message.id == 0x625) {
          for (int i = 0; i < message.header.length; i++)energy[i] = message.data[i];
        }
      }
      if (check == 6) {
        if (message.id == 0x626) {
          for (int i = 0; i < message.header.length; i++)capacity[i] = message.data[i];
        }
        check = 7;
      }
      if (check == 7) {
        if (message.id == 0x627) {
          for (int i = 0; i < message.header.length; i++)temp[i] = message.data[i];
        }
        int temperature; 
        temperature = (int) temp[0]; 
        Serial.println("Temperature of the car is: ");Serial.print(temperature, DEC);Serial.print("°C"); 
        Serial.println("Lowest temp on the car is: ");Serial.print(temp[2],DEC);Serial.print("°C"); 
        Serial.println("ID of the lowest temp in the car: ");Serial.print(temp[3],DEC);
        Serial.println("Highest temp on the car is: ");Serial.print(temp[4],DEC);Serial.print("°C"); 
        Serial.println("ID of the lowest temp in the car: ");Serial.print(temp[5],DEC);
        check =8;
      }
      if (check == 8) {
        if (message.id == 0x628) {
          for (int i = 0; i < message.header.length; i++)resistance[i] = message.data[i];
        }
        check =0;
      }
    }
  }
  //check++;
  error = 0;
  //if (check > 8)check = 0;
  delay(1000);
}
