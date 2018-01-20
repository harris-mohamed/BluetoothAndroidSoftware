#include <SoftwareSerial.h>
#include <Canbus.h>
#include <defaults.h>
#include <global.h>
#include <mcp2515.h>
#include <mcp2515_defs.h>


SoftwareSerial BT(10,11);    //RX, TX

void setup() {
  
  //Serial.begin(9600); 
   

  BT.begin(9600);
  delay(1000);
  BT.write("test");
  //Serial.println("CAN bluetooth send test");  
    //if(Canbus.init(CANSPEED_500)) { 
   // Serial.println("CAN Init ok");
    //.write("h");
    //}
  //else
  //{
    //Serial.println("Can't init CAN");
   // BT.write("h");
  //}
 
  delay(1000);
}



void loop(){
  BT.listen();
byte company[9];
String string[9];
  tCAN message;
  //Serial.write("hello");

if (mcp2515_check_message()) 
  {
    if (mcp2515_get_message(&message)) 
  {
        if(message.id == 0x620)  
             {
                for(int i=0;i<message.header.length;i++) 
                { 
                  company[i] = message.data[i]; 
                  string[i] = (String) company[i];
                   
                }

             }   
  //Serial.write(string[0]);
  BT.write("hi");

           }}
    delay(1000);                        
}
