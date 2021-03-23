/*  
 *  Kyer Potts
 *  30003389
 */
#include "DHT.h"//include required file to control the temp/humidity sensor. Files avalable for download at:
//https://github.com/adafruit/Adafruit_Sensor and https://github.com/adafruit/DHT-sensor-library

 
//Inititalise Pins
int lightSensor = A1; //A1 light sensor pin
const int outsideTempSensor = A2; //A2 temperature sensor pin
int DHT11Pin = 4;//D4 DHT11 humidity and temperature sensor pin
DHT dht (DHT11Pin, DHT11);
int lightData = 0;//Stores data from light sensor
int LEDred = 12;//D12 Red LED pin
int LEDblue = 13;//D13 Blue LED pin
int moodRed = 9;//D9 Red mood light pin
int moodGreen = 10;//D10 Green mood light pin
int moodBlue = 11;//D11 Blue mood light pin
int buzzer = 5;//D5 buzzer pin

//Declare and initialise program variables
float outsideTemp = 0;//Stores temperature from A2 temperature sensor
float insideTemp = 0;//Stores temperature from D4 temperature sensor
float insideHumidity = 0;//Stores humidity from D4 humidity sensor
 
void setup() {
  Serial.begin(9600);//Begins serial monitor with Baud rate - 9600
  pinMode(outsideTempSensor, INPUT);//setup A2 as input pin
  dht.begin();
  pinMode(LEDred, OUTPUT);//setup D12 as output pin
  pinMode(LEDblue, OUTPUT);//setup D13 as output pin
  pinMode(moodRed, OUTPUT);//setup D9 as output pin
  pinMode(moodGreen, OUTPUT);//setup D10 as output pin
  pinMode(moodBlue, OUTPUT);//setup D11 as output pin
  pinMode(buzzer, OUTPUT);//setup D5 as output pin
}

void loop() {
  //Switch case control
  int serialData = Serial.parseInt();//Visual studio data link. Must pass through integer values.
  switch(serialData) {
    case 100: //if serialData feed presents '100'
      digitalWrite(LEDred, HIGH);//Turn on Red LED
      break;
    case 101://if serialData feed presents '101'
      digitalWrite(LEDred, LOW);//Turn off Red LED
      break;
    case 102://if serialData feed presents '102'
      digitalWrite(moodRed, HIGH);//Turn on red mood light
      digitalWrite(moodGreen, LOW); //Turn off green mood light
      digitalWrite(moodBlue, LOW); //Turn off blue mood light
      break;
    case 103://if serialData feed presents '103'
      digitalWrite(moodRed, LOW);//Turn off red mood light
      digitalWrite(moodGreen, HIGH); //Turn on green mood light
      digitalWrite(moodBlue, LOW); //Turn off blue mood 
      break;
    case 104://if serialData feed presents '104'
      digitalWrite(moodRed, LOW);//Turn off red mood light
      digitalWrite(moodGreen, LOW); //Turn off green mood light
      digitalWrite(moodBlue, HIGH); //Turn on blue mood 
      break;
    case 105://if serialData feed presents '105'
      digitalWrite(moodRed, LOW);//Turn off red mood light
      digitalWrite(moodGreen, LOW); //Turn off green mood light
      digitalWrite(moodBlue, LOW); //Turn off blue mood 
      break;
    case 106://if serialData feed presents '105'
      tone(buzzer, 1000, 500);//Initiates buzzing sound when VS program determines max temp exceeded
      break;
  }
  
  //Light sense control for blue LED
  lightData = analogRead(lightSensor);
  if(lightData > 500){
    delay(10000);//10 second delay
    digitalWrite(LEDblue, LOW);//Turns off blue light if light readings exceed 500
  } else {
    digitalWrite(LEDblue, HIGH);//Turns on blue light if light readings below 500
  }
  

  //Temperature and humidity readings
  outsideTemp = analogRead(outsideTempSensor);//Read temperature from A2 pin
  insideTemp = dht.readTemperature();//Read inside temperature from D4 pin
  insideHumidity = dht.readHumidity();//Read inside humidity from D4 pin

  //Prints readings to be read by VS program
  Serial.println(outsideTemp);//Print the outside temp to be read by VS interface
  Serial.println(insideTemp);//Print the inside temp to be read by VS interface
  Serial.println(insideHumidity);//Print the inside humidity value to be read by VS interface
  
  delay(100);//Delay all input/output by 10th of a second
}
