// Soru - 1: Klavyeden girilen 20 adet pozitif sayının asal ve asal olmayan olarak 2 ayrı listeye atın. (ArrayList sınıfını kullanara yazınız.)

// Negatif ve numeric olmayan girişleri engelleyin.
// Her bir dizinin elemanlarını büyükten küçüğe olacak şekilde ekrana yazdırın.
// Her iki dizinin eleman sayısını ve ortalamasını ekrana yazdırın.

Console.WriteLine("20 Adet Rakam Giriniz:");

List<int> sayilar = new List<int>();
List<int> asal_sayilar = new List<int>();
List<int> asal_olmayan_sayilar = new List<int>();
int eleman = 0;
int asal = 1;

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

for (int kk = 0; kk< 20; kk++)
{
    asal = 1;
    eleman = sayilar[kk] / 2;
    for(int m = 2; m <= eleman; m++)    
    {    
        if(sayilar[kk] % m == 0)    
        {    
            asal_olmayan_sayilar.Add(sayilar[kk]);
            asal = 0;
            break;
        }  
    }  
    if (asal == 1)
    {
            asal_sayilar.Add(sayilar[kk]);
    }
} 
   

// order to numbers
asal_sayilar.Sort();
asal_sayilar.Reverse();
asal_olmayan_sayilar.Sort();
asal_olmayan_sayilar.Reverse();


Console.WriteLine("Asal sayılar listeleniyor...");
foreach (var u in asal_sayilar)
{
    Console.WriteLine(u.ToString());
}


Console.WriteLine("Asal olmayan sayılar listeleniyor...");
foreach (var u in asal_olmayan_sayilar)
{
    Console.WriteLine(u.ToString());
}

Console.WriteLine("");
Console.WriteLine("Asal Sayılar {0} adet ve ortalaması {1}.",asal_sayilar.Count.ToString(),asal_sayilar.Average().ToString());
Console.WriteLine("Asal Olmayan Sayılar {0} adet ve ortalaması {1}.",asal_olmayan_sayilar.Count.ToString(),asal_olmayan_sayilar.Average().ToString());