int blueLedPin = 12;
int onTime = 2000;
int offTime = 500;

void setup() {
  // put your setup code here, to run once:
  pinMode(blueLedPin, OUTPUT);
}

void loop() {
  // put your main code here, to run repeatedly:
  digitalWrite(blueLedPin, HIGH);
  delay(onTime);
  digitalWrite(blueLedPin, LOW);
  delay(offTime);
}
