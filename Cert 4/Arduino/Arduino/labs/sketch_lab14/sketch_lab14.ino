int lightPin = A1;
int data = 0;


void setup() {
  Serial.begin(9600);
}

void loop() {
  data = analogRead(lightPin);
  Serial.print("Light value =");
  Serial.println(data);
  delay(1000);
}
