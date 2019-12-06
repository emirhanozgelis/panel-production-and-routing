using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace emirhan
{
    class Program
    {
        static anaKontrol kontrol;
        static anaEkran kp;
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            PanelCizimi();   
            int adet = 0;
            ConsoleKeyInfo cki = new ConsoleKeyInfo();
            do
            {
                //Tuş okuma
                cki = Console.ReadKey(true);
                if (cki.Key == ConsoleKey.E)
                {
                    //Dörtgeni oluşturma
                    kontrol.CizimYap();

                    adet++;
                    Console.ResetColor();
                }
                else if (cki.Key == ConsoleKey.W && adet > 0)
                {
                    kontrol.yukari();
                }
                else if (cki.Key == ConsoleKey.A && adet > 0)
                {
                    kontrol.sol();
                }
                else if (cki.Key == ConsoleKey.S && adet > 0)
                {
                    kontrol.asagi();
                }
                else if (cki.Key == ConsoleKey.D && adet > 0)
                {
                    kontrol.sag();
                }
            } while (true);
        }

        static void PanelCizimi()
        {

            kp = new anaEkran(50, 20);
            kp.KonumAyarla(51, 0);
            kp.CizimYap();
            kp.MenuCizimiYap();



            kontrol = new anaKontrol(50, 40);
            kontrol.pozisyonAyarla(0, 0);

        }
    }
    }

