//Soru - 3: Klavyeden girilen cümle içerisindeki sesli harfleri bir dizi içerisinde saklayan ve dizinin elemanlarını sıralayan programı yazınız.

Console.WriteLine("Lütfen bir cümle giriniz:");

string cumle = Console.ReadLine();
List<char> cumle_list = new List<char>();
List<char> cumle_sesli = new List<char>();

for (int i = 0; i < cumle.Length; i++)
{
    if (cumle[i] == 'a' || cumle[i] == 'e' || cumle[i] == 'i' || cumle[i] == 'ı' || cumle[i] == 'u' || cumle[i] == 'ü' || cumle[i] == 'o' || cumle[i] == 'ö')
    {
         cumle_sesli.Add(cumle[i]);
    }
   
}

Console.WriteLine("{0} adet sesli harf bulunmaktadır.",cumle_sesli.Count.ToString());
Console.WriteLine("Sesli harflar listesi...");

cumle_sesli.Sort();

foreach (var k in cumle_sesli)
{
    Console.WriteLine(k.ToString());
}
