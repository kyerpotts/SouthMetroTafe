int lightPin = A1;
int data = 0;
int bluePin = 13;
int redPin = 12;

void setup() {
  Serial.begin(9600);

}

void loop() {
  data = analogRead(lightPin);
  Serial.println(data);
  if(data > 500){
    digitalWrite(redPin, HIGH);
    digitalWrite(bluePin, LOW);
  } else{
    digitalWrite(bluePin, HIGH);
    digitalWrite(redPin, LOW);
  }
  delay(1000);
}
