int probRed = 50;

int redLed = 12;
int blueLed = 13;
int button1 = 2;

void setup() {
  pinMode(redLed, OUTPUT);
  pinMode(blueLed, OUTPUT);
  pinMode(button1, INPUT);
  randomSeed(analogRead(0));
  Serial.begin(9600);
}

void loop() {
  if (digitalRead(button1) == LOW) {
    int x = random(100);
    Serial.println(x);

    if(x < probRed) {
      digitalWrite(redLed, HIGH);
      delay(2000);
      digitalWrite(redLed, LOW);
    } else{
      digitalWrite(blueLed, HIGH);
      delay(2000);
      digitalWrite(blueLed, LOW);
    }
  }
}
