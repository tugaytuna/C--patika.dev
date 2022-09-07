using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelefonRehberiApp
{
    internal class Program
    {
        public class Kisiler
        {
            public string isim { get; set; }
            public string soyisim { get; set; }
            public string telno { get; set; }
        }


        static void Main(string[] args)
        {
            Kisiler kisiler = new Kisiler();
            // başlangıç değeri atanması
            List<Kisiler> kisiList = new List<Kisiler>()
            {
                new Kisiler{isim = "tugay", soyisim = "tuna", telno="0542222222"},
                new Kisiler{isim = "tolga", soyisim = "tuna", telno="0542542522"},
                new Kisiler{isim = "tugay", soyisim = "tolga", telno="0542287422"},
                new Kisiler{isim = "ahmet", soyisim = "mehmet", telno="0552487222"},
                new Kisiler{isim = "tanju", soyisim = "arda", telno="0542784522"}
            };

            int secenek_int = 0;

            Console.WriteLine("Telefon Rehberi Uygulamasına Hoş Geldiniz!");

            WelcomeScreen();

           

            switch (secenek_int)
            {
                case 1:
                    savePerson();
                    break;
                case 2:
                    deletePerson();
                    break;
                case 3:
                    updatePerson();
                    break;
                case 4:
                    listPerson();
                    break;
                case 5:
                    searchPerson();
                    break;
                default:
                    Console.WriteLine("Uygun bir değer giriniz.");
                    break;
            }


            void savePerson()
            { 
            
            
            
            
            
            
            }

            void deletePerson()
            { }

            void updatePerson()
            { }

            void listPerson()
            {
                Console.WriteLine("Kişiler Listesi Sıralanıyor...");
                for (int i = 0; i < kisiList.Count; i++)
                {
                    Console.WriteLine("{0}. Kayıt: İsim: {1}, Soyisim: {2}, Telno: {3}", (i + 1), kisiList[i].isim, kisiList[i].soyisim, kisiList[i].telno);
                }
                Console.WriteLine();
                Console.WriteLine();
                WelcomeScreen();
            }

            void searchPerson()
            { }


            void WelcomeScreen()
            {
                Console.WriteLine("1- Telefon Numarası Kaydet");
                Console.WriteLine("2- Telefon Numarası Sil");
                Console.WriteLine("3- Telefon Numarası Güncelle");
                Console.WriteLine("4- Rehber Listeleme (A-Z, Z-A seçimli)");
                Console.WriteLine("5- Rehberde Arama");


                try
                {
                    string secenek = Console.ReadLine();
                    secenek_int = int.Parse(secenek);
                }
                catch
                {
                    Console.WriteLine("Lütfen uygun bir değer giriniz!");
                }
            }



        }
    }
}
