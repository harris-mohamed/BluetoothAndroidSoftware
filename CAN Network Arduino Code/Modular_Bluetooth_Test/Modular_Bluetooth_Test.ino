#include <SoftwareSerial.h>
#include <Canbus.h>
#include <defaults.h>
#include <global.h>
#include <mcp2515.h>
#include <mcp2515_defs.h>


SoftwareSerial BT = SoftwareSerial(3,4);    //RX, TX

void setup() {
  Serial.begin(9600); 
  delay(1000);
  BT.write("test");
  Serial.println("CAN bluetooth send test"); 
  BT.listen(); 
   
    if(Canbus.init(CANSPEED_500)) { 
    Serial.println("CAN Init ok");
     BT.begin(9600);
    //BT.write("dope");
    Serial.write("h");
    }
  else
  {
    Serial.println("Can't init CAN");
    BT.write("hi");
  }

  delay(1000);
}



void loop(){
  tCAN message;
  //Bluetooth();
if (mcp2515_check_message()) 
  {
    if (mcp2515_get_message(&message)) 
  {
        if(message.id == 0x621)  
             {
                for(int i=0;i<message.header.length;i++) 
                { 
                  BT.write(message.data[i]);

                }

             }   
           }}
    delay(1000);                        
}


