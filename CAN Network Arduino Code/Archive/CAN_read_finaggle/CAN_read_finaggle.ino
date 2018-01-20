#include <Canbus.h>
#include <defaults.h>
#include <global.h>
#include <mcp2515.h>
#include <mcp2515_defs.h>

//int sample_id_620[] = {0x45, 0x4C, 0x49, 0x54, 0x48, 0x49, 0x4F, 0x4E};
//int sample_id_621[] = {0x32, 0x43, 0x4E, 0x46, 0x32, 0x2E, 0x33, 0x35};
//int sample_id_622[5]; 
//int sample_id_623[] = {0x01, 0x13, 0x20, 0xa7, 0x21, 0xA6};
//int sample_id_627[] = {0x17, 0x00, 0x17, 0xA5, 0x18, 0xA7};
//int sample_id_680[] = {0x25, 0xFF, 0x08};
//int out_620[7], out_621[7], out_623[5], out_627[5], out_680[2], out_622[5];

void setup() {
  Serial.begin(9600);
  if(Canbus.init(CANSPEED_500))  //Initialise MCP2515 CAN controller at the specified speed
    Serial.println("CAN Init ok");
  else
    Serial.println("Can't init CAN");
  delay(1000);
}

void loop() {
int sample_id_620[7];
  tCan message; 
  if (mcp2515_check_message()) {
    {
    if (mcp2515_get_message(&message)) 
  {
    if(message.id == 0x620){

   Serial.println("Basic info: ");
    
  for (int i = 0; i<8; i++){
    message.data[i]= sample_id_620[i];
        Serial.println(sample_id_620[i]);
  }}}}
}
/*
Serial.println(" ");

for (int i = 0; i<8; i++){
    out_621[i]= sample_id_621[i];
}

for (int i = 0; i<3; i++){
        Serial.println( out_621[i]);
}

Serial.println("\n");
Serial.println("Hardware rev: ");
Serial.println(out_621[3]); 
Serial.println("Software rev: ");

for (int i = 4; i<8; i++){
    Serial.println( out_621[i]);
}

for (int i = 0; i < 6; i++){
    sample_id_622[i] = out_623[i];
}

Serial.println("\n");

if (out_622[0] && 0b00000001){
    Serial.println("State:");
    if (out_622 && 0b00000010)Serial.println(" Contactor K1 is on.");
    if (out_622 && 0b00000100)Serial.println(" Contactor K2 is on.");
    if (out_622 && 0b00001000)Serial.println(" Contactor K3 is on.");
    if (out_622 && 0b00010000)Serial.println(" Relay fault detected.");
} else {
    Serial.println("No fault detected.");
}

Serial.println("\nPowerup Time: ");
Serial.println( out_622[1]);
Serial.println( out_622[2]);
Serial.println(" s.");

if (out_622[3] == 0x00){
   Serial.println(" \nNo flags thrown.");
} else {
    if (out_622[3] && 0b00000001)Serial.println(" (1) There is power from the source.");
    if (out_622[3] && 0b00000010)Serial.println(" (2) There is power from the load.");
    if (out_622[3] && 0b00000100)Serial.println(" (3) The interlock is tripped.");
    if (out_622[3] && 0b00001000)Serial.println(" (4) There is a hard wire contactor request.");
    if (out_622[3] && 0b00010000)Serial.println(" (5) There is a CAN contactor request.");
    if (out_622[3] && 0b00100000)Serial.println(" (6) HLIM is set and cannot charge.");
    if (out_622[3] && 0b01000000)Serial.println(" (7) LLIM is set and cannot discharge.");
    if (out_622[3] && 0b10000000)Serial.println(" (8) The FAN is on.");
}


if (out_622[4] == 0){
    Serial.println(" \nNo faults thrown.");
} else {
    if (out_622[4] == 1)Serial.println(" (1) Driving off while plugging in.");
    if (out_622[4] == 2)Serial.println(" (2) Interlock is tripped.");
    if (out_622[4] == 3)Serial.println(" (3) Communication fault with a bank or cell.");
    if (out_622[4] == 4)Serial.println(" (4) Charge overcurrent.");
    if (out_622[4] == 5)Serial.println(" (5) Discharge overcurrent.");
    if (out_622[4] == 6)Serial.println(" (6) Over-temperature.");
    if (out_622[4] == 7)Serial.println(" (7) Under voltage.");
    if (out_622[4] == 8)Serial.println(" (8) Over voltage.");
    if (out_622[4] == 9)Serial.println(" (9) No battery voltage.");
    if (out_622[4] == 10)Serial.println(" (10) High voltage B- leak to chassis.");
    if (out_622[4] == 11)Serial.println(" (11) High voltage B+ leak to chassis.");
    if (out_622[4] == 12)Serial.println(" (12) Relay K1 is shorted.");
    if (out_622[4] == 13)Serial.println(" (13) Contactor K2 is shorted.");
    if (out_622[4] == 14)Serial.println(" (14) Contactor K3 is shorted.");
    if (out_622[4] == 15)Serial.println(" (15) Open K1 or K3, or shorted K2.");
    if (out_622[4] == 16)Serial.println(" (16) Open K2.");
    if (out_622[4] == 17)Serial.println(" (17) Excessive precharge time.");
    if (out_622[4] == 18)Serial.println(" (18) EEPROM stack overflow.");
    if (out_622[4] == 19)Serial.println(" (19) Loss of CAN from HVFE.");
}
  */
}

        

