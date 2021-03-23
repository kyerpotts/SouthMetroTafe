int rotationPin = A0;

int data  = 0;
int RGBRedPin = 9;
int RGBGreenPin = 10;
int RGBBluePin = 11;
int bVal = 1;

void setup() {
  Serial.begin(9600);
}

void loop() {
  data = analogRead(rotationPin);
  Serial.println(data);
  data = data / 300;
  switch (data){
    case 1:
    analogWrite(RGBRedPin, bVal);
    delay(1);
    analogWrite(RGBRedPin, LOW);
    break;

    case 2:
    analogWrite(RGBGreenPin, bVal);
    delay(1000);
    analogWrite(RGBGreenPin, LOW);
    break;

    case 3:
    analogWrite(RGBBluePin, bVal);
    delay(1000);
    analogWrite(RGBBluePin, LOW);
    break;

    default:
    analogWrite(RGBBluePin, LOW);
    delay(1000);
    break;
  }

}
