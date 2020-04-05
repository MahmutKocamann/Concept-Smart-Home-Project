#include <Servo.h>
#include <SoftwareSerial.h>
#define trigPin 10
#define echoPin 9

Servo sg90;
Servo sg91;
Servo sg92;
const int pinBuz = 3; //Buzzer Pin
const int pinSwi = 2; // Push-button pin
int esikdeger=200;
int sensorPin=A0;
int servoPin=8;
int servoPin2=11;
int servoPin3=12;
int veri;
int deger;

void setup() {
  // put your setup code here, to run once:
 Serial.begin(9600);


pinMode(trigPin, OUTPUT);
pinMode(echoPin, INPUT);
sg90.attach(8);
sg91.attach(11);
sg92.attach(12);
 pinMode(pinBuz,OUTPUT); //Defines pinBuz as an Output 
 pinMode(pinSwi,INPUT); // Defines pinSwi as an input 

}


void loop() {
  int botao; // To save the last logic state of the button
      botao = digitalRead(pinSwi); //Put the reading value of the switch on botao
      Serial.print(botao); //Shows the logic state of the input on Serial Monitor 
      if (botao == 1) // Pressed button, logic State HIGH (5V)
      {
      digitalWrite(pinBuz,1); //Switch pressed, buzzer on 
      }else
      { 
      digitalWrite(pinBuz,0); //If the switch isn’t pressed, buzzer off. 
      } 
      delay(10); //reading delay
  veri=analogRead(sensorPin);
long sure, mesafe;
digitalWrite(trigPin, LOW);
delayMicroseconds(2);
digitalWrite(trigPin, HIGH);
delayMicroseconds(10);
digitalWrite(trigPin, LOW);
sure = pulseIn(echoPin, HIGH);
mesafe = (sure/2) / 29.1;
  Serial.print("*");
   Serial.print(mesafe);
   
   Serial.print("*");
   Serial.println(veri);
   
delay(1000);
if (Serial.available())
 {
    deger = Serial.read();
    if (deger == '1')
    {sg90.write(90);
    
              }
    if (deger == '0'){
   sg90.write(0);
}
 if (deger == '2')
    {sg91.write(90);
    
              }
    if (deger == '3'){
   sg91.write(0);
}
 if (deger == '4')
    {sg92.write(90);
    
              }
    if (deger == '5'){
   sg92.write(0);
}
  
      } 

}
