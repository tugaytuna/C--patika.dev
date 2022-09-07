// Soru - 2: Klavyeden girilen 20 adet sayının en büyük 3 tanesi ve en küçük 3 tanesi bulan, her iki grubun kendi içerisinde ortalamalarını alan ve
// bu ortalamaları ve ortalama toplamlarını console'a yazdıran programı yazınız. (Array sınıfını kullanarak yazınız.)

Console.WriteLine("20 Adet Rakam Giriniz:");

List<int> sayilar = new List<int>();
List<int> enbuyuk_sayilar = new List<int>();
List<int> enkucuk_sayilar = new List<int>();

int enbuyuk_toplam = 0;
int enkucuk_toplam = 0;


for (int i = 1;i<=20; i++)
{
    try
    {
        sayilar.Add(int.Parse(Console.ReadLine()));
    }
    catch
    {
        Console.WriteLine("Uygun bir ifade giriniz.");
    }
    
}

sayilar.Sort();

for (int k = 0; k<3;k++)
{
    enkucuk_sayilar.Add(sayilar[k]);
}

sayilar.Reverse();

for (int j = 0; j<3;j++)
{
    enbuyuk_sayilar.Add(sayilar[j]);
}

Console.WriteLine("");

Console.WriteLine("En küçük 3 sayı:");
foreach (var i in enkucuk_sayilar)
{
    Console.WriteLine(i.ToString());
    enkucuk_toplam = enkucuk_toplam + i;
}

Console.WriteLine("En büyük 3 sayı:");
foreach (var i in enbuyuk_sayilar)
{
    Console.WriteLine(i.ToString());
    enbuyuk_toplam = enbuyuk_toplam + i;
}




Console.WriteLine("");
Console.WriteLine("En küçük 3 sayının ortalaması {0} ve ortalamaları toplamı {1}.",enkucuk_sayilar.Average().ToString(),enkucuk_toplam.ToString());

Console.WriteLine("En büyük 3 sayının ortalaması {0} ve ortalamaları toplamı {1}.",enbuyuk_sayilar.Average().ToString(),enbuyuk_toplam.ToString());