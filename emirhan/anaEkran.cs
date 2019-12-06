using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace emirhan
{
    class anaEkran
    {
        private int genislik, yukseklik , x , y;
        private blok bosAlan;

        public anaEkran(int genislik, int yukseklik) //Ekran oluşacaksa yükseklik genişliği olmalı
        {
            this.yukseklik = yukseklik;
            this.genislik = genislik;

            bosAlan = new blok(); //Çizilecek bir alan oluşturuluyor
        }
        public void CizimYap()
        {
            bosAlan.boyutAyarla(genislik, yukseklik);
            bosAlan.renkAyarla(ConsoleColor.Cyan);
            bosAlan.pozisyonAyarla(x, y);
            bosAlan.CizimYap();
        }
        public void KonumAyarla(int xKonum, int yKonum)
        {
            this.x = xKonum;
            this.y = yKonum;

        }
        public void MenuCizimiYap()
        {
            Console.ResetColor();
            Console.SetCursorPosition(60, 2);
            Console.WriteLine("KONTROL PANELI");
            Console.SetCursorPosition(60, 5);
            Console.WriteLine("Şekil Ekle   ( E )");
            Console.SetCursorPosition(60, 7);
            Console.WriteLine("SOLA ÖTELE   ( A )");
            Console.SetCursorPosition(60, 9);
            Console.WriteLine("SAĞA ÖTELE   ( D )");
            Console.SetCursorPosition(60, 11);
            Console.WriteLine("YUKARI ÖTELE ( W )");
            Console.SetCursorPosition(60, 13);
            Console.WriteLine("AŞAĞI ÖTELE  ( S )");
        }
    }
}
