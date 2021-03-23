/*
  Instructions: The RGB LED is connected to a Pulse Width Modulation(PWM) pin.
  You can use analogWrite to control brightness.
*/
int RGBRedPin = 9; //The red RGB LED is connected pin 9 of the Arduino.
int RGBGreenPin = 10; //The green RGB LED is connected pin 10 of the Arduino.
int RGBBluePin = 11; //The blue RGB LED is connected pin 11 of the Arduino.
int waitTime = 500; //Sets the amount of time to wait between colour changes.
int bVal = 1; //Sets the brightness for the lights
void setup() { //The Setup function runs once.
  pinMode(RGBRedPin, OUTPUT); //Setup red RGB LED pin as an output pin.
  pinMode(RGBGreenPin, OUTPUT); //Setup green RGB LED pin as an output pin.
  pinMode(RGBBluePin, OUTPUT); //Setup blue RGB LED pin as an output pin.
}
void loop() { //The loop function runs forever.

  //Display Red
  analogWrite(RGBRedPin, bVal); //Turn on RED
  delay(waitTime); //Wait for 2 seconds
  analogWrite(RGBRedPin, LOW); //Turn off Red
  //Display Green
  analogWrite(RGBGreenPin, bVal); //Turn on GREEN
  delay(waitTime); //Wait for 2 seconds
  analogWrite(RGBGreenPin, LOW); //Turn off GREEN
  //Display Blue
  analogWrite(RGBBluePin, bVal); //Turn on BLUE
  delay(waitTime); //Wait for 2 seconds
  analogWrite(RGBBluePin, LOW); //Turn off BLUE
  //Display Magenta (Red + Blue)
  analogWrite(RGBRedPin, bVal); //Turn on RED
  analogWrite(RGBBluePin, bVal); //Turn on BLUE
  delay(waitTime); //Wait for 2 seconds
  analogWrite(RGBRedPin, LOW); //Turn off Red
  analogWrite(RGBBluePin, LOW); //Turn off BLUE
  //Display Yellow (Red + Green)
  analogWrite(RGBRedPin, bVal); //Turn on RED
  analogWrite(RGBGreenPin, bVal); //Turn on GREEN
  delay(waitTime); //Wait for 2 seconds
  analogWrite(RGBRedPin, LOW); //Turn off Red
  analogWrite(RGBGreenPin, LOW); //Turn off GREEN
  //Display Cyan (Blue + Green)
  analogWrite(RGBBluePin, bVal); //Turn on BLUE
  analogWrite(RGBGreenPin, bVal); //Turn on GREEN
  delay(waitTime); //Wait for 2 seconds
  analogWrite(RGBBluePin, LOW); //Turn off BLUE
  analogWrite(RGBGreenPin, LOW); //Turn off GREEN
  //Display White (Red + Blue + Green)
  analogWrite(RGBRedPin, bVal); //Turn on RED
  analogWrite(RGBBluePin, bVal); //Turn on BLUE
  analogWrite(RGBGreenPin, bVal); //Turn on GREEN
  delay(waitTime); //Wait for 2 seconds
  analogWrite(RGBRedPin, LOW); //Turn off RED
  analogWrite(RGBBluePin, LOW); //Turn off BLUE
  analogWrite(RGBGreenPin, LOW); //Turn off GREEN

  
}
