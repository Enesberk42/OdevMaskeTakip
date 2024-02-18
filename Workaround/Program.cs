using Business.Concrete;
using Entities.Concrete;

SelamVer(isim:"Enes");

//Diziler / Arrays

//diziler ogrenci
string[] ogrenciler = new string[3];
ogrenciler[0] = "Birinci";
ogrenciler[1] = "İkinci";
ogrenciler[2] = "Üçüncü";

for (int i = 0; i < ogrenciler.Length; i++)
{
    Console.WriteLine(ogrenciler[i]);
}
//diziler sehirler
string[] sehirler1 = new[] {"İstanbul", "Ankara","İzmir" };
string[] sehirler2 = new[] {"Konya", "Antalya", "Trabzon" };

sehirler2 = sehirler1;
sehirler1[0] = "Adana";
Console.WriteLine(sehirler2[0]);

foreach (string sehir in sehirler1) 
{
    Console.WriteLine(sehir);
}

List<string> yeniSehirler = new List<string> {"Ankara 1" , "İstanbul 1" , " İzmir 1"};
yeniSehirler.Add(item:"Adana 1");
foreach (var sehir in yeniSehirler)
{
    Console.WriteLine(sehir);
}


//kisiler
Person person1 = new Person();
person1.FirstName = "Enes Berk";
person1.LastName = "Ertan";
person1.DateOfBirhYear = 1996;
person1.NationalIdentity = 12345678910;

Person person2 = new Person();
person2.FirstName = "Test2";

PttManager pttManager = new PttManager(new PersonManager());
pttManager.GiveMask(person1);

Console.ReadLine();

//kisiler2
static void SelamVer(string isim="noname") 
{
    Console.WriteLine("Merhaba " + isim);
}

//int
int sonuc = Topla(3, 5);

static int Topla(int sayi1, int sayi2) 
{
    int sonuc = sayi1 + sayi2;
    Console.WriteLine("Toplam: "+sonuc);
    return sonuc;
}