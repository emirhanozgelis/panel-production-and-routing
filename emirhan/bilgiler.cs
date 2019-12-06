using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace emirhan
{
    class bilgiler
    {
        private blok suankiSekil;
        private blok bosAlan;

        private int genislik;
        private int yukseklik;
        private int x;
        private int y;

        public bilgiler(int genislik, int yukseklik)
        {
            this.genislik = genislik;
            this.yukseklik = yukseklik;

            bosAlan = new blok();
        }
        public void pozisyonAyarla(int x, int y)
        {
            this.x = x;
            this.y = y;

        }
        public void CizimYap()
        {
            bosAlan.boyutAyarla(genislik, yukseklik);
            bosAlan.renkAyarla(ConsoleColor.Green);
            bosAlan.pozisyonAyarla(x, y);
            bosAlan.CizimYap();
        }
        public void BilgiCiz()
        {
            //Bilgi ekranı
            //Her öteleme sonrası önceki bilgiler silinip yeni bilgiler yazdırılır
            Console.ResetColor();
            Console.SetCursorPosition(60, 24);
            Console.Write("                     ");
            Console.SetCursorPosition(60, 24);
            Console.Write("x................: ");
            Console.WriteLine(suankiSekil.x);
            Console.SetCursorPosition(60, 26);
            Console.Write("                     ");
            Console.SetCursorPosition(60, 26);
            Console.Write("y................: ");
            Console.WriteLine(suankiSekil.y);
            Console.SetCursorPosition(60, 28);
            Console.Write("                     ");
            Console.SetCursorPosition(60, 28);
            Console.Write("Genislik.........: ");
            Console.WriteLine(suankiSekil.genislik);
            Console.SetCursorPosition(60, 30);
            Console.Write("                     ");
            Console.SetCursorPosition(60, 30);
            Console.Write("Yukseklik........: ");
            Console.WriteLine(suankiSekil.yukseklik);
            Console.SetCursorPosition(60, 32);
            Console.Write("                                        ");
            Console.SetCursorPosition(60, 32);
            Console.Write("Renk.............: ");
            Console.WriteLine(suankiSekil.renk);

        }
        public void SekilAta(blok sekil)
        {
            suankiSekil = sekil;
        }
    }
}
