using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enyenimenü
{
    internal class Metotlar
    {
        static public void anayemek()
        {
            Console.WriteLine("ANAYEMEKLER");
            Console.WriteLine("Karnıyarık");
            Console.WriteLine("Pehlili Pilav");
            Console.WriteLine("Tokat Kebabı");
            Console.WriteLine("Siparişinizi Giriniz");

        }
        static public void pizzalar()
        {
            Console.WriteLine("PİZZALAR");
            Console.WriteLine("Margaritta");
            Console.WriteLine("Akdeniz");
            Console.WriteLine("Geleneksel");
            Console.WriteLine("Siparişinizi Giriniz");
        }
        static public void icecekler()
        {
            Console.WriteLine("Su");
            Console.WriteLine("Kola");
            Console.WriteLine("Fanta");
            Console.WriteLine("Gazoz");
            Console.WriteLine("Siparişinizi Giriniz");
        }

        static public void cıkıs()
        {
            bool valid = true;
            Console.Clear();
            valid = false;
            Console.WriteLine("Hoşcakalın");
            Console.WriteLine("Yine Bekleriz");
            Console.ReadLine();
        }
        static public void adisyon()
        {
            int miktar = 0, miktarK = 0, miktarP = 0, miktarTK = 0, miktarP1 = 0, miktarP2 = 0, miktarP3 = 0, miktarI1 = 0, miktarI2 = 0, miktarI3 = 0, miktarI4 = 0;
            double toplamhesap = 0, hesapK = 0, hesapP = 0, hesapT = 0, hesapP1 = 0, hesapP2 = 0, hesapP3 = 0, hesapI1 = 0, hesapI2 = 0, hesapI3 = 0, hesapI4 = 0;
            Console.Clear();
            Console.WriteLine("KASA İŞLEMLERİ");
            Console.WriteLine("--------------");
            if (miktarK > 0)
            {
                Console.WriteLine("Karnıyarık (" + miktarK + ")\t\t\t TL" + hesapK.ToString());
            }
            if (miktarP > 0)
            {
                Console.WriteLine("Pahlili Pilav (" + miktarP + ")\t\t\t TL" + hesapP.ToString());
            }
            if (miktarTK > 0)
            {
                Console.WriteLine("Tokat Kebabı (" + miktarTK + ")\t\t\t TL" + hesapT.ToString());
            }
            if (miktarP1 > 0)
            {
                Console.WriteLine("Margaritta (" + miktarP1 + ")\t\t\t TL" + hesapP1.ToString());
            }
            if (miktarP2 > 0)
            {
                Console.WriteLine("Akdeniz (" + miktarP2 + ")\t\t\t TL" + hesapP2.ToString());
            }
            if (miktarP3 > 0)
            {
                Console.WriteLine("Geleneksel (" + miktarP3 + ")\t\t\t TL" + hesapP3.ToString());
            }
            if (miktarI1 > 0)
            {
                Console.WriteLine("Su (" + miktarI1 + ")\t\t\t TL" + hesapI1.ToString());
            }
            if (miktarI2 > 0)
            {
                Console.WriteLine("Kola (" + miktarI2 + ")\t\t\t TL" + hesapI2.ToString());
            }
            if (miktarI3 > 0)
            {
                Console.WriteLine("Fanta (" + miktarI3 + ")\t\t\t TL" + hesapI3.ToString());
            }
            if (miktarI4 > 0)
            {
                Console.WriteLine("Gazoz (" + miktarI4 + ")\t\t\t TL" + hesapI4.ToString());
            }
            Console.WriteLine("Toplam Hesap:\t\t\t" + toplamhesap + "\t\t\t TL");
            Console.ReadLine();
        }
    }

}