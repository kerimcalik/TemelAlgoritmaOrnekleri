using System;

namespace TemelAlgoritmaOrnekleri
{
    class Program
    {
        private static void IslemOnceligi()
        {
            int a = 18;
            int b = 6;            
            
            int c = a + b;
            Console.WriteLine(c);

            c = a - b;
            Console.WriteLine(c);

            c = a * b;
            Console.WriteLine(c);

            c = a / b;
            Console.WriteLine(c);
        }

        private static void ArmstrongSayisi()
        {
            int n, r, toplam = 0, temp;

            Console.Write("Üç basamaklı sayı giriniz: ");

            n = int.Parse(Console.ReadLine());
            temp = n;

            while (n > 0)
            {
                r = n % 10;
                toplam += (r * r * r);
                n /= 10;
            }

            if (temp == toplam)
                Console.Write("Armstrong sayısı.");
            else
                Console.Write("Armstrong sayısı değil.");

        }

        private static void UcgeninAlani()
        {
            int taban, yukseklik, alan;
            Console.WriteLine("Üçgenin alanını hesaplamak için taban uzunluğu ve yüksekliği belirtmelisiniz.");

            Console.Write("Taban uzunluğu: ");
            taban = int.Parse(Console.ReadLine());

            Console.Write("Yükselik değeri: ");
            yukseklik = int.Parse(Console.ReadLine());

            alan = taban * yukseklik / 2;

            Console.Write("Belirtilen değerlere ait üçgenin alanı = " + alan);

        }

        private static void PisagorTeorimi()
        {
            double dikKenar1, dikKenar2, hipotenus;

            Console.WriteLine("Pisagor teorimene göre hipotenüsü " +
                "hesaplamak için iki dik kenarın değerini belirtmelisiniz.");

            Console.Write("Birinci dik kenar: ");
            dikKenar1 = int.Parse(Console.ReadLine());

            Console.Write("İkinci dik kenar: ");
            dikKenar2 = int.Parse(Console.ReadLine());

            hipotenus = Math.Pow((Math.Pow(dikKenar1, 2) + Math.Pow(dikKenar2, 2)), 0.5);

            Console.Write("Hipotenus değeri = " + hipotenus);
        }

        private static void DaireDilimAlani()
        {
            double yaricap, aci, alan;
            Console.WriteLine("Klavyeden yarıçapı ve derece cinsinden açısı girilen daire diliminin alanını hesaplamak için istenilen değerleri giriniz.");
            
            Console.Write("Yarıçap değerini giriniz: ");            
            yaricap = int.Parse(Console.ReadLine());

            Console.Write("Açı değerini giriniz: ");
            aci = int.Parse(Console.ReadLine());

            alan = (aci * Math.PI * Math.Pow(yaricap, 2)) / 360;

            Console.Write("Daire diliminin alanı = " + alan);
        }

        private static void OhmKanunu()
        {
            int direnc, akim, volt;

            Console.WriteLine("Klavyeden bir iletkenin direnciyle içinden geçen akım girildiğinde, " +
                "uçlarındaki gerilimi hesaplayabilmek istenilen değeleri giriniz.");

            Console.Write("Direnç değerini giriniz: ");
            direnc = int.Parse(Console.ReadLine());

            Console.Write("Akım değerini giriniz: ");
            akim = int.Parse(Console.ReadLine());

            volt = direnc * akim;

            Console.Write("Verilen değerlere göre voltaj değeri = " + volt);
        }

        private static void TambBolenleriniBul()
        {
            int sayi;
            Console.WriteLine("Klavyeden girilen tam sayının tüm tam bölenlerinin bulunabilmesi için sayı değerini giriniz.");

            Console.Write("Tam sayı: ");
            sayi = int.Parse(Console.ReadLine());

            for (int i = 1; i < sayi; i++)
            {
                if (sayi % i == 0)
                {
                    Console.WriteLine("Tam bölen sayi: " + i);
                }
            }
        }

        private static void KombinasyonHesaplama()
        {
            int n, r, c, f1, f2, f3;
            Console.WriteLine("n elemanlı bir kümenin öğeleriyle elde edilentüm " +
                "grupların her birini hesaplayıp gösteren kombinasyon için aralık değerini giriniz." +
                "C(n,r) = n! / r! * (n-r)!");

            Console.Write("n değerini giriniz: ");
            n = int.Parse(Console.ReadLine());

            Console.Write("r değerini giriniz: ");
            r = int.Parse(Console.ReadLine());

            f1 = n;

            for (int i = n - 1; i >= 1; i--)
            {
                f1 *= i;
            }
            
            f2 = r;
            for (int i = r - 1; i >= 1; i--)
            {
                f2 *= i;
            }

            f3 = n - r;

            for (int i = f3 - 1; i >= 1; i--)
            {
                f3 *= i;
            }

            c = f1 / (f2 * f3);

            Console.WriteLine("Verilen n,r değerine hesaplanan kombinasyon değeri = " + c);
        }

        private static void VkiBulma()
        {
            double boy, kilo;

            Console.Write("Boyunuzu cm olarak giriniz (Ör: 175): ");
            boy = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Kilonuzu kilogram olarak giriniz (Ör: 83): ");
            kilo = Convert.ToDouble(Console.ReadLine());

            boy /= 100;
            double vki = kilo / (boy * boy);

            Console.WriteLine("================================================");
            Console.WriteLine("Vücut Kitle İndeksiniz: {0}", vki);

            if (vki < 18)
            {
                Console.WriteLine("Zayıf");
            }
            else if (vki >= 18 && vki < 25)
            {
                Console.WriteLine("Normal");
            }
            else if (vki >= 25 && vki < 30)
            {
                Console.WriteLine("Kilolu");
            }
            else if (vki >= 30 && vki < 35)
            {
                Console.WriteLine("Obez");
            }
            else
            {
                Console.WriteLine("Morbik Obez");
            }
        }

        private static void SayiTahmini()
        {
            Random rastgele = new Random();
            int enKucuk = 0, enBuyuk = 100;
            int tahmin, sayi = rastgele.Next(enBuyuk);
            int hak = 5;

            while (true)
            {
                Console.WriteLine("\n\n" + hak-- + " hakkınız var.");

                if (hak < 0)
                {
                    Console.WriteLine("KAYBETTİNİZ! Tutulan sayı: " + sayi);
                    break;
                }

                Console.Write(enKucuk + " ile " + enBuyuk + " ARASI BİR SAYI GİRİNİZ: ");

                tahmin = Convert.ToInt32(Console.ReadLine());

                if (tahmin > sayi)
                {
                    if (tahmin < enBuyuk)
                    {
                        enBuyuk = tahmin;
                    }
                }
                else if (tahmin < sayi)
                {
                    if (tahmin > enKucuk)
                    {
                        enKucuk = tahmin;
                    }
                }
                else
                {
                    Console.WriteLine("TEBRİKLER!");
                    break;
                }

            }
        }

        static void Main(string[] args)
        {
            //UcgeninAlani();
            //PisagorTeorimi();
            //DaireDilimAlani();
            //OhmKanunu();
            //TambBolenleriniBul();
            //KombinasyonHesaplama();
            //SayiTahmini();
            //VkiBulma();

            Console.ReadKey();
        }
    }
}
