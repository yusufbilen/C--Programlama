var kdvOrani = 1.08;


Console.WriteLine(500*kdvOrani);  // urunA
Console.WriteLine(600*kdvOrani);  // urunB
Console.WriteLine(700*kdvOrani);  // urunC

var sayi = 20;
var urunAdi = "Samsung a23s";
var urun_Adi = "İphone 14 Pro";
var sayi2 = 10;
var sayi3 = 10;
var fiyat = 10.000;
var Fiyat = 10.000;
Console.WriteLine(sayi);
Console.WriteLine(urunAdi);
Console.WriteLine(urun_Adi);
Console.WriteLine(sayi2);
Console.WriteLine(sayi3);
Console.WriteLine(Fiyat);
Console.WriteLine(fiyat);

var ogrenciAdi = "Ahmet";
var ogrenciSoyadi = " Turan";

var adSoyad = ogrenciAdi + ogrenciSoyadi;
Console.WriteLine(ogrenciAdi);
Console.WriteLine(ogrenciSoyadi);
Console.WriteLine(adSoyad);

var urun1 = 215;
var urun2 = 245;
var urun3 = 235;
var toplam = urun1 + urun2 + urun3;
Console.WriteLine(toplam);

int sayi = 10000;
byte kitle = 255;
double kdv = 1.18;
float vergi = 1.20f;
decimal oran = 1.18m;
char cinsiyet ='K';
string cinsiyet2 = "Kadin";
var olanak = false;

Console.Write("1.sayi: ");
var sayi1 = Console.ReadLine();

Console.Write("2.sayi: ");
var sayi2 = Console.ReadLine();
var toplam = sayi2 + sayi1;
Console.WriteLine(toplam);


Console.Write("1.sayi: ");
var sayi1 = Convert.ToInt32(Console.ReadLine());

Console.Write("2.sayi: ");
var sayi2 = Convert.ToInt32(Console.ReadLine());
var toplam = sayi2 + sayi1;
Console.WriteLine(toplam);

long d = 30;
int c = d; // bilinçsiz dönüşüm 

long e = 10;
int k = (int) e; // bilinçli dönüşüm

int y = 100;
double x = y; // bilinçli bir dönüşüm

nULLABLE tYPE


char cinsiyet = 'E'; // Tek karakter yazılabilir

string cinsiyet2 = "Erkek";  // istediğimiz kadar karakter yazabiliriz

string yas = " 20";
string ad = " Ahmet";
string soyad = " Turan";

string mesaj = ad +""+soyad+" isimli kişi"+yas+" yaşındadır";
Console.WriteLine(mesaj);


string mesaj = "Yusuf Bilen isimli kişi 22 yaşındadır";

var sonuc = mesaj.Length;       // mesajda kullanılan karakter sayısını veriri.

var sonu2 = mesaj.ToLower();    // mesajda bulunan tüm karakterleri küçük harflerle yazdırır.

var sonu3 = mesaj.ToUpper();    // mesajda bulunan tüm harfleri büyük harflerle yazdırır.

var sonu4 = mesaj.Trim();       // 

var sonu5 = mesaj.Split(" ")[0];// Mesajda bulunan ilk kelimeyi veriri

var sonu6 = mesaj[0];           // Mesajda bulunan ilk karakteri veriri

var sonu7 = mesaj.StartsWith("B");// mesajda verilen ilk karakteri doğru bilip bilmediğimizi bize gösterir

var sonu8 = mesaj.EndsWith("."); // mesajda bulunan son karakteri doğru bilip bilmediğimizi bie gösterir.

var sonu9 = mesaj.Contains("Yusuf"); // mesajda bu kelimenin olup olmadığını bize gösteriri

var sonu10 = mesaj.IndexOf("abc"); // mesajda bu karakterlerin olup olmadığını bize gösterir

var sonu11 = mesaj.Substring(6, 5);



Console.WriteLine(mesaj);

Console.WriteLine(sonuc);

Console.WriteLine(sonu2);

Console.WriteLine(sonu3);

Console.WriteLine(sonu4);

Console.WriteLine(sonu5);

Console.WriteLine(sonu6);

Console.WriteLine(sonu7);

Console.WriteLine(sonu8);

Console.WriteLine(sonu10);

Console.WriteLine(sonu11);

string kursAdi = ".NET 7 ile C# Programlama Dili";

// 1- kaç karaktere sahiptir
var karaktersayisi = kursAdi.Length;
Console.WriteLine(karaktersayisi);

// 2- hepsini küçük harfli yap 
var kucuk = kursAdi.ToLower();
Console.WriteLine(kucuk);

// 3- "." ile mi başlamaktadır
var baslangic = kursAdi.StartsWith(".");
Console.WriteLine(baslangic);

//4- C# kelimesi hangi konumdadır
var konum = kursAdi.IndexOf("C#");
Console.WriteLine(konum);

// 5- string C# bilgisi içeriyor mu?
var icerik = kursAdi.Contains("C#");
Console.WriteLine("konum" +icerik);

// 6- 'Dili' kelimwsi yerine 'Dersleri' yazınız.
var degistir = kursAdi.Replace("Dili","Dersleri");
Console.WriteLine(degistir);


// DATA TİME 

var simdi = DateTime.Now;
Console.WriteLine(simdi);
Console.WriteLine(simdi.Year);
Console.WriteLine(simdi.Month);
Console.WriteLine(simdi.Day);

DateTime dt = new DateTime(2018, 12, 12,20 ,20 ,20);
DateTime dt2 = dt.AddYears(1);
DateTime dt3 = dt.AddDays(10);

Console.WriteLine(dt3);
Console.WriteLine(dt2);

var fark = simdi - dt;
Console.WriteLine(fark.TotalDays);
Console.WriteLine(fark.TotalHours);

// bu çalışmada şu anki tarihi ve geçmişte bulunan bir tarihi yazmayı ve egçmişte ki tarihi artırmayı öprendik daha sonra geçmişte ki tarihi şimdiki tarihten çıkararak geçen zamanı öğrendik.


// Diziler

var kursAdi = ".net 7 ile c# programlama dersleri".Split(' ');
string[] isimler = new string[5];
isimler[0] = "ahmet";
isimler[1] = "ali";
isimler[2] = "canan";
isimler[3] = "çınar";
isimler[4] = "esma";

int[] numaralar = new int[5];

numaralar[0] = 100;
numaralar[1] = 200;
numaralar[2] = 300;
numaralar[3] = 400;
numaralar[4] = 500;

Console.WriteLine($"{numaralar[0]} numaralı öğrencinin adı {isimler[0]}");


string[] sehirler = {"İstanbul","Rize","Kocaeli"};

sehirler.SetValue("Sakarya",1);

Console.WriteLine(sehirler.GetValue(1));
Console.WriteLine(sehirler.Length);
Console.WriteLine(Array.IndexOf(sehirler,"rize"));

Array.Sort(sehirler);

Console.WriteLine(sehirler.GetValue(0));
Console.WriteLine(sehirler.GetValue(1));


string[] iller = new string[5];

iller[0] = "muş";
iller[1] = "ankara";
iller[2] = "bursa";
iller[3] = "trabzon";
iller[4] = "bitlis";

int[] plakalar = new int[5];

plakalar[0] = 49;
plakalar[1] = 06;
plakalar[2] = 16;
plakalar[3] = 61;
plakalar[4] = 13;

Console.WriteLine($"{iller[0 ]} ilimiz {plakalar[0]} nolu plakaya aittir:)");

String[] sehirler = {"zonguldak", "rize", "kocaeli", "istanbul", "ankara"};

//  var sonuc = sehirler[0..3];

 foreach(var i in sehirler) {

    Console.WriteLine(i);
 }

 string il = "Kocaeli";
 Console.WriteLine(il[..5]);

Dizi Uygulama

string[] ogrenci = new string[3];

int[] notlar = new int[3];
Console.WriteLine("1.Öğrenci adı: ");
ogrenci[0] = Console.ReadLine() ??"";

Console.WriteLine("1.Öğrenci Notu: ");
notlar[0] = Convert.ToInt32(Console.ReadLine());

 Console.WriteLine("2.Öğrenci adı: ");
ogrenci[1] = Console.ReadLine() ??"";

Console.WriteLine("2.Öğrenci Notu: ");
notlar[1] = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("3.Öğrenci adı: ");
ogrenci[2] = Console.ReadLine() ??"";

Console.WriteLine("3.Öğrenci Notu: ");
notlar[2] = Convert.ToInt32(Console.ReadLine());

foreach(var i in ogrenci){
    Console.WriteLine(i);
}

foreach(var not in notlar){
    Console.WriteLine(not);
}

Çok Boyutlu Diziler:)

using System.Linq.Expressions;

string[] ogrenciler = {"Ali", "Mehmet", "Canan"};
int[,] notlar = new int[3,3];

//Ali
notlar[0,0] = 30;
notlar[0,1] = 60;
notlar[0,2] = 20;

//Mehmet
notlar[1,0] = 30;
notlar[1,1] = 10;
notlar[1,2] = 40;

//Canan
notlar[2,0] = 90;
notlar[2,1] = 90;
notlar[2,2] = 100;
var ortalama_1 = (notlar[0,0] + notlar[0,1] + notlar[0,2]) / 3;
var ortalama_2 = (notlar[1,0] + notlar[1,1] + notlar[1,2]) / 3;
var ortalama_3 = (notlar[2,0] + notlar[2,1] + notlar[2,2]) / 3;

Console.WriteLine($"{ogrenciler[0]} isimli öğrencinin not ortalaması: {ortalama_1}");
Console.WriteLine($"{ogrenciler[1]} isimli öğrencinin not ortalaması: {ortalama_2}");
Console.WriteLine($"{ogrenciler[2]} isimli öğrencinin not ortalaması: {ortalama_3}");

int[] x = {20,10};
int[] y = x;
Console.WriteLine(x[0]);
Console.WriteLine(y[0]);


x[0] = 1;

Console.WriteLine(x[0]);
Console.WriteLine(y[0]);

var a = 10;
var b = 3;
var c = 2;
var sonuc = a + b;
var sonuc = a - b;
var sonuc = a * b;
var sonuc = (float)a / (float)b;
var sonuc = (a + b) * c;
var sonuc = a % b;
var sonuc = ++a  // a değerini 1 arttırma özelliği

Console.WriteLine(sonuc);

int a = 10;
int b = 5;
int c = 3;

var sonuc = (c - a) *b;
Console.WriteLine(sonuc);

int? a = null;
int b = 10;

var sonuc = (a ?? 0) + b;
Console.WriteLine(sonuc);

int a = 10;
int b = 20;
a = b--;

Console.WriteLine(a);
Console.WriteLine(b);


Console.WriteLine("Sayı: ");
int sayi = int.Parse(Console.ReadLine() ?? "0"); 
var sonuc = sayi % 2;
Console.WriteLine(sonuc); // 1 ise sayı tek 0 ise sayı çifttir


a+=b => a = a + b
a-=b => a = a - b
a*=b => a = a * b
a/=b => a = a / b
a%=b => a = a % b

var a = 5;
var b = 10;
a += b;
Console.WriteLine(a);

Math Sınıfı 

double sonuc;
sonuc = Math.Pow(2,3);
sonuc = Math.Sqrt(25);
sonuc = Math.Abs(-3);
sonuc = Math.Round(4.5);
sonuc = Math.Ceiling(3.3);
sonuc = Math.Floor(2.3);
sonuc = Math.Max(2,3);
sonuc = Math.Min(2,3);

Console.WriteLine(sonuc);

Atama oparatörleri

int a = 10, b = 20, c = 5;

string pasword = "12345";

var sonuc = (a == b);
sonuc = (c == 4);
sonuc = (pasword == "12345");

// var sonuc_2 = (a >= b) ? " a büyük":"b büyük";
var sonuc_2 = (a >= b) ? " a büyük":(a == b) ? "a  b eşit":"b büyük";


Console.WriteLine(sonuc_2);

Console.Write("yaşınız: ");

var yas = Convert.ToInt32(Console.ReadLine());

var sonuc = (yas >= 18) ? "Ehliyet alabilirsiniz":"Ehliyet alamazsınız";
Console.WriteLine("Ehliyet alabilme durumu: " + sonuc);

Console.Write("Sayı: ");
var sayi = Convert.ToInt32(Console.ReadLine());

var sonuc = (sayi > 0) ? "Sayı pozitif":"sayı negativ";

Console.WriteLine(sonuc);

Console.Write("Sayı: ");
var sayi = Convert.ToInt32(Console.ReadLine());

var sonuc = (sayi % 2 == 0) ? "Sayı çifttir":"sayı tektir";

Console.WriteLine(sonuc);

var a = true;
var b = true;
var c = false;
var d = false;

var sonuc = (a && b);
var sonuc_1 = (c && d);
var sonuc_2 = (a && c);
var sonuc_3 = (a || b);
var sonuc_4 = (a || c);
var sonuc_5 = !a;

Console.WriteLine(sonuc);
Console.WriteLine(sonuc_1);
Console.WriteLine(sonuc_2);
Console.WriteLine(sonuc_3);
Console.WriteLine(sonuc_4);
Console.WriteLine(sonuc_5);



var yas = 17;
bool izin = false;
bool yas_kontrol = (yas >= 18);
bool veli_kontrol = (izin);
var sonuc = (yas_kontrol || izin) ? "çalışabilir":"Çalışamaz";

Console.WriteLine(sonuc);


int not = 40;

bool kosul1 = (not >= 50);
bool kosul2 = (not <= 100);

var sonuc = (not >= 50 && not <= 100) ? "geçtiniz" : "Kaldınız";

Console.WriteLine(sonuc);

string[] takimlar = {"beşiktaş", "fener", "galatasaray", "trabzonspor"};
var rnd = new Random();

int sayi = rnd.Next(0,4);

Console.WriteLine(sayi);
Console.WriteLine(takimlar[sayi]);

string username = "yusufbilen";
string pasword = "12345";

// var islogin = (username == "yusufbilen" && pasword == "1345");
if (username == "yusufbilen"){
    if (pasword == "12345"){
    Console.WriteLine("Merhaba BTK akademi");
    } else {
        Console.WriteLine("parola bilgileri yanlış");
    }
}

else {
    Console.WriteLine("Username yanlış girilmiştir");
}

string isim = "yusuf bilen";
string sifre = "bilen45";

if (isim != "yusuf bilen") {
    Console.WriteLine("isim yanlış");
} else if(sifre != "bilen45"){
    Console.WriteLine("parola yanlış");
}
else {
    Console.WriteLine("Merhaba Yusuf:)");
}

using System.Data;

int x = 10;
int y = 10;

if(x > y) {
    Console.WriteLine("x değeri y değerinden büyüktür");
} else if (x == y){
    Console.WriteLine("x değeri y değerine eşittir");
}
else {
    Console.WriteLine("x değeri y den küçüktür");
}



Console.WriteLine("Toplama için:    +");
Console.WriteLine("Çıkarma için:    -");
Console.WriteLine("Çarpma için:     *");
Console.WriteLine("Bölme için:      /");


Console.Write("1.Sayı: ");
var sayi1 = Convert.ToInt32(Console.ReadLine());

Console.Write("2.Sayı: ");
var sayi2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("seçiminiz: ");
var secim = Console.ReadLine();

double sonuc = 0;
bool ok = true
;if(secim == "+") {
    sonuc = sayi1 + sayi2;
}
else if(secim == "-") {
    sonuc = sayi1 - sayi2;
}
else if(secim == "/") {
    sonuc = sayi1 / sayi2;
}
else if(secim == "*") {
    sonuc = sayi1 * sayi2;
}
else{
    ok = false;
    Console.WriteLine("Yanlış seçim:)");
}
if(ok) {
Console.WriteLine($"işlem sonucu: {sayi1} {secim} {sayi2} = {sonuc}");

}


Console.Write("1.Yazılı: ");
int not_1 = Convert.ToInt32(Console.ReadLine());

Console.Write("2.Yazılı: ");
int not_2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Sözlü: ");
int sozlu = Convert.ToInt32(Console.ReadLine());

var ortalama = (not_1 + not_2 + sozlu) / 3;
int not = 0;
if(ortalama>=0 && ortalama<25) {
    not = 0;
}
else if(ortalama>=25  && ortalama <45) {
    not = 1;
}
else if(ortalama>=45  && ortalama <55) {
    not = 2;
}
else if(ortalama>=55  && ortalama <70) {
    not = 3;
}
else if(ortalama>=70  && ortalama <85) {
    not = 4;
}
else if(ortalama>=85  && ortalama <=100) {
    not = 5;
}
else {
    Console.WriteLine("Yanlış bilgiler girilmiştir:)");
}
Console.WriteLine($"not ortalamanız: {ortalama} ve notunuz: {not}");

Console.Write("a: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("b: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.Write("c: ");
int c = Convert.ToInt32(Console.ReadLine());

int enbuyuk = 0;

if(a > b && a > c) {
    enbuyuk = a;
}
else if(b > a && b > c){
    enbuyuk = b;
}
else {
    enbuyuk = c;
}
Console.WriteLine(" en büyük değer: " + enbuyuk);

int gun = (int)DateTime.Now.DayOfWeek;
switch(gun) {
    case 0:
    Console.WriteLine("pazar");
        break;
    case 1:
    Console.WriteLine("pazartesi");
        break;
    case 2:
    Console.WriteLine("salı");
        break;
    case 3:
    Console.WriteLine("çarşamba");
        break;
    case 4:
    Console.WriteLine("perşembe");
        break;
    case 5:
    Console.WriteLine("cuma");
        break;
    case 6:
    Console.WriteLine("cumartesi");
        break;

    default:
        Console.WriteLine("hatalı gün girişi:)");
        break;
}

int ay = 4;

switch(ay){
    case 12:
    case 1:
    case 2:
    Console.WriteLine("Kış");
        break;
    case 3:
    case 4:
    case 5:
    Console.WriteLine("İlk bahar");
        break;
    case 6:
    case 7:
    case 8:
    Console.WriteLine("yaz");
        break;
    case 9:
    case 10:
    case 11:
    Console.WriteLine("Son bahar");
        break;
}

int sayi = 10;

var sonuc = (sayi % 2 == 0) ? "sayı çift":"sayı tek";

Console.WriteLine(sonuc);


int sayi = -11;

var sonuc = (sayi % 2 == 0) ? 
                (sayi > 0) ? "sayı çift ve pozitif":"sayı çift ve negatif ":
                (sayi > 0) ? "sayi tek ve pozitif":"sayı tek ve negatif ";

Console.WriteLine(sonuc);



for(var i = 1; i <=100; i++) {
    Console.WriteLine(i);
}


var toplam = 0;
for (var i =1; i<=100; i++) {
    toplam += i;
    Console.WriteLine(toplam);
}

Console.Write("baslangı: ");
var baslangic = Convert.ToInt32(Console.ReadLine());

Console.Write("bitiş: ");
var bitis = Convert.ToInt32(Console.ReadLine());

Console.Write("bartış: ");
var artis = Convert.ToInt32(Console.ReadLine());

var toplam = 0;

for(var i = baslangic; i<bitis; i=i+artis) {
    toplam += i;
    Console.WriteLine(toplam);
}


string[] isimler = {"ali","ahmet","can","veli","fuat","ekrem",};
for(var i = 0; i<5; i++) {
    Console.WriteLine(isimler[i]);

}
// Console.WriteLine(isimler[0]);
// Console.WriteLine(isimler[1]);
// Console.WriteLine(isimler[2]);

int[] sayilar = {1,2,3,4,5,6,7,8,12,24,56};

for(var i = 0; i<sayilar.Length; i++) {
    if(sayilar[i] % 3 == 0) {
    Console.WriteLine(sayilar[i]);

    }
}
var i = 0;
while (i<10) {
    Console.WriteLine(i);
    i++;

}

string[] isimler = {"ali","ahmet","can","veli","fuat","ekrem",};

var i = 0;

while(i<isimler.Length) {
    Console.WriteLine(isimler[i]);
    i++;
}

using System.Collections;

var sweci = "e";
var sayac = 1;
var toplam = 0;
while(sweci == "e") {
    Console.WriteLine($"{sayac}. sayı: ");
    toplam += Convert.ToInt32(Console.ReadLine());

    Console.Write("devam etmek istiyorsanız? (e/h)");
    sweci = Console.ReadLine();
    sayac++;
}
Console.WriteLine($"{sayac - 1} adet sayının toplamı: {toplam}");

string isim = "yusuf bilen";
for(var i=0; i<isim.Length; i++) {
    if(isim[i] == 'i')
        continue;

    Console.WriteLine(isim[i]);
}

string isim = "yusuf bilen";
for(var i=0; i<isim.Length; i++) {
    if(isim[i] == 'i')
        break;

    Console.WriteLine(isim[i]);
}

int x = 0;

while(x<5) {
    x++;
    if(x == 3)
        continue;
    Console.WriteLine(x);

}

int x = 0;

while(x<5) {

    if(x == 3)
        continue;
    Console.WriteLine(x);
    x++;
}


var rnd = new Random();
int tutulan = rnd.Next(1, 100);
int hak = 3;

while(hak > 0) {
    Console.Write("Sayı: ");
    int sayi = Convert.ToInt32(Console.ReadLine());
    hak--;
    if(sayi == tutulan) {
        Console.WriteLine("Tebrikler sayıyı doğru bildiniz:)");

    }
    else {
        if(hak  == 0) {
            Console.WriteLine("Oyun Bitmiştir:(");
            break;
        }
        if(tutulan > sayi) {
            Console.WriteLine("yukarı:(");
        }
        else {
            Console.WriteLine("aşşağı:(");

        }
    }
}

int i = 1;

do {
    Console.WriteLine(i);
    i++;
} while(false);


Console.Write("adet: ");
int adet = Convert.ToInt32(Console.ReadLine());

string[] urunler = new string[adet];
 int i = 0;

 do {
    Console.Write("ürün adı: ");
    urunler[i] = Console.ReadLine() ?? "";

    i++;
 } while(adet !=i);
 Console.WriteLine("ürünler listeleniyor...");

 for(var a = 0; a < urunler.Length; a++) {
    Console.WriteLine(urunler[a]);
 }

string ad = "ahmet";

for(var i = 0; i < ad.Length; i++) {
    Console.WriteLine(ad[i]);
}

foreach(var harf in ad) {
    Console.WriteLine(harf);
}

int[] sayilar = {1,2,3,4,5,6,7,};
foreach(var a in sayilar) {
    if(a == 4){
        continue;
    }
    Console.WriteLine(a);
}



// dosya okumalarıı:)

StreamReader sr = File.OpenText("deneme.txt");

var s = "";
while((s = sr.ReadLine()) != null) {
    Console.WriteLine(s);
}


// string sonuc = File.ReadAllText("deneme.txt");
string[] sonuc = File.ReadAllLines("deneme.txt");

Console.WriteLine(sonuc[1]);


using(StreamWriter sw = File.CreateText("deneme.txt")) {
    sw.WriteLine("merhaba");
    sw.WriteLine("yusuf");
    sw.WriteLine("bilen");
}

using(StreamWriter sw = File.AppendText("deneme.txt")) {
    sw.WriteLine("devam");
    sw.WriteLine("ediyoruz");
    sw.WriteLine(":)");
}
StreamReader sr = File.OpenText("deneme.txt");

var s = "";
while((s = sr.ReadLine()) != null) {
    Console.WriteLine(s);
}


sw.Close();

// Dosyalara erişim kodlamaları


File.WriteAllText("deneme.txt", "merhaba"); // yeni bir dosya da eklenir
File.AppendAllText("deneme.txt", "merhaba");   // hiç bir şey silmeden yanına ekler
using(StreamReader sr = File.OpenText("deneme.txt")) {
    var s = "";
    while((s = sr.ReadLine()) != null) {
        Console.WriteLine(s);
    }
}

Directory.CreateDirectory("temp");
Directory.CreateDirectory("temp/deneme");
// Directory.CreateDirectory("temp/deneme2");
if(Directory.Exists("temp/deneme2")) {
    Directory.Delete("temp/deneme2");
}
else {
    Console.WriteLine("silmek istediğiniz klasör yok");
}

// Directory.Move // bu kod ile klasör taşıma gerçekleşir

string path = "konum";
string path = Directory.GetCurrentDirectory() + "/temp";
Console.WriteLine(path);
Directory.CreateDirectory(path);

using System.IO.Enumeration;

string rootPath = Directory.GetCurrentDirectory();

string[] dirs =  Directory.GetDirectories(rootPath, "*", SearchOption.AllDirectories);

foreach(var dir in dirs) {
    Console.WriteLine(dir);
}

string[] files = Directory.GetFiles(rootPath, "*.txt", SearchOption.AllDirectories);

foreach(var file in files) {
    Console.WriteLine(file);
    Console.WriteLine(Path.GetExtension(file));
    Console.WriteLine(Path.GetFileNameWithoutExtension(file));
    Console.WriteLine(Path.GetFileName(file));

    var info = new FileInfo(file);

    Console.WriteLine($"{Path.GetFileName(file)}: {info.Length}");
}

// Sınıflar:)

namespace Consoleapp {
    class Program {
        static void Main(string[] agrs) {
            Console.WriteLine("Merhaba BTK");
            Ogrenci ogr1 = new Ogrenci();

            ogr1.OgrenciNo = "336";
            ogr1.AdSoyad = "Yusuf Bilen";
            ogr1.Sube = "6/A";

            Ogrenci ogr2 = new Ogrenci();

            ogr2.OgrenciNo = "330";
            ogr2.AdSoyad = "Ahmet Alan";
            ogr2.Sube = "7/A";

            Ogrenci ogr3 = new Ogrenci();

            ogr3.OgrenciNo = "339";
            ogr3.AdSoyad = "Eren Yılmaz";
            ogr3.Sube = "5/A";


            Ogrenci[] ogrenciler = new Ogrenci[3];

            ogrenciler[0] = ogr1;
            ogrenciler[1] = ogr2;
            ogrenciler[2] = ogr3;

            foreach(var ogr in ogrenciler) {
                Console.WriteLine($"{ogr.OgrenciNo} numaralı öğrencinin adı {ogr.AdSoyad} ve şubesi {ogr.Sube}");

            }
            Console.WriteLine($"{ogr1.OgrenciNo} numaralı öğrencinin adı {ogr1.AdSoyad} ve şubesi {ogr1.Sube}");
            Console.WriteLine($"{ogr2.OgrenciNo} numaralı öğrencinin adı {ogr2.AdSoyad} ve şubesi {ogr2.Sube}");
            Console.WriteLine($"{ogr3.OgrenciNo} numaralı öğrencinin adı {ogr3.AdSoyad} ve şubesi {ogr3.Sube}");

        }
    }
    class Ogrenci {
            public string OgrenciNo { get; set; }
            
            public string AdSoyad { get; set; }

            public string Sube { get; set; }

    }
 }

namespace Consoleapp {
    class Program {
        static void Main(string[] agrs) {
            Ogrenci agr1 = new Ogrenci() {OgrenciNo = "336", AdSoyad = "Yusuf Bilen", Sube = "6/A"};
            Ogrenci agr2 = new Ogrenci() {OgrenciNo = "330", AdSoyad = "Ahmet Alan", Sube = "7/A"};
            Ogrenci agr3 = new Ogrenci() {OgrenciNo = "339", AdSoyad = "Eren Yılmaz", Sube = "5/A"};

            Ogrenci[] ogrenciler = new Ogrenci[3] {agr1, agr2, agr3};


            foreach(var ogr in ogrenciler) {
                Console.WriteLine(ogr.BilgileriYaz());

            }
        }
    }
    class Ogrenci {
            public string OgrenciNo { get; set; }
            
            public string AdSoyad { get; set; }

            public string Sube { get; set; }
            
            public void BilgileriYaz() {
                return $"{this.OgrenciNo} numaralı öğrencinin adı {this.AdSoyad} ve şubesi {this.Sube}";

            }
    }
 }

using System;

namespace ConsoleApp {

    class Program {

        static void Main(string[] args) 
        {
            var soru1 = new Soru() { 
                SoruMetni = "Hangisi proframlama dili değildir ?",
                Secenekler = new string[4] {"Python", "C#", "Java", "HTML"},
                Cevap = "HTML"
                };
            
            var soru2 = new Soru() {
                SoruMetni = "Hangisi en popüler programlama dilidir",
                Secenekler = new string[4] {"Python", "C#", "Java", "HTML"},
                Cevap = "C#"
            };
            var soru3 = new Soru() {
                SoruMetni = "Hangisi en popüler web platformüdür",
                Secenekler = new string[4] {"Django", "Asp.net", "Spring", "Python"},
                Cevap = "Python"
            };

            var sorular = new Soru[] { soru1, soru2, soru3};
            foreach (var soru in sorular)
            {
                Console.WriteLine(soru.SoruMetni);
                foreach(var secenek in soru.Secenekler) {
                    Console.WriteLine(secenek);
                }
                // Kullanıcıdan cevap
                Console.Write("Cevabınız: ");
                var cevap = Console.ReadLine();

               if(soru.cevapKontrol(cevap)) {
                Console.WriteLine("Doğru cevap verdiniz:)");
               }else {
                Console.WriteLine("Maalesef cevap yanlış:(");               }
            }
        }

    }

    // Proparty
    class Soru {
         public string SoruMetni { get; set; }
         public string[] Secenekler { get; set; }
         public string Cevap { get; set; }
        // Methods
        public bool cevapKontrol(string cevap) {
           return this.Cevap.ToLower() == cevap.ToLower();
        }
    }
}


using System;

namespace ConsoleApp {

    class Program {

        static void Main(string[] args) 
        {
            var soru1 = new Soru() { 
                SoruMetni = "Hangisi proframlama dili değildir ?",
                Secenekler = new string[4] {"Python", "C#", "Java", "HTML"},
                Cevap = "HTML"
                };
            
            var soru2 = new Soru() {
                SoruMetni = "Hangisi en popüler programlama dilidir",
                Secenekler = new string[4] {"Python", "C#", "Java", "HTML"},
                Cevap = "C#"
            };
            var soru3 = new Soru() {
                SoruMetni = "Hangisi en popüler web platformüdür",
                Secenekler = new string[4] {"Django", "Asp.net", "Spring", "Python"},
                Cevap = "Python"
            };
            var soru4 = new Soru();
            Console.WriteLine(soru4.Soruİd);

    }

    // Proparty
    class Soru {

         public Soru()
         {
            Console.WriteLine("constructer 1 ");
            this.Soruİd = (new Random()).Next(11111,99999);
         }
         public Soru(int soruİd)
         {
            Console.WriteLine("constructer 2 ");
            
            this.Soruİd = soruİd;
         }
         public int Soruİd { get; set; }
         public string SoruMetni { get; set; }
         public string[] Secenekler { get; set; }
         public string Cevap { get; set; }
        // Methods
        public bool cevapKontrol(string cevap) {
           return this.Cevap.ToLower() == cevap.ToLower();
        }
    }
}
}

// array_list

using System;
using System.Collections;

namespace ConsoleApp {

    class Program {

        static void Main(string[] args) {
            // Array List
            ArrayList liste = new ArrayList();
            liste.Add(10);
            liste.Add("10");
            liste.Add("Ali");
            liste.Add(null);
            liste.Add(true);

            var liste2 = new ArrayList() {
                5,
                "ahmet",
                false,
                4.5,
                null
            };

            int[] sayilar = {1,10,5};
            liste.AddRange(sayilar);   

            var eleman = liste[6]; 
            Console.WriteLine(eleman); 
            }
    }
}

