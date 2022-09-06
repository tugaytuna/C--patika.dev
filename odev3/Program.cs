
// Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). 
//Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. 
//Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.

Console.WriteLine("");
Console.WriteLine("Birinci Örnek");
Console.WriteLine("");

Console.WriteLine("Pozitif bir sayı giriniz:");
string sayi1 = Console.ReadLine();

List<int> sayilar = new List<int>();

for (int i = 0; i < int.Parse(sayi1);i++)
{
    Console.WriteLine("Yeni bir sayı giriniz:");
    string temp_sayi = Console.ReadLine();
    if (int.Parse(temp_sayi) % 2 == 0)
    {
        sayilar.Add(int.Parse(temp_sayi));
    }

}

Console.WriteLine("Eklediğiniz çift rakamlar:");

foreach(var kk in sayilar)
{
    Console.WriteLine(kk);
}

// Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). 
//Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. 
//Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.
Console.WriteLine("");
Console.WriteLine("İkinci Örnek");
Console.WriteLine("");

Console.WriteLine("Pozitif bir sayı giriniz:");
string n_sayi = Console.ReadLine();
Console.WriteLine("Pozitif bir sayı daha giriniz:");
string m_sayi = Console.ReadLine();

List<int> n_sayiList = new List<int>();

for (int i = 0; i < int.Parse(n_sayi);i++)
{
    Console.WriteLine("Yeni bir sayı giriniz:");
    string temp_sayi = Console.ReadLine();
    if (int.Parse(temp_sayi) % int.Parse(m_sayi) == 0)
    {
        n_sayiList.Add(int.Parse(temp_sayi));
    }

}

Console.WriteLine("Eklediğiniz bölünebilen sayılar:");

foreach(var kk in n_sayiList)
{
    Console.WriteLine(kk);
}



// Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). 
//Sonrasında kullanıcıdan n adet kelime girmesi isteyin. 
//Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.

Console.WriteLine("");
Console.WriteLine("Üçüncü Örnek");
Console.WriteLine("");

Console.WriteLine("Pozitif bir sayı giriniz:");
string yeni_sayi = Console.ReadLine();

List<int> yeni_List = new List<int>();

for (int i = 0; i < int.Parse(yeni_sayi);i++)
{
    Console.WriteLine("Yeni bir sayı giriniz:");
    string temp_sayi = Console.ReadLine();
    yeni_List.Add(int.Parse(temp_sayi));
}

Console.WriteLine("Eklediğiniz tüm sayılar ters şekilde:");

List<int> RE_yeni_List = Enumerable.Reverse(yeni_List).ToList();

foreach(var kk in RE_yeni_List)
{
    Console.WriteLine(kk);
}



// Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. 
//Cümledeki toplam kelime ve harf sayısını console'a yazdırın.

Console.WriteLine("");
Console.WriteLine("Üçüncü Örnek");
Console.WriteLine("");

Console.WriteLine("Bir cümle giriniz:");
string cumle = Console.ReadLine();
int kelime_sayisi = 0;
int harf_sayisi = 0;

for (int i = 0; i < cumle.Length; i++)
{
    if (cumle[i].ToString() == " ")
    {
        kelime_sayisi++;
    }
}

harf_sayisi = cumle.Length;


Console.WriteLine("Eklediğiniz cümledeki kelime sayısı: {0}",(kelime_sayisi+1));
Console.WriteLine("Eklediğiniz cümledeki harf sayısı: {0}",harf_sayisi);



