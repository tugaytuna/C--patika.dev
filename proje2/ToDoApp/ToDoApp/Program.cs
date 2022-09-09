using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp
{
    internal class Program
    {
        class card
        {
            //Baslık
            //Icerik
            //Atanan Kisi(Takım üyelerişnden biri olmalı)
            //Büyüklük(XS, S, M, L, XL)

            string baslik { get; set; }
            string icerik { get; set; }
            string atanan_kisi { get; set; }
            string buyukluk { get; set; }
        }

        static void Main(string[] args)
        {
            //Kart Ekle
            //Kart Güncelle
            //Kart Sil
            //Kart Taşı
            //Board Listeleme

            card kart = new card();

            Console.WriteLine("ToDoApp'e Hoş Geldiniz");


        }
    }
}
