using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace emirhan
{
    class anaKontrol
    {
        private int genislik, yukseklik,x,y, sekilAdet, maxSekilAdet;
        private blok bosAlan, suankiSekil;
        private blok[] sekiller;

        bilgiler bilgilerim;

        public anaKontrol(int genislik, int yukseklik)
        {

            this.genislik = genislik;
            this.yukseklik = yukseklik;
            sekilAdet = 0;
            maxSekilAdet = 100;
            sekiller = new blok[100];
            bosAlan = new blok();

            bosAlan.boyutAyarla(genislik, yukseklik);
            bosAlan.renkAyarla(ConsoleColor.Yellow);
            bosAlan.pozisyonAyarla(x, y);
            bosAlan.CizimYap();

            bilgilerim = new bilgiler(50, 19);
            bilgilerim.pozisyonAyarla(51, 21);
            bilgilerim.CizimYap();
        }
        public void pozisyonAyarla(int x, int y)
        {
            this.x = x;
            this.y = y;

        }
        public void CizimYap()
        {

            if (sekilAdet < maxSekilAdet)
            {
                blok dortgen = new blok(genislik, yukseklik);
                dortgen.CizimYap();

                suankiSekilAta(dortgen);

                bilgilerim.SekilAta(dortgen);
                bilgilerim.BilgiCiz();
            }
        }
        public void suankiSekilAta(blok yeniSekil)
        {
            this.suankiSekil = yeniSekil;
            sekiller[sekilAdet] = suankiSekil;
            sekilAdet++;
        }

        public void sol()
        {
            if (ustUsteMi() == false)
            {
                suankiSekil.x = suankiSekil.x - 1;
                if (ustUsteMi() == false)
                {
                    suankiSekil.x++;
                    suankiSekil.sol();
                    bilgilerim.BilgiCiz();
                }
                else
                {
                    suankiSekil.x++;
                }

            }
        }
        public void sag()
        {
            if (ustUsteMi() == false)
            {
                suankiSekil.x = suankiSekil.x + 1;
                if (ustUsteMi() == false)
                {
                    suankiSekil.x--;
                    suankiSekil.sag();
                    bilgilerim.BilgiCiz();
                }
                else
                {
                    suankiSekil.x--;
                }

            }
        }
        public void yukari()
        {
            if (ustUsteMi() == false)
            {
                suankiSekil.y = suankiSekil.y - 1;
                if (ustUsteMi() == false)
                {
                    suankiSekil.y++;
                    suankiSekil.yukari();
                    bilgilerim.BilgiCiz();
                }
                else
                {
                    suankiSekil.y++;
                }

            }
        }
        public void asagi()
        {
            if (ustUsteMi() == false)
            {
                suankiSekil.y = suankiSekil.y + 1;
                if (ustUsteMi() == false)
                {
                    suankiSekil.y--;
                    suankiSekil.asagi();
                    bilgilerim.BilgiCiz();
                }
                else
                {
                    suankiSekil.y--;
                }

            }
        }
        public bool ustUsteMi()
        {
            
            if (suankiSekil.y == y || suankiSekil.y + suankiSekil.yukseklik == y + yukseklik || suankiSekil.x == x || suankiSekil.x + suankiSekil.genislik == x + genislik )//tEMAS ETMEMELİ
            {
                return true;
            }
           
            else
            {
                foreach (var sekil in sekiller)
                {
                    
                    if (suankiSekil == sekil || sekil == null)
                    {
                        continue;
                    }
                    else
                    {
                        
                        for (int i = 0; i < suankiSekil.genislik; i++)
                        {
                            if (suankiSekil.x + i >= sekil.x && suankiSekil.x + i < sekil.x + sekil.genislik)
                            {
                               
                                if (suankiSekil.y <= sekil.y + sekil.yukseklik && suankiSekil.y >= sekil.y)
                                {
                                    return true;
                                }
                                
                                else if (suankiSekil.y + suankiSekil.yukseklik >= sekil.y && suankiSekil.y + suankiSekil.yukseklik <= sekil.y + sekil.yukseklik)
                                {
                                    return true;
                                }
                            }
                        }
                        
                        for (int i = 0; i < suankiSekil.yukseklik; i++)
                        {
                            if (suankiSekil.y + i >= sekil.y && suankiSekil.y + i < sekil.y + sekil.yukseklik)
                            {
                                
                                if (suankiSekil.x == sekil.x + sekil.genislik - 1)
                                {
                                    return true;
                                }
                                
                                else if (suankiSekil.x + suankiSekil.genislik - 1 == sekil.x)
                                {
                                    return true;
                                }
                            }
                        }
                    }
                }
                return false;
            }
        }
    }
}
