using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int birimfiyatdana, birimfiyatkuzu, birimfiyattavuk, birimfiyatroka, birimfiyatbrokoli, birimfiyatmaydanoz, birimfiyatpeynir, birimfiyatzeytin, birimfiyatsucuk, birimfiyatcikolata, birimfiyatcips, birimfiyatseker, birimfiyatsut, birimfiyatyogurt, birimfiyatkaymak;

            birimfiyatdana = 150;
            birimfiyatkuzu = 200;
            birimfiyattavuk = 100;
            birimfiyatroka = 30;
            birimfiyatbrokoli = 25;
            birimfiyatmaydanoz = 20;
            birimfiyatpeynir = 100;
            birimfiyatzeytin = 100;
            birimfiyatsucuk = 150;
            birimfiyatcikolata = 30;
            birimfiyatcips = 25;
            birimfiyatseker = 20;
            birimfiyatsut = 50;
            birimfiyatyogurt = 60;
            birimfiyatkaymak = 100;

            Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "**********HOŞGELDİNİZ**********");
            Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Hangi reyonumuzdan ürün satın almak istersiniz?");
            Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Kasap(1) Manav(2) Şarküteri (3) Çerez(4) Süt Ürünleri (5)");

            int degisken = int.Parse(Console.ReadLine());
            if (degisken == 1)
                Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Kasap reyonuna hoşgeldiniz.Devam etmek için: (1)");

            else if (degisken == 2)
                Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Manav reyonuna hoşgeldiniz.Devam etmek için: (2)");

            else if (degisken == 3)
                Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Şarküteri reyonuna hoşgeldiniz.Devam etmek için: (3)");

            else if (degisken == 4)
                Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Çerez reyonuna hoşgeldiniz.Devam etmek için: (4)");

            else if (degisken == 5)
                Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Süt ürünleri reyonuna hoşgeldiniz. Devam etmek için (5)");

            string[] bolumListesi = { "kasap", "manav", "sarkuteri", "cerez", "sut" };
            int b;
            b = int.Parse(Console.ReadLine());
            if (b == 1)
                Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Hangi ürünü satın almak istersiniz? Dana(1),Kuzu Eti(2),Tavuk(3)");
            else if (b == 2)
                Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Hangi ürünü satın almak istersiniz? Roka(4), Brokoli(5), Maydanoz(6)");
            else if (b == 3)
                Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Hangi ürünü satın almak istersiniz? Peynir(7) , Zeytin(8), Sucuk(9)");
            else if (b == 4)
                Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Hangi ürünü satın almak istersiniz? Cikolata(10), Cips(11), Seker(12)");
            else if (b == 5)
                Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Hangi ürünü satın almak istersiniz? Sut(13) , Yogurt(14), Kaymak(15)");


            string[] kasap = { "dana", "kuzu", "tavuk", "roka", "brokoli", "maydanoz", "peynir", "zeytin", "sucuk", "cikolata", "cips", "seker", "sut", "yogurt", "kaymak" };
            int x = int.Parse(Console.ReadLine());
            if (x == 1)
                Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Dana sepete eklendi. KG'ı 150 TL'dir.Devam etmek için 'D' yazınız.");
            else if (x == 2)
                Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Kuzu sepete eklendi. KG'ı 200 TL'dir.Devam etmek için 'K'yazınız.");
            else if (x == 3)
                Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Tavuk sepete eklendi.KG'ı 100 TL'dir.Devam etmek için 'T'yazınız.");
            else if (x == 4)
                Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Roka sepete eklendi. Fiyatı 30 TL'dir.Devam etmek için 'R'yazınız.");
            else if (x == 5)
                Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Brokoli sepete eklendi. Fiyatı 25 TL'dir.Devam etmek için 'B'yazınız.");
            else if (x == 6)
                Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Maydanoz sepete eklendi. Fiyatı 20 TL'dir.Devam etmek için 'M'yazınız.");
            else if (x == 7)
                Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Peynir sepete eklendi. Fiyatı 100 TL'dir.Devam etmek için 'P'yazınız.");
            else if (x == 8)
                Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Zeytin sepete eklendi. Fiyatı 100 TL'dir. Devam etmek için 'Z'yazınız.");
            else if (x == 9)
                Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Sucuk sepete eklendi. Fiyatı 150 TL'dir. Devam etmek için 'S' yazınız.");
            else if (x == 10)
                Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Cikolata sepete eklendi. Fiyatı 30 TL'dir. Devam etmek için 'C' yazınız.");
            else if (x == 11)
                Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Cips sepete eklendi. Fiyatı 25 TL'dir. Devam etmek için 'Ç' yazınız.");
            else if (x == 12)
                Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Seker sepete eklendi. Fiyatı 20 TL'dir. Devam etmek için 'Ş' yazınız.");
            else if (x == 13)
                Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Sut sepete eklendi. Fiyatı 50 TL'dir. Devam etmek icin 'U' yazınız.");
            else if (x == 14)
                Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Yogurt sepete eklendi. Fiyatı 60 TL'dir. Devam etmek icin 'Y' yazınız.");
            else if (x == 15)
                Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Kaymak sepete eklendi. Fiyatı Fiyatı 100 TL'dir. Devam etmek için 'A'yazınız.");







            int[] urunAdet = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int fi;
            int q;
            string w;
            int tutar1, elemanSayisi;
            tutar1 = 0;
            elemanSayisi = 10;
            w = Console.ReadLine();


            if (w == "D")
            {
                Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Ürün kg/adet bilgisi giriniz.");
                q = int.Parse(Console.ReadLine());

                for (fi = 1; fi < elemanSayisi; fi++)
                    tutar1 = birimfiyatdana * q;

                if (q >= 1 && q <= 10)
                {
                    Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + $"{q} adet/kg ürünün fiyatı:" + birimfiyatdana * q + "TL");
                    Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Toplam Tutar:" + " " + tutar1 + "TL");
                }
            }

            else if (w == ("K"))
            {
                Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Ürün kg/adet bilgisi giriniz.");
                q = int.Parse(Console.ReadLine());
                for (fi = 1; fi < elemanSayisi; fi++)
                    tutar1 = birimfiyatkuzu * q;
                if (q >= 1 && q <= 10)
                {
                    Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + $"{q} adet/kg ürünün fiyatı:" + birimfiyatkuzu * q + "TL");
                    Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Toplam Tutar:" + " " + tutar1 + "TL");
                }

            }

            else if (w == ("T"))
            {
                Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Ürün kg/adet bilgisi giriniz.");
                q = int.Parse(Console.ReadLine());
                for (fi = 1; fi < elemanSayisi; fi++)
                    tutar1 = birimfiyattavuk * q;
                if (q >= 1 && q <= 10)

                {
                    Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + $"{q} adet/kg ürünün fiyatı:" + birimfiyattavuk * q + "TL");
                    Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Toplam Tutar:" + " " + tutar1 + "TL");
                }

            }

            else if (w == ("R"))
            {


                Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Ürün kg/adet bilgisi giriniz.");
                q = int.Parse(Console.ReadLine());
                for (fi = 1; fi < elemanSayisi; fi++)
                    tutar1 = birimfiyatroka * q;
                if (q >= 1 && q <= 10)
                {
                    Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + $"{q} adet/kg ürünün fiyatı:" + birimfiyatroka * q + "TL");
                    Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Toplam Tutar:" + " " + tutar1 + "TL");
                }

            }
            else if (w == ("B"))


            {
                Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Ürün kg/adet bilgisi giriniz.");
                q = int.Parse(Console.ReadLine());
                for (fi = 1; fi < elemanSayisi; fi++)
                    tutar1 = birimfiyatbrokoli * q;
                if (q >= 1 && q <= 10)
                {
                    Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + $"{q} adet/kg ürünün fiyatı:" + birimfiyatbrokoli * q + "TL");
                    Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Toplam Tutar:" + " " + tutar1 + "TL");
                }
            }
            else if (w == ("M"))


            {
                Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Ürün kg/adet bilgisi giriniz.");
                q = int.Parse(Console.ReadLine());
                for (fi = 1; fi < elemanSayisi; fi++)
                    tutar1 = birimfiyatmaydanoz * q;
                if (q >= 1 && q <= 10)
                {
                    Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + $"{q} adet/kg ürünün fiyatı:" + birimfiyatmaydanoz * q + "TL");
                    Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Toplam Tutar:" + " " + tutar1 + "TL");
                }
            }

            else if (w == ("P"))


            {
                Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Ürün kg/adet bilgisi giriniz.");
                q = int.Parse(Console.ReadLine());
                for (fi = 1; fi < elemanSayisi; fi++)
                    tutar1 = birimfiyatpeynir * q;
                if (q >= 1 && q <= 10)
                {
                    Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + $"{q} adet/kg ürünün fiyatı:" + birimfiyatpeynir * q + "TL");
                    Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Toplam Tutar:" + " " + tutar1 + "TL");
                }

            }
            else if (w == ("Z"))

            {
                Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Ürün kg/adet bilgisi giriniz");
                q = int.Parse(Console.ReadLine());
                for (fi = 1; fi < elemanSayisi; fi++)
                    tutar1 = birimfiyatzeytin * q;
                if (q >= 1 && q <= 10)
                {
                    Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + $"{q} adet/kg ürünün fiyatı:" + birimfiyatzeytin * q + "TL");
                    Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Toplam Tutar:" + " " + tutar1 + "TL");
                }
            }
            else if (w == ("S"))


            {
                Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Ürün kg/adet bilgisi giriniz.");
                q = int.Parse(Console.ReadLine());
                for (fi = 1; fi < elemanSayisi; fi++)
                    tutar1 = birimfiyatsucuk * q;
                if (q >= 1 && q <= 10)
                {
                    Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + $"{q} adet/kg ürünün fiyatı:" + birimfiyatsucuk * q + "TL");
                    Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Toplam Tutar:" + " " + tutar1 + "TL");
                }
            }

            else if (w == ("C"))

            {
                Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Ürün kg/adet bilgisi giriniz.");
                q = int.Parse(Console.ReadLine());
                for (fi = 1; fi < elemanSayisi; fi++)
                    tutar1 = birimfiyatcikolata * q;
                if (q >= 1 && q <= 10)
                {
                    Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + $"{q} adet/kg ürünün fiyatı:" + birimfiyatcikolata * q + "TL");
                    Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Toplam Tutar:" + " " + tutar1 + "TL");
                }
            }

            else if (w == ("Ç"))

            {
                Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Ürün kg/adet bilgisi giriniz.");
                q = int.Parse(Console.ReadLine());
                for (fi = 1; fi < elemanSayisi; fi++)
                    tutar1 = birimfiyatcips * q;
                if (q >= 1 && q <= 10)
                {
                    Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + $"{q} adet/kg ürünün fiyatı:" + birimfiyatcips * q + "TL");
                    Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Toplam Tutar:" + " " + tutar1 + "TL");
                }
            }

            else if (w == ("Ş"))

            {
                Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Ürün kg/adet bilgisi giriniz.");
                q = int.Parse(Console.ReadLine());
                for (fi = 1; fi < elemanSayisi; fi++)
                    tutar1 = birimfiyatseker * q;
                if (q >= 1 && q <= 10)
                {
                    Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + $"{q} adet/kg ürünün fiyatı:" + birimfiyatseker * q + "TL");
                    Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Toplam Tutar:" + " " + tutar1 + "TL");
                }
            }

            else if (w == ("U"))

            {
                Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Ürün kg/adet bilgisi giriniz.");
                q = int.Parse(Console.ReadLine());
                for (fi = 1; fi < elemanSayisi; fi++)
                    tutar1 = birimfiyatsut * q;
                if (q >= 1 && q <= 10)
                {
                    Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + $"{q} adet/kg ürünün fiyatı:" + birimfiyatsut * q + "TL");
                    Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Toplam Tutar:" + " " + tutar1 + "TL");
                }
            }

            else if (w == ("Y"))

            {
                Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Ürün kg/adet bilgisi giriniz.");
                q = int.Parse(Console.ReadLine());
                for (fi = 1; fi < elemanSayisi; fi++)
                    tutar1 = birimfiyatyogurt * q;
                if (q >= 1 && q <= 10)
                {
                    Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + $"{q} adet/kg ürünün fiyatı:" + birimfiyatyogurt * q + "TL");
                    Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Toplam Tutar:" + " " + tutar1 + "TL");
                }
            }

            else if (w == ("A"))

            {
                Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Ürün kg/adet bilgisi giriniz.");
                q = int.Parse(Console.ReadLine());
                for (fi = 1; fi < elemanSayisi; fi++)
                    tutar1 = birimfiyatkaymak * q;
                if (q >= 1 && q <= 10)
                {
                    Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + $"{q} adet/kg ürünün fiyatı:" + birimfiyatkaymak * q + "TL");
                    Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Toplam Tutar:" + " " + tutar1 + "TL");
                }
            }



            Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Genel Toplam:" + tutar1);
            Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Alışverişe devam etmek ister misiniz[E/H]");
            string cevap = Console.ReadLine();
            if (cevap == ("E"))
                Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Hangi reyonumuzdan ürün satın almak istersiniz?");
            Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Kasap(1) Manav(2) Şarküteri (3) Çerez(4) Süt Ürünleri (5)");


            if (cevap == ("H"))
                Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Teşekkür eder, iyi günler dileriz.");



            int degisken2 = int.Parse(Console.ReadLine());
            if (degisken2 == 1)
                Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Kasap reyonuna hoşgeldiniz.Devam etmek için (1)");

            if (degisken2 == 2)
                Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Manav reyonuna hoşgeldiniz.Devam etmek için (2)");

            if (degisken2 == 3)
                Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Şarküteri reyonuna hoşgeldiniz.Devam etmek için (3)");

            if (degisken2 == 4)
                Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Çerez reyonuna hoşgeldiniz.Devam etmek için: (4)");

            if (degisken2 == 5)
                Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Süt ürünleri reyonuna hoşgeldiniz. Devam etmek için (5)");

            string[] bolumListesi2 = { "kasap", "manav", "sarkuteri", "cerez", "sut" };
            int c;
            c = int.Parse(Console.ReadLine());
            if (c == 1)
                Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Hangi ürünü satın almak istersiniz? Dana eti (1), Kuzu eti (2) , Tavuk (3)");
            if (c == 2)
                Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Hangi ürünü satın almak istersiniz? Roka (4), Brokoli (5), Maydanoz (6)");
            if (c == 3)
                Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Hangi ürünü satın almak istersiniz? Peynir(7) , Zeytin(8), Sucuk (9)");
            if (c == 4)
                Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Hangi ürünü satın almak istersiniz? Cikolata(10), Cips(11), Seker(12)");
            if (c == 5)
                Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Hangi ürünü satın almak istersiniz? Sut(13) , Yogurt(14), Kaymak(15)");




            string[] kasap2 = { "dana", "kuzu", "tavuk", "roka", "brokoli", "maydanoz", "peynir", "zeytin", "sucuk", "cikolata", "cips", "seker", "sut", "yogurt", "kaymak" };
            int y = int.Parse(Console.ReadLine());
            if (y == 1)
                Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Dana sepete eklendi. KG'ı 150 TL'dir.Devam etmek için 'D'yazınız.");
            else if (y == 2)
                Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Kuzu sepete eklendi. KG'ı 200 TL'dir.Devam etmek için 'K'yazınız.");
            else if (y == 3)
                Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Tavuk sepete eklendi.KG'ı 100 TL'dir.Devam etmek için 'T'yazınız.");
            else if (y == 4)
                Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Roka sepete eklendi. Fiyatı 30 TL'dir.Devam etmek için 'R'yazınız.");
            else if (y == 5)
                Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Brokoli sepete eklendi. Fiyatı 25 TL'dir.Devam etmek için 'B'yazınız.");
            else if (y == 6)
                Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Maydanoz sepete eklendi. Fiyatı 20 TL'dir.Devam etmek için 'M'yazınız.");
            else if (y == 7)
                Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Peynir sepete eklendi. Fiyatı 100 TL'dir.Devam etmek için 'P'yazınız.");
            else if (y == 8)
                Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Zeytin sepete eklendi. Fiyatı 100 TL'dir. Devam etmek için 'Z'yazınız.");
            else if (y == 9)
                Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Sucuk sepete eklendi. Fiyatı 150 TL'dir. Devam etmek için 'S' yazınız.");
            else if (y == 10)
                Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Cikolata sepete eklendi. Fiyatı 30 TL'dir. Devam etmek için 'C' yazınız.");
            else if (y == 11)
                Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Cips sepete eklendi. Fiyatı 25 TL'dir. Devam etmek için 'Ç' yazınız.");
            else if (y == 12)
                Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Seker sepete eklendi. Fiyatı 20 TL'dir. Devam etmek için 'Ş' yazınız.");
            else if (y == 13)
                Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Sut sepete eklendi. Fiyatı 50 TL'dir. Devam etmek icin 'U' yazınız.");
            else if (y == 14)
                Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Yogurt sepete eklendi. Fiyatı 60 TL'dir. Devam etmek icin 'Y' yazınız.");
            else if (y == 15)
                Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Kaymak sepete eklendi. Fiyatı 100 TL'dir. Devam etmek için 'A'yazınız.");

            int[] urunAdet2 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int qi;
            int f;
            string r;
            int tutar2, elemanSayisi2;
            tutar2 = 0;
            elemanSayisi2 = 10;

            r = Console.ReadLine();

            if (r == ("D"))
            {
                Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Ürün kg/adet bilgisi giriniz.");
                f = int.Parse(Console.ReadLine());
                for (qi = 1; qi < elemanSayisi; qi++)
                    tutar2 = birimfiyatdana * f;
                if (f >= 1 && f <= 10)
                {
                    Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + $"{f} adet/kg ürünün fiyatı:" + birimfiyatdana * f + "TL");
                    Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Toplam Tutar:" + " " + tutar2 + "TL");
                }
            }
            else if (r == ("K"))
            {
                Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Ürün kg/adet bilgisi giriniz.");
                f = int.Parse(Console.ReadLine());
                for (qi = 1; qi < elemanSayisi2; qi++)
                    tutar2 = birimfiyatkuzu * f;
                if (f >= 1 && f <= 10)
                {
                    Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + $"{f} adet/kg ürünün fiyatı:" + birimfiyatkuzu * f + "TL");
                    Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Toplam Tutar:" + " " + tutar2 + "TL");
                }

            }

            else if (r == ("T"))
            {
                Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Ürün kg/adet bilgisi giriniz.");
                f = int.Parse(Console.ReadLine());
                for (qi = 1; qi < elemanSayisi2; qi++)
                    tutar2 = birimfiyattavuk * f;
                if (f >= 1 && f <= 10)
                {
                    Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + $"{f} adet/kg ürünün fiyatı:" + birimfiyattavuk * f + "TL");
                    Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Toplam Tutar:" + " " + tutar2 + "TL");
                }
            }

            else if (r == ("R"))
            {
                Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Ürün kg/adet bilgisi giriniz.");
                f = int.Parse(Console.ReadLine());
                for (qi = 1; qi < elemanSayisi2; qi++)
                    tutar2 = birimfiyatroka * f;
                if (f >= 1 && f <= 10)
                {
                    Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + $"{f} adet/kg ürünün fiyatı:" + birimfiyatroka * f + "TL");
                    Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Toplam Tutar:" + " " + tutar2 + "TL");
                }
            }

            else if (r == ("B"))
            {
                Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Ürün kg/adet bilgisi giriniz.");
                f = int.Parse(Console.ReadLine());
                for (qi = 1; qi < elemanSayisi2; qi++)
                    tutar2 = birimfiyatbrokoli * f;
                if (f >= 1 && f <= 10)
                {
                    Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + $"{f} adet/kg ürünün fiyatı:" + birimfiyatbrokoli * f + "TL");
                    Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Toplam Tutar:" + " " + tutar2 + "TL");
                }
            }
            else if (r == ("M"))
            {
                Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Ürün kg/adet bilgisi giriniz.");
                f = int.Parse(Console.ReadLine());
                for (qi = 1; qi < elemanSayisi2; qi++)
                    tutar2 = birimfiyatmaydanoz * f;
                if (f >= 1 && f <= 10)
                {
                    Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + $"{f} adet/kg ürünün fiyatı:" + birimfiyatmaydanoz * f + "TL");
                    Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Toplam Tutar:" + " " + tutar2 + "TL");
                }
            }
            else if (r == ("P"))
            {
                Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Ürün kg/adet bilgisi giriniz.");
                f = int.Parse(Console.ReadLine());
                for (qi = 1; qi < elemanSayisi2; qi++)
                    tutar2 = birimfiyatpeynir * f;
                if (f >= 1 && f <= 10)
                {
                    Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + $"{f} adet/kg ürünün fiyatı:" + birimfiyatpeynir * f + "TL");
                    Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Toplam Tutar:" + " " + tutar2 + "TL");
                }
            }

            else if (r == ("Z"))
            {
                Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Ürün kg/adet bilgisi giriniz.");
                f = int.Parse(Console.ReadLine());
                for (qi = 1; qi < elemanSayisi2; qi++)
                    tutar2 = birimfiyatzeytin * f;
                if (f >= 1 && f <= 10)
                {
                    Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + $"{f} adet/kg ürünün fiyatı:" + birimfiyatzeytin * f + "TL");
                    Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Toplam Tutar:" + " " + tutar2 + "TL");
                }
            }

            else if (r == ("S"))
            {
                Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Ürün kg/adet bilgisi giriniz.");
                f = int.Parse(Console.ReadLine());
                for (qi = 1; qi < elemanSayisi2; qi++)
                    tutar2 = birimfiyatsucuk * f;
                if (f >= 1 && f <= 10)
                {
                    Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + $"{f} adet/kg ürünün fiyatı:" + birimfiyatsucuk * f + "TL");
                    Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Toplam Tutar:" + " " + tutar2 + "TL");
                }
            }

            else if (w == ("C"))

            {
                Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Ürün kg/adet bilgisi giriniz.");
                f = int.Parse(Console.ReadLine());
                for (qi = 1; qi < elemanSayisi; qi++)
                    tutar2 = birimfiyatcikolata * f;
                if (f >= 1 && f <= 10)
                {
                    Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + $"{f} adet/kg ürünün fiyatı:" + birimfiyatcikolata * f + "TL");
                    Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Toplam Tutar:" + " " + tutar2 + "TL");
                }
            }

            else if (w == ("Ç"))

            {
                Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Ürün kg/adet bilgisi giriniz.");
                f = int.Parse(Console.ReadLine());
                for (qi = 1; qi < elemanSayisi; qi++)
                    tutar2 = birimfiyatcips * f;
                if (f >= 1 && f <= 10)
                {
                    Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + $"{f} adet/kg ürünün fiyatı:" + birimfiyatcips * f + "TL");
                    Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Toplam Tutar:" + " " + tutar1 + "TL");
                }
            }

            else if (w == ("Ş"))

            {
                Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Ürün kg/adet bilgisi giriniz.");
                f = int.Parse(Console.ReadLine());
                for (qi = 1; qi < elemanSayisi; qi++)
                    tutar2 = birimfiyatseker * f;
                if (f >= 1 && f <= 10)
                {
                    Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + $"{f} adet/kg ürünün fiyatı:" + birimfiyatseker * f + "TL");
                    Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Toplam Tutar:" + " " + tutar2 + "TL");
                }
            }

            else if (w == ("U"))

            {
                Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Ürün kg/adet bilgisi giriniz.");
                f = int.Parse(Console.ReadLine());
                for (qi = 1; qi < elemanSayisi; qi++)
                    tutar2 = birimfiyatsut * f;
                if (f >= 1 && f <= 10)
                {
                    Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + $"{f} adet/kg ürünün fiyatı:" + birimfiyatsut * f + "TL");
                    Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Toplam Tutar:" + " " + tutar2 + "TL");
                }
            }

            else if (w == ("Y"))

            {
                Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Ürün kg/adet bilgisi giriniz.");
                f = int.Parse(Console.ReadLine());
                for (qi = 1; qi < elemanSayisi2; qi++)
                    tutar2 = birimfiyatyogurt * f;
                if (f >= 1 && f <= 10)
                {
                    Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + $"{f} adet/kg ürünün fiyatı:" + birimfiyatyogurt * f + "TL");
                    Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Toplam Tutar:" + " " + tutar2 + "TL");
                }
            }

            else if (w == ("A"))

            {
                Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Ürün kg/adet bilgisi giriniz.");
                f = int.Parse(Console.ReadLine());
                for (qi = 1; qi < elemanSayisi2; qi++)
                    tutar2 = birimfiyatkaymak * f;
                if (f >= 1 && f <= 10)
                {
                    Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + $"{f} adet/kg ürünün fiyatı:" + birimfiyatkaymak * f + "TL");
                    Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Toplam Tutar:" + " " + tutar2 + "TL");
                }
            }


            Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Genel Toplam:" + (tutar1 + tutar2));

            Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Alışverişe devam etmek ister misiniz.[E/H]");
            string cevap2 = Console.ReadLine();
            if (cevap2 == ("E"))

                Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Hangi reyonumuzdan ürün satın almak istersiniz, şu tuşlardan birine tıklayınız. Kasap(1), Manav(2), Şarküteri(3), Cerez (4) , Sut Urunleri (5) ");

            else if (cevap2 == ("H"))

                Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Teşekkür eder, iyi günler dileriz.");


            int degisken3 = int.Parse(Console.ReadLine());
            if (degisken3 == 1)
                Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Kasap reyonuna hoşgeldiniz. Devam etmek için: (1)");

            else if (degisken3 == 2)
                Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Manav reyonuna hoşgeldiniz. Devam etmek için: (2)");

            else if (degisken3 == 3)
                Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Şarküteri reyonuna hoşgeldiniz. Devam etmek için: (3)");

            else if (degisken3 == 4)
                Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Çerez reyonuna hoşgeldiniz. Devam etmek için: (4)");

            else if (degisken3 == 5)
                Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Süt ürünleri reyonuna hoşgeldiniz. Devam etmek için: (5)");


            string[] bolumListesi3 = { "kasap", "manav", "sarkuteri", "cerez", "sut urunleri" };
            int d;
            d = int.Parse(Console.ReadLine());
            if (d == 1)
                Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Hangi ürünü satın almak istersiniz? Dana eti (1), Kuzu eti (2) , Tavuk (3)");
            if (d == 2)
                Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Hangi ürünü satın almak istersiniz? Roka (4), Brokoli (5), Maydanoz (6)");
            if (d == 3)
                Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Hangi ürünü satın almak istersiniz? Peynir(7) , Zeytin(8), Sucuk (9)");
            if (c == 4)
                Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Hangi ürünü satın almak istersiniz? Cikolata(10), Cips(11), Seker(12)");
            if (c == 5)
                Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Hangi ürünü satın almak istersiniz? Sut(13) , Yogurt(14), Kaymak(15)");

            string[] kasap3 = { "dana", "kuzu", "tavuk", "roka", "brokoli", "maydanoz", "peynir", "zeytin", "sucuk", "cikolata", "cips", "seker", "sut", "yogurt", "kaymak" };
            int z = int.Parse(Console.ReadLine());
            if (z == 1)
                Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Dana sepete eklendi. KG'ı 150 TL'dir.Devam etmek için 'D'yazınız.");
            else if (z == 2)
                Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Kuzu sepete eklendi. KG'ı 200 TL'dir.Devam etmek için 'K'yazınız.");
            else if (z == 3)
                Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Tavuk sepete eklendi.KG'ı 100 TL'dir.Devam etmek için 'T'yazınız.");
            else if (z == 4)
                Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Roka sepete eklendi. Fiyatı 30 TL'dir.Devam etmek için 'R'yazınız.");
            else if (z == 5)
                Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Brokoli sepete eklendi. Fiyatı 25 TL'dir.Devam etmek için 'B'yazınız.");
            else if (z == 6)
                Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Maydanoz sepete eklendi. Fiyatı 20 TL'dir.Devam etmek için 'M'yazınız.");
            else if (z == 7)
                Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Peynir sepete eklendi. Fiyatı 100 TL'dir.Devam etmek için 'P'yazınız.");
            else if (z == 8)
                Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Zeytin sepete eklendi. Fiyatı 100 TL'dir. Devam etmek için 'Z'yazınız.");
            else if (z == 9)
                Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Sucuk sepete eklendi. Fiyatı 150 TL'dir. Devam etmek için 'S' yazınız.");
            else if (z == 10)
                Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Cikolata sepete eklendi. Fiyatı 30 TL'dir. Devam etmek için 'C' yazınız.");
            else if (z == 11)
                Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Cips sepete eklendi. Fiyatı 25 TL'dir. Devam etmek için 'Ç' yazınız.");
            else if (z == 12)
                Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Seker sepete eklendi. Fiyatı 20 TL'dir. Devam etmek için 'Ş' yazınız.");
            else if (z == 13)
                Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Sut sepete eklendi. Fiyatı 50 TL'dir. Devam etmek icin 'U' yazınız.");
            else if (z == 14)
                Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Yogurt sepete eklendi. Fiyatı 60 TL'dir. Devam etmek icin 'Y' yazınız.");
            else if (z == 15)
                Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Kaymak sepete eklendi. Fiyatı 100 TL'dir. Devam etmek için 'A'yazınız.");

            int[] urunAdet3 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int pi;
            int h;
            string t;
            int tutar3, elemanSayisi3;
            tutar3 = 0;
            elemanSayisi3 = 10;

            t = Console.ReadLine();

            if (t == ("D"))
            {
                Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Ürün kg/adet bilgisi giriniz.");
                h = int.Parse(Console.ReadLine());
                for (pi = 1; pi < elemanSayisi3; pi++)
                    tutar3 = birimfiyatdana * h;
                if (h >= 1 && h <= 10)
                {
                    Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + $"{h} adet/kg ürünün fiyatı:" + birimfiyatdana * h + "TL");
                    Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Toplam Tutar:" + " " + tutar3 + "TL");
                }
            }
            else if (t == ("K"))
            {
                Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Ürün kg/adet bilgisi giriniz.");
                h = int.Parse(Console.ReadLine());
                for (pi = 1; pi < elemanSayisi3; pi++)
                    tutar3 = birimfiyatkuzu * h;
                if (h >= 1 && h <= 10)
                {
                    Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + $"{h} adet/kg ürünün fiyatı:" + birimfiyatkuzu * h + "TL");
                    Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Toplam Tutar:" + " " + tutar3 + "TL");
                }

            }

            else if (t == ("T"))
            {
                Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Ürün kg/adet bilgisi giriniz.");
                h = int.Parse(Console.ReadLine());
                for (pi = 1; pi < elemanSayisi3; pi++)
                    tutar3 = birimfiyattavuk * h;
                if (h >= 1 && h <= 10)
                {
                    Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + $"{h} adet/kg ürünün fiyatı:" + birimfiyattavuk * h + "TL");
                    Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Toplam Tutar:" + " " + tutar3 + "TL");
                }
            }

            else if (t == ("R"))
            {
                Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Ürün kg/adet bilgisi giriniz.");
                h = int.Parse(Console.ReadLine());
                for (pi = 1; pi < elemanSayisi3; pi++)
                    tutar3 = birimfiyatroka * h;
                if (h >= 1 && h <= 10)
                {
                    Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + $"{h} adet/kg ürünün fiyatı:" + birimfiyatroka * h + "TL");
                    Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Toplam Tutar:" + " " + tutar3 + "TL");
                }
            }

            else if (t == ("B"))
            {
                Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Ürün kg/adet bilgisi giriniz.");
                h = int.Parse(Console.ReadLine());
                for (pi = 1; pi < elemanSayisi3; pi++)
                    tutar3 = birimfiyatbrokoli * h;
                if (h >= 1 && h <= 10)
                {
                    Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + $"{h} adet/kg ürünün fiyatı:" + birimfiyatbrokoli * h + "TL");
                    Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Toplam Tutar:" + " " + tutar3 + "TL");
                }
            }
            else if (t == ("M"))
            {
                Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Ürün kg/adet bilgisi giriniz.");
                h = int.Parse(Console.ReadLine());
                for (pi = 1; pi < elemanSayisi3; pi++)
                    tutar3 = birimfiyatmaydanoz * h;
                if (h >= 1 && h <= 10)
                {
                    Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + $"{h} adet/kg ürünün fiyatı:" + birimfiyatmaydanoz * h + "TL");
                    Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Toplam Tutar:" + " " + tutar3 + "TL");
                }
            }
            else if (t == ("P"))
            {
                Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Ürün kg/adet bilgisi giriniz.");
                h = int.Parse(Console.ReadLine());
                for (pi = 1; pi < elemanSayisi3; pi++)
                    tutar3 = birimfiyatpeynir * h;
                if (h >= 1 && h <= 10)
                {
                    Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + $"{h} adet/kg ürünün fiyatı:" + birimfiyatpeynir * h + "TL");
                    Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Toplam Tutar:" + " " + tutar3 + "TL");
                }
            }

            else if (t == ("Z"))
            {
                Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Ürün kg/adet bilgisi giriniz.");
                h = int.Parse(Console.ReadLine());
                for (pi = 1; pi < elemanSayisi3; pi++)
                    tutar3 = birimfiyatzeytin * h;
                if (h >= 1 && h <= 10)
                {
                    Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + $"{h} adet/kg ürünün fiyatı:" + birimfiyatzeytin * h + "TL");
                    Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Toplam Tutar:" + " " + tutar3 + "TL");
                }
            }

            else if (t == ("S"))
            {
                Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Ürün kg/adet bilgisi giriniz.");
                h = int.Parse(Console.ReadLine());
                for (pi = 1; pi < elemanSayisi3; pi++)
                    tutar3 = birimfiyatsucuk * h;
                if (h >= 1 && h <= 10)
                {
                    Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + $"{h} adet/kg ürünün fiyatı:" + birimfiyatsucuk * h + "TL");
                    Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Toplam Tutar:" + " " + tutar3 + "TL");
                }
            }

            else if (w == ("C"))

            {
                Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Ürün kg/adet bilgisi giriniz.");
                h = int.Parse(Console.ReadLine());
                for (pi = 1; pi < elemanSayisi3; pi++)
                    tutar3 = birimfiyatcikolata * h;
                if (h >= 1 && h <= 10)
                {
                    Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + $"{h} adet/kg ürünün fiyatı:" + birimfiyatcikolata * h + "TL");
                    Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Toplam Tutar:" + " " + tutar3 + "TL");
                }
            }

            else if (w == ("Ç"))

            {
                Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Ürün kg/adet bilgisi giriniz.");
                h = int.Parse(Console.ReadLine());
                for (pi = 1; pi < elemanSayisi3; pi++)
                    tutar3 = birimfiyatcips * h;
                if (h >= 1 && h <= 10)
                {
                    Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + $"{h} adet/kg ürünün fiyatı:" + birimfiyatcips * h + "TL");
                    Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Toplam Tutar:" + " " + tutar3 + "TL");
                }
            }

            else if (w == ("Ş"))

            {
                Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Ürün kg/adet bilgisi giriniz.");
                h = int.Parse(Console.ReadLine());
                for (pi = 1; pi < elemanSayisi3; pi++)
                    tutar3 = birimfiyatseker * h;
                if (h >= 1 && h <= 10)
                {
                    Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + $"{h} adet/kg ürünün fiyatı:" + birimfiyatseker * h + "TL");
                    Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Toplam Tutar:" + " " + tutar3 + "TL");
                }
            }

            else if (w == ("U"))

            {
                Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Ürün kg/adet bilgisi giriniz.");
                h = int.Parse(Console.ReadLine());
                for (pi = 1; pi < elemanSayisi3; pi++)
                    tutar3 = birimfiyatsut * h;
                if (h >= 1 && h <= 10)
                {
                    Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + $"{h} adet/kg ürünün fiyatı:" + birimfiyatsut * h + "TL");
                    Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Toplam Tutar:" + " " + tutar3 + "TL");
                }
            }

            else if (w == ("Y"))

            {
                Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Ürün kg/adet bilgisi giriniz.");
                h = int.Parse(Console.ReadLine());
                for (pi = 1; pi < elemanSayisi2; pi++)
                    tutar3 = birimfiyatyogurt * h;
                if (h >= 1 && h <= 10)
                {
                    Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + $"{h} adet/kg ürünün fiyatı:" + birimfiyatyogurt * h + "TL");
                    Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Toplam Tutar:" + " " + tutar3 + "TL");
                }
            }

            else if (w == ("A"))

            {
                Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Ürün kg/adet bilgisi giriniz.");
                h = int.Parse(Console.ReadLine());
                for (pi = 1; pi < elemanSayisi2; pi++)
                    tutar3 = birimfiyatkaymak * h;
                if (h >= 1 && h <= 10)
                {
                    Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + $"{h} adet/kg ürünün fiyatı:" + birimfiyatkaymak * h + "TL");
                    Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Toplam Tutar:" + " " + tutar3 + "TL");
                }
            }


            Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Genel Toplam:" + (tutar1 + tutar2 + tutar3) + "TL");

            Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Alışverişe devam etmek ister misiniz?[E/H]");
            string cevap3 = Console.ReadLine();
            if (cevap3 == ("E"))

                Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Hangi reyonumuzdan ürün satın almak istersiniz, şu tuşlardan birine tıklayınız. Kasap(1), Manav(2), Şarküteri(3), Cerez (4), Sut Urunleri(5)");

            else if (cevap3 == ("H"))

                Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Sipariş Toplamı:" + (tutar1 + tutar2 + tutar3) + "TL");

            Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + " " + "Teşekkür eder, iyi günler dileriz.");



            Console.Read();
        }
    }
}
