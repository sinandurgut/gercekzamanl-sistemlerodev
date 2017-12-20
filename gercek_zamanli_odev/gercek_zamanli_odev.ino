#include <LiquidCrystal.h>
float sicaklik;
float olculenDeger;
int sicaklikPin = 8;
int trigPin = 15; 
int echoPin = 16; 
float uyariDerecesi = 28;
bool uyariStatu = false;
int sure ;
int mesafe ;


int keypad_read = 0;

// LCD panelin kullanacağı pinleri yazıyoruz.
LiquidCrystal lcd(8, 9, 4, 5, 6, 7);

void setup() {
  Serial.begin(9600);
pinMode(trigPin , OUTPUT);
pinMode(echoPin ,INPUT);
lcd.begin(16, 2); // 16*2 kullandığımız için 16,2 olarak başlatıyoruz.
 
}

float getSicaklik() {
  olculenDeger = analogRead(sicaklikPin); //A1'den değeri alacak
  olculenDeger = (olculenDeger / 1023) * 5000; //değeri mV'a dönüştürecek
  sicaklik = olculenDeger / 10, 0; // mV'u sicakliğa dönüştürecek

  return sicaklik;
}
int mesafefunc()
{
  digitalWrite(trigPin , HIGH);
  delayMicroseconds(1000);
  digitalWrite(trigPin , LOW);
  sure = pulseIn(echoPin , HIGH);
  mesafe = (sure/2) / 29.1;
  
  return mesafe;
}


void ekranaBas(String parametre,int delayPar){
  lcd.setCursor(0,0); // 0,0 cursoru 0,0 a ayarlıyoruz.
 lcd.print(parametre); 
 delay(delayPar);
}
void ekranaBas(String parametre,int delayPar,int col,int row){
  lcd.setCursor(col,row); // 0,0 cursoru 0,0 a ayarlıyoruz.
 lcd.print(parametre); 
 delay(delayPar);
}
void loop() {
  lcd.clear();
  float alinanSicaklik = getSicaklik();
  int mesafem = mesafefunc();
  ekranaBas("Sicaklik : " + String(alinanSicaklik),0,0,0);
  String kapiStatu = "";
  if(mesafe > 4)
    kapiStatu = "Acik";
   else
    kapiStatu = "Kapali";
  ekranaBas("Kapi : "+ kapiStatu ,0,0,1);
  //\"sensor\":\"gps\",
  String json = "{\"Sicaklik\":"+ String(alinanSicaklik) +",\"Mesafe\":"+mesafem+",\"UyariDerece\":"+uyariDerecesi+"}";
  if(Serial.available() > 0)
  {
    String serialInput = Serial.readString();
    int key = serialInput.substring(0,1).toInt();
    String value = serialInput.substring(1);
    
    switch(key){
      case 1:
        uyariDerecesi = value.toInt();
       break;
       case 2:
       lcd.clear();
       ekranaBas("Merhaba "+ value.substring(0,value.length()-1),2000);
       break;
    }
    Serial.println(serialInput);    
    
  }
  Serial.println(json);
  delay (2000);
}


