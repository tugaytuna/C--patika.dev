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
            Kisiler Kisiler = new Kisiler();
            string _isim;
            string _soyisim;
            string _telno;
            string arama_bilgisi;

            int secenek_int = 0;
            Kisiler kk = new Kisiler();
            // başlangıç değeri atanması
            List<Kisiler> kisiList = new List<Kisiler>()
            {
                new Kisiler{isim = "tugay", soyisim = "tuna", telno="0542222222"},
                new Kisiler{isim = "tolga", soyisim = "tuna", telno="0542542522"},
                new Kisiler{isim = "tugay", soyisim = "tolga", telno="0542287422"},
                new Kisiler{isim = "ahmet", soyisim = "mehmet", telno="0552487222"},
                new Kisiler{isim = "tanju", soyisim = "arda", telno="0542784522"}
            };

            Console.WriteLine("Telefon Rehberi Uygulamasına Hoş Geldiniz!");
            WelcomeScreen();


            void savePerson()
            {
                Console.WriteLine("İsim:");
                _isim = Console.ReadLine();
                Console.WriteLine("Soyisim:");
                _soyisim = Console.ReadLine();
                Console.WriteLine("TelNo:");
                _telno = Console.ReadLine();

                Kisiler yenikisi = new Kisiler();
                yenikisi.isim = _isim;
                yenikisi.soyisim = _soyisim;
                yenikisi.telno = _telno;

                kisiList.Add(yenikisi);

                Console.WriteLine("Kişi kaydı tamamlanmıştır.");
                WelcomeScreen();
            }
            void deletePerson()
            {
                justSearch();

                Console.WriteLine("Bu kaydı silmek istediğine emin misin? (y/n) {0} {1}",kk.isim,kk.soyisim);
                if ("y" == Console.ReadLine())
                {
                    // delete işlemi
                    kisiList.Remove(kk);
                }
                else if ("n" ==  Console.ReadLine())
                {
                    Console.WriteLine("Silmne işlemi iptal edildi.");
                    Console.WriteLine("Anasayfadan devam edebilirsiniz...");
                }


                WelcomeScreen();
            }
            void updatePerson()
            {
                justSearch();

                
                Console.WriteLine("Yeni telefon numarasını giriniz: ");
                //update the list
                kk.telno = Console.ReadLine();

                Console.WriteLine("Güncelleme tamamlanmıştır.");
                


                WelcomeScreen();
            }
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
            {
                justSearch();
                WelcomeScreen();

                //person = PhoneBookDatabase.PhoneList.FirstOrDefault(x => x.FirstName == input2 || x.LastName == input2);
            }

            void showPerson(Kisiler n)
            {
                Console.WriteLine("*******************");
                Console.WriteLine("Kayıt: İsim: {0}, Soyisim: {1}, Telno: {2}", n.isim, n.soyisim, n.telno);
                Console.WriteLine("*******************");
            }
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


            }

            void justSearch()
            {
                Console.WriteLine("**********************************");
                Console.WriteLine("Lütfen aradığınız kişinin adını ya da soyadını giriniz:");

                arama_bilgisi = Console.ReadLine();

                
                kk = kisiList.FirstOrDefault(x => x.isim == arama_bilgisi || x.soyisim == arama_bilgisi);

                if (kk == null)
                {
                    Console.WriteLine("Kullanıcı bulunamadı! Tekrar deneyiniz!");
                }
                else
                {
                    showPerson(kk);
                }
            }

        }
    }
}
