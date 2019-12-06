using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace emirhan
{
    class blok
    {
        public int genislik, yukseklik , x,y;
        public ConsoleColor renk;

        public blok() { }

        public blok(int width, int height)
        {

            int renk = rastgele.SayiUret(1, 15);
            int genislik = rastgele.SayiUret(2, 20);
            int yukseklik = rastgele.SayiUret(2, 10);
            int x = rastgele.SayiUret(1, width - genislik);
            int y = rastgele.SayiUret(1, height - yukseklik);
            boyutAyarla(genislik, yukseklik);
            pozisyonAyarla(x, y);
            renkAyarla((ConsoleColor)renk);
        }
        public void CizimYap()
        {
            Console.ForegroundColor = renk;
            ustGenislikCiz();
            uzunlukCiz();
            altGenislikCiz();
        }
        public void uzunlukCiz()
        {
            string uzun = "";
            for (int i = y + 1; i < yukseklik + y; i++)
            {
                Console.SetCursorPosition(x, i);
                uzun = blokKenarlari.Dikey.ToString();
                for (int j = 0; j < genislik - 2; j++)
                {
                    uzun = uzun + " ";
                }
                uzun = uzun + blokKenarlari.Dikey.ToString();
                Console.WriteLine(uzun);
            }
        }
        public void ustGenislikCiz()
        {
            Console.SetCursorPosition(x, y);
            string ust = blokKenarlari.SolUstKose.ToString();
            for (int i = 0; i < genislik - 2; i++)
            {
                ust = ust + "═";
            }
            ust = ust + blokKenarlari.SagUstKose.ToString();
            Console.WriteLine(ust);
        }
        public void altGenislikCiz()
        {
            Console.SetCursorPosition(x, y + yukseklik);
            string alt = blokKenarlari.SolAltKose.ToString();
            for (int i = 0; i < genislik - 2; i++)
            {
                alt = alt + blokKenarlari.Duz.ToString();
            }
            alt = alt + blokKenarlari.SagAltKose.ToString();
            Console.WriteLine(alt);
        }
        public void pozisyonAyarla(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public void boyutAyarla(int genislik, int yukseklik)
        {
            this.genislik = genislik;
            this.yukseklik = yukseklik;
        }
        public void renkAyarla(ConsoleColor renk)
        {
            this.renk = renk;
        }

        public void sol()
        {
            for (int i = 0; i <= yukseklik; i++)
            {
                Console.SetCursorPosition(x, y + i);
                for (int j = 0; j < genislik; j++)
                {
                    Console.Write(" ");
                }
            }
            x = x - 1;
            CizimYap();
        }
        public void sag()
        {
            for (int i = 0; i <= yukseklik; i++)
            {
                Console.SetCursorPosition(x, y + i);
                for (int j = 0; j < genislik; j++)
                {
                    Console.Write(" ");
                }
            }
            x = x + 1;
            CizimYap();
        }
        public void yukari()
        {
            for (int i = 0; i <= yukseklik; i++)
            {
                Console.SetCursorPosition(x, y + i);
                for (int j = 0; j < genislik; j++)
                {
                    Console.Write(" ");
                }
            }
            y = y - 1;
            CizimYap();
        }
        public void asagi()
        {
            for (int i = 0; i < yukseklik; i++)
            {
                Console.SetCursorPosition(x, y + i);
                for (int j = 0; j < genislik; j++)
                {
                    Console.Write(" ");
                }
            }
            y = y + 1;
            CizimYap();
        }
    }
}
