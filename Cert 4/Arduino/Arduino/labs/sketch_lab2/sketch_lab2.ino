int blueLedPin = 13; //Blue light is connected to pin 13 of the Arduino
int redLedPin = 12; //Red light is connected to pin 14 of the Arduino
int delayTime = 2000; //Number of milliseconds the LED's will be on for

void setup() {
  // put your setup code here, to run once:
  pinMode(blueLedPin, OUTPUT); //Setup the Blue LED pin as an output pin
  pinMode(redLedPin, OUTPUT); // Setup the Red LED as an outpin pin
}

void loop() {
  // put your main code here, to run repeatedly:
  digitalWrite(blueLedPin, HIGH); //Turn on the blue LED
  digitalWrite(redLedPin, LOW); //Turn off the red LED
  delay(delayTime);
  digitalWrite(blueLedPin, LOW); //Turn off the blue LED
  digitalWrite(redLedPin, HIGH); //Turn on the red LED
  delay(delayTime);
  
  
}
