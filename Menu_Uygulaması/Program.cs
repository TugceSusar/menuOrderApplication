using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace enyenimenü
{
    internal class Program : Metotlar
    {
        static void Main(string[] args)
        {
            bool valid = true, bitis = true;
            int miktar = 0, miktarK = 0, miktarP = 0, miktarTK = 0, miktarP1 = 0, miktarP2 = 0, miktarP3 = 0, miktarI1 = 0, miktarI2 = 0, miktarI3 = 0, miktarI4 = 0;
            double toplamhesap = 0, hesapK = 0, hesapP = 0, hesapT = 0, hesapP1 = 0, hesapP2 = 0, hesapP3 = 0, hesapI1 = 0, hesapI2 = 0, hesapI3 = 0, hesapI4 = 0;
            int secim1 = 0, secim2 = 0, secim3 = 0, secim4 = 0;
            string devam;
        son:
            Console.WriteLine("**************");
            Console.WriteLine("--------YÖRESEL YEMEKLER---------");
            Console.WriteLine("**************");
            Console.WriteLine("MASA AÇ         \t[1]");
            Console.WriteLine("HESAP İŞLEMLERR \t[2]");
            Console.WriteLine("ADİSYON         \t[3]");
            Console.WriteLine("ÇIKIŞ           \t[4]");
            Console.WriteLine("\n\n -------- İŞLEM SEÇİNİZ-------");
            int secim = Convert.ToInt32(Console.ReadLine());
            while (valid)
            {
                switch (secim)
                {
                    case 1:
                        Console.WriteLine("Masa düzcaseeni");
                        Console.Write("Masa 1"); Console.Write("      "); Console.WriteLine("Masa 3");
                        Console.Write("Masa 2"); Console.Write("      "); Console.WriteLine("Masa 4");
                        Console.WriteLine("Boş masa ID giriniz");
                        int id = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                    devam:
                        switch (id)
                        {
                            case 1:
                                Console.WriteLine("Masa1-Sipariş");
                                Console.WriteLine("-------------");
                                Console.WriteLine("ANAYEMEKLER\t[1]");
                                Console.WriteLine("PİZZALAR\t[2]");
                                Console.WriteLine("iÇECEKLER\t[3]");
                                Console.WriteLine("Kategori Seçiniz:");
                                secim1 = Convert.ToInt32(Console.ReadLine());
                                Console.Clear();
                                switch (secim1)
                                {
                                    case 1:
                                        anayemek();
                                        secim2 = Convert.ToInt32(Console.ReadLine());
                                        Console.WriteLine("Sipaiş Adeti");
                                        miktar = Convert.ToInt32(Console.ReadLine());
                                        Console.Clear();
                                        if (secim2 == 1)
                                        {
                                            miktarK += miktar;
                                            hesapK = hesapK + (miktar * 40);
                                            Console.WriteLine(miktarK + " " + " adet Karnıyarık");
                                            Console.ReadLine(); Console.Clear();
                                            Console.WriteLine("Sipariş vermeye devam etmek istiyor musunuz? (E / H)");
                                            devam = Console.ReadLine().ToUpper();
                                            Console.Clear();
                                            if (devam == "E")
                                            {
                                                goto devam;
                                                Console.Clear();
                                            }
                                            else
                                                goto son;
                                        }
                                        else if (secim2 == 2)
                                        {
                                            miktarP += miktar;
                                            hesapP = hesapP + (miktar * 50);
                                            Console.WriteLine(miktarP + "  " + "adet Pehlili Pilav");
                                            Console.ReadLine(); Console.Clear();
                                            Console.WriteLine("Sipariş vermeye devam etmek istiyor musunuz? (E / H)");
                                            devam = Console.ReadLine().ToUpper();
                                            Console.Clear();
                                            if (devam == "E")
                                            {
                                                goto devam;
                                                Console.Clear();
                                            }
                                            else
                                                goto son;
                                        }
                                        else if (secim2 == 3)
                                        {
                                            miktarTK = miktar;
                                            hesapT = hesapT + (miktar * 100);
                                            Console.WriteLine(miktarTK + " " + " adet Tokat Kebabı");
                                            Console.ReadLine(); Console.Clear();
                                            Console.WriteLine("Sipariş vermeye devam etmek istiyor musunuz? (E / H)");
                                            devam = Console.ReadLine().ToUpper();
                                            Console.Clear();
                                            if (devam == "E")
                                            {
                                                goto devam;
                                                Console.Clear();
                                            }
                                            else
                                                goto son;
                                        }
                                        break;
                                    case 2:
                                        pizzalar();
                                        secim3 = Convert.ToInt32(Console.ReadLine());
                                        Console.WriteLine("Sipariş Adeti");
                                        miktar = Convert.ToInt32(Console.ReadLine());
                                        Console.Clear();
                                        if (secim3 == 1)
                                        {
                                            miktarP1 += miktar;
                                            hesapP1 = hesapP + (miktar * 55);
                                            Console.WriteLine(miktarP1 + " " + "adet Margaritta Pizza");
                                            Console.ReadLine(); Console.Clear();
                                            Console.WriteLine("Sipariş vermeye devam etmek istiyor musunuz? (E / H)");
                                            devam = Console.ReadLine().ToUpper();
                                            Console.Clear();
                                            if (devam == "E")
                                            {
                                                goto devam;
                                                Console.Clear();
                                            }
                                            else
                                                goto son;
                                        }
                                        else if (secim3 == 2)
                                        {
                                            miktarP2 += miktar;
                                            hesapP2 = hesapP2 + (miktar * 65);
                                            Console.WriteLine(miktarP2 + " " + "adet Akdeniz Pizza");
                                            Console.ReadLine(); Console.Clear();
                                            Console.WriteLine("Sipariş vermeye devam etmek istiyor musunuz? (E / H)");
                                            devam = Console.ReadLine().ToUpper();
                                            Console.Clear();
                                            if (devam == "E")
                                            {
                                                goto devam;
                                                Console.Clear();
                                            }
                                            else
                                                goto son;
                                        }
                                        else if (secim3 == 3)
                                        {
                                            miktarP3 += miktar;
                                            hesapP3 = hesapP3 + (miktar * 75);
                                            Console.WriteLine(miktarP3 + " " + " adet Geleneksel Pizza");
                                            Console.ReadLine(); Console.Clear();
                                            Console.WriteLine("Sipariş vermeye devam etmek istiyor musunuz? (E / H)");
                                            devam = Console.ReadLine().ToUpper();
                                            Console.Clear();
                                            if (devam == "E")
                                            {
                                                goto devam;
                                                Console.Clear();
                                            }
                                            else
                                                goto son;
                                        }
                                        break;
                                    case 3:
                                        icecekler();
                                        secim4 = Convert.ToInt32(Console.ReadLine());
                                        Console.WriteLine("Sipariş Adeti");
                                        miktar = Convert.ToInt32(Console.ReadLine());
                                        Console.Clear();
                                        if (secim4 == 1)
                                        {
                                            miktarI1 += miktar;
                                            hesapI1 = hesapI1 + (miktar * 8);
                                            Console.WriteLine(miktarI1 + "  " + "adet Su");
                                            Console.ReadLine();
                                            Console.WriteLine("Sipariş vermeye devam etmek istiyor musunuz? (E / H)");
                                            devam = Console.ReadLine().ToUpper();
                                            Console.Clear();
                                            if (devam == "E")
                                            {
                                                goto devam;
                                                Console.Clear();
                                            }
                                            else
                                                goto son;
                                        }
                                        else if (secim4 == 2)
                                        {
                                            miktarI2 += miktar;
                                            hesapI2 = hesapI2 + (miktar * 20);
                                            Console.WriteLine(miktarI2 + " " + " adet Kola");
                                            Console.ReadLine();
                                            Console.Clear();
                                            Console.WriteLine("Sipariş vermeye devam etmek istiyor musunuz? (E / H)");
                                            devam = Console.ReadLine().ToUpper();
                                            Console.Clear();
                                            if (devam == "E")
                                            {
                                                goto devam;
                                            }
                                            else
                                                goto son;
                                        }
                                        else if (secim4 == 3)
                                        {
                                            miktarI3 += miktar;
                                            hesapI3 = hesapI3 + (miktar * 22);
                                            Console.WriteLine(miktarI3 + " " + "Fanta");
                                            Console.ReadLine(); Console.Clear();
                                            Console.WriteLine("Sipariş vermeye devam etmek istiyor musunuz? (E / H)");
                                            devam = Console.ReadLine().ToUpper();
                                            Console.Clear();
                                            if (devam == "E")
                                            {
                                                goto devam;
                                            }
                                            else
                                                goto son;
                                        }
                                        else if (secim4 == 4)
                                        {
                                            miktarI4 += miktar;
                                            hesapI4 = hesapI4 + (miktar * 21);
                                            Console.WriteLine(miktarI4 + " " + "Gazoz");
                                            Console.ReadLine(); Console.Clear();
                                            Console.WriteLine("Sipariş vermeye devam etmek istiyor musunuz? (E / H)");
                                            devam = Console.ReadLine().ToUpper();
                                            Console.Clear();
                                            if (devam == "E")
                                            {
                                                goto devam;
                                            }
                                            else
                                                goto son;
                                        }
                                        break;
                                }
                                break;
                            case 2:
                                {
                                    Console.WriteLine("Masa2-Sipariş");
                                    Console.WriteLine("-------------");
                                    Console.WriteLine("ANAYEMEKLER\t[1]");
                                    Console.WriteLine("PİZZALAR\t[2]");
                                    Console.WriteLine("iÇECEKLER\t[3]");
                                    Console.WriteLine("Kategori Seçiniz:");
                                    secim1 = Convert.ToInt32(Console.ReadLine());
                                    Console.Clear();
                                    switch (secim1)
                                    {
                                        case 1:
                                            anayemek();
                                            secim2 = Convert.ToInt32(Console.ReadLine());
                                            Console.WriteLine("Sipaiş Adeti");
                                            miktar = Convert.ToInt32(Console.ReadLine());
                                            Console.Clear();
                                            if (secim2 == 1)
                                            {
                                                miktarK += miktar;
                                                hesapK = hesapK + (miktar * 40);
                                                Console.WriteLine(miktarK + " " + " adet Karnıyarık");
                                                Console.ReadLine(); Console.Clear();
                                                Console.WriteLine("Sipariş vermeye devam etmek istiyor musunuz? (E / H)");
                                                devam = Console.ReadLine().ToUpper();
                                                Console.Clear();
                                                if (devam == "E")
                                                {
                                                    goto devam;
                                                    Console.Clear();
                                                }
                                                else
                                                    goto son;
                                            }
                                            else if (secim2 == 2)
                                            {
                                                miktarP += miktar;
                                                hesapP = hesapP + (miktar * 50);
                                                Console.WriteLine(miktarP + "  " + "adet Pehlili Pilav");
                                                Console.ReadLine(); Console.Clear();
                                                Console.WriteLine("Sipariş vermeye devam etmek istiyor musunuz? (E / H)");
                                                devam = Console.ReadLine().ToUpper();
                                                Console.Clear();
                                                if (devam == "E")
                                                {
                                                    goto devam;
                                                    Console.Clear();
                                                }
                                                else
                                                    goto son;
                                            }
                                            else if (secim2 == 3)
                                            {
                                                miktarTK = miktar;
                                                hesapT = hesapT + (miktar * 100);
                                                Console.WriteLine(miktarTK + " " + " adet Tokat Kebabı");
                                                Console.ReadLine(); Console.Clear();
                                                Console.WriteLine("Sipariş vermeye devam etmek istiyor musunuz? (E / H)");
                                                devam = Console.ReadLine().ToUpper();
                                                Console.Clear();
                                                if (devam == "E")
                                                {
                                                    goto devam;
                                                    Console.Clear();
                                                }
                                                else
                                                    goto son;
                                            }
                                            break;
                                        case 2:
                                            pizzalar();
                                            secim3 = Convert.ToInt32(Console.ReadLine());
                                            Console.WriteLine("Sipariş Adeti");
                                            miktar = Convert.ToInt32(Console.ReadLine());
                                            Console.Clear();
                                            if (secim3 == 1)
                                            {
                                                miktarP1 += miktar;
                                                hesapP1 = hesapP + (miktar * 55);
                                                Console.WriteLine(miktarP1 + " " + "adet Margaritta Pizza");
                                                Console.ReadLine(); Console.Clear();
                                                Console.WriteLine("Sipariş vermeye devam etmek istiyor musunuz? (E / H)");
                                                devam = Console.ReadLine().ToUpper();
                                                Console.Clear();
                                                if (devam == "E")
                                                {
                                                    goto devam;
                                                    Console.Clear();
                                                }
                                                else
                                                    goto son;
                                            }
                                            else if (secim3 == 2)
                                            {
                                                miktarP2 += miktar;
                                                hesapP2 = hesapP2 + (miktar * 65);
                                                Console.WriteLine(miktarP2 + " " + "adet Akdeniz Pizza");
                                                Console.ReadLine(); Console.Clear();
                                                Console.WriteLine("Sipariş vermeye devam etmek istiyor musunuz? (E / H)");
                                                devam = Console.ReadLine().ToUpper();
                                                Console.Clear();
                                                if (devam == "E")
                                                {
                                                    goto devam;
                                                    Console.Clear();
                                                }
                                                else
                                                    goto son;
                                            }
                                            else if (secim3 == 3)
                                            {
                                                miktarP3 += miktar;
                                                hesapP3 = hesapP3 + (miktar * 75);
                                                Console.WriteLine(miktarP3 + " " + " adet Geleneksel Pizza");
                                                Console.ReadLine(); Console.Clear();
                                                Console.WriteLine("Sipariş vermeye devam etmek istiyor musunuz? (E / H)");
                                                devam = Console.ReadLine().ToUpper();
                                                Console.Clear();
                                                if (devam == "E")
                                                {
                                                    goto devam;
                                                    Console.Clear();
                                                }
                                                else
                                                    goto son;
                                            }
                                            break;
                                        case 3:
                                            icecekler();
                                            secim4 = Convert.ToInt32(Console.ReadLine());
                                            Console.WriteLine("Sipariş Adeti");
                                            miktar = Convert.ToInt32(Console.ReadLine());
                                            Console.Clear();
                                            if (secim4 == 1)
                                            {
                                                miktarI1 += miktar;
                                                hesapI1 = hesapI1 + (miktar * 8);
                                                Console.WriteLine(miktarI1 + "  " + "adet Su");
                                                Console.ReadLine();
                                                Console.WriteLine("Sipariş vermeye devam etmek istiyor musunuz? (E / H)");
                                                devam = Console.ReadLine().ToUpper();
                                                Console.Clear();
                                                if (devam == "E")
                                                {
                                                    goto devam;
                                                    Console.Clear();
                                                }
                                                else
                                                    goto son;
                                            }
                                            else if (secim4 == 2)
                                            {
                                                miktarI2 += miktar;
                                                hesapI2 = hesapI2 + (miktar * 20);
                                                Console.WriteLine(miktarI2 + " " + " adet Kola");
                                                Console.ReadLine();
                                                Console.Clear();
                                                Console.WriteLine("Sipariş vermeye devam etmek istiyor musunuz? (E / H)");
                                                devam = Console.ReadLine().ToUpper();
                                                Console.Clear();
                                                if (devam == "E")
                                                {
                                                    goto devam;
                                                }
                                                else
                                                    goto son;
                                            }
                                            else if (secim4 == 3)
                                            {
                                                miktarI3 += miktar;
                                                hesapI3 = hesapI3 + (miktar * 22);
                                                Console.WriteLine(miktarI3 + " " + "Fanta");
                                                Console.ReadLine(); Console.Clear();
                                                Console.WriteLine("Sipariş vermeye devam etmek istiyor musunuz? (E / H)");
                                                devam = Console.ReadLine().ToUpper();
                                                Console.Clear();
                                                if (devam == "E")
                                                {
                                                    goto devam;
                                                }
                                                else
                                                    goto son;
                                            }
                                            else if (secim4 == 4)
                                            {
                                                miktarI4 += miktar;
                                                hesapI4 = hesapI4 + (miktar * 21);
                                                Console.WriteLine(miktarI4 + " " + "Gazoz");
                                                Console.ReadLine(); Console.Clear();
                                                Console.WriteLine("Sipariş vermeye devam etmek istiyor musunuz? (E / H)");
                                                devam = Console.ReadLine().ToUpper();
                                                Console.Clear();
                                                if (devam == "E")
                                                {
                                                    goto devam;
                                                }
                                                else
                                                    goto son;
                                            }
                                            break;
                                    }
                                    break;
                                }
                                break;
                            case 3:
                                {
                                    Console.WriteLine("Masa2-Sipariş");
                                    Console.WriteLine("-------------");
                                    Console.WriteLine("ANAYEMEKLER\t[1]");
                                    Console.WriteLine("PİZZALAR\t[2]");
                                    Console.WriteLine("iÇECEKLER\t[3]");
                                    Console.WriteLine("Kategori Seçiniz:");
                                    secim1 = Convert.ToInt32(Console.ReadLine());
                                    Console.Clear();
                                    switch (secim1)
                                    {
                                        case 1:
                                            anayemek();
                                            secim2 = Convert.ToInt32(Console.ReadLine());
                                            Console.WriteLine("Sipaiş Adeti");
                                            miktar = Convert.ToInt32(Console.ReadLine());
                                            Console.Clear();
                                            if (secim2 == 1)
                                            {
                                                miktarK += miktar;
                                                hesapK = hesapK + (miktar * 40);
                                                Console.WriteLine(miktarK + " " + " adet Karnıyarık");
                                                Console.ReadLine(); Console.Clear();
                                                Console.WriteLine("Sipariş vermeye devam etmek istiyor musunuz? (E / H)");
                                                devam = Console.ReadLine().ToUpper();
                                                Console.Clear();
                                                if (devam == "E")
                                                {
                                                    goto devam;
                                                    Console.Clear();
                                                }
                                                else
                                                    goto son;
                                            }
                                            else if (secim2 == 2)
                                            {
                                                miktarP += miktar;
                                                hesapP = hesapP + (miktar * 50);
                                                Console.WriteLine(miktarP + "  " + "adet Pehlili Pilav");
                                                Console.ReadLine(); Console.Clear();
                                                Console.WriteLine("Sipariş vermeye devam etmek istiyor musunuz? (E / H)");
                                                devam = Console.ReadLine().ToUpper();
                                                Console.Clear();
                                                if (devam == "E")
                                                {
                                                    goto devam;
                                                    Console.Clear();
                                                }
                                                else
                                                    goto son;
                                            }
                                            else if (secim2 == 3)
                                            {
                                                miktarTK = miktar;
                                                hesapT = hesapT + (miktar * 100);
                                                Console.WriteLine(miktarTK + " " + " adet Tokat Kebabı");
                                                Console.ReadLine(); Console.Clear();
                                                Console.WriteLine("Sipariş vermeye devam etmek istiyor musunuz? (E / H)");
                                                devam = Console.ReadLine().ToUpper();
                                                Console.Clear();
                                                if (devam == "E")
                                                {
                                                    goto devam;
                                                    Console.Clear();
                                                }
                                                else
                                                    goto son;
                                            }
                                            break;
                                        case 2:
                                            pizzalar();
                                            secim3 = Convert.ToInt32(Console.ReadLine());
                                            Console.WriteLine("Sipariş Adeti");
                                            miktar = Convert.ToInt32(Console.ReadLine());
                                            Console.Clear();
                                            if (secim3 == 1)
                                            {
                                                miktarP1 += miktar;
                                                hesapP1 = hesapP + (miktar * 55);
                                                Console.WriteLine(miktarP1 + " " + "adet Margaritta Pizza");
                                                Console.ReadLine(); Console.Clear();
                                                Console.WriteLine("Sipariş vermeye devam etmek istiyor musunuz? (E / H)");
                                                devam = Console.ReadLine().ToUpper();
                                                Console.Clear();
                                                if (devam == "E")
                                                {
                                                    goto devam;
                                                    Console.Clear();
                                                }
                                                else
                                                    goto son;
                                            }
                                            else if (secim3 == 2)
                                            {
                                                miktarP2 += miktar;
                                                hesapP2 = hesapP2 + (miktar * 65);
                                                Console.WriteLine(miktarP2 + " " + "adet Akdeniz Pizza");
                                                Console.ReadLine(); Console.Clear();
                                                Console.WriteLine("Sipariş vermeye devam etmek istiyor musunuz? (E / H)");
                                                devam = Console.ReadLine().ToUpper();
                                                Console.Clear();
                                                if (devam == "E")
                                                {
                                                    goto devam;
                                                    Console.Clear();
                                                }
                                                else
                                                    goto son;
                                            }
                                            else if (secim3 == 3)
                                            {
                                                miktarP3 += miktar;
                                                hesapP3 = hesapP3 + (miktar * 75);
                                                Console.WriteLine(miktarP3 + " " + " adet Geleneksel Pizza");
                                                Console.ReadLine(); Console.Clear();
                                                Console.WriteLine("Sipariş vermeye devam etmek istiyor musunuz? (E / H)");
                                                devam = Console.ReadLine().ToUpper();
                                                Console.Clear();
                                                if (devam == "E")
                                                {
                                                    goto devam;
                                                    Console.Clear();
                                                }
                                                else
                                                    goto son;
                                            }
                                            break;
                                        case 3:
                                            icecekler();
                                            secim4 = Convert.ToInt32(Console.ReadLine());
                                            Console.WriteLine("Sipariş Adeti");
                                            miktar = Convert.ToInt32(Console.ReadLine());
                                            Console.Clear();
                                            if (secim4 == 1)
                                            {
                                                miktarI1 += miktar;
                                                hesapI1 = hesapI1 + (miktar * 8);
                                                Console.WriteLine(miktarI1 + "  " + "adet Su");
                                                Console.ReadLine();
                                                Console.WriteLine("Sipariş vermeye devam etmek istiyor musunuz? (E / H)");
                                                devam = Console.ReadLine().ToUpper();
                                                Console.Clear();
                                                if (devam == "E")
                                                {
                                                    goto devam;
                                                    Console.Clear();
                                                }
                                                else
                                                    goto son;
                                            }
                                            else if (secim4 == 2)
                                            {
                                                miktarI2 += miktar;
                                                hesapI2 = hesapI2 + (miktar * 20);
                                                Console.WriteLine(miktarI2 + " " + " adet Kola");
                                                Console.ReadLine();
                                                Console.Clear();
                                                Console.WriteLine("Sipariş vermeye devam etmek istiyor musunuz? (E / H)");
                                                devam = Console.ReadLine().ToUpper();
                                                Console.Clear();
                                                if (devam == "E")
                                                {
                                                    goto devam;
                                                }
                                                else
                                                    goto son;
                                            }
                                            else if (secim4 == 3)
                                            {
                                                miktarI3 += miktar;
                                                hesapI3 = hesapI3 + (miktar * 22);
                                                Console.WriteLine(miktarI3 + " " + "Fanta");
                                                Console.ReadLine(); Console.Clear();
                                                Console.WriteLine("Sipariş vermeye devam etmek istiyor musunuz? (E / H)");
                                                devam = Console.ReadLine().ToUpper();
                                                Console.Clear();
                                                if (devam == "E")
                                                {
                                                    goto devam;
                                                }
                                                else
                                                    goto son;
                                            }
                                            else if (secim4 == 4)
                                            {
                                                miktarI4 += miktar;
                                                hesapI4 = hesapI4 + (miktar * 21);
                                                Console.WriteLine(miktarI4 + " " + "Gazoz");
                                                Console.ReadLine(); Console.Clear();
                                                Console.WriteLine("Sipariş vermeye devam etmek istiyor musunuz? (E / H)");
                                                devam = Console.ReadLine().ToUpper();
                                                Console.Clear();
                                                if (devam == "E")
                                                {
                                                    goto devam;
                                                }
                                                else
                                                    goto son;
                                            }
                                            break;
                                    }
                                    break;
                                }
                                break;
                            case 4:
                                {
                                    Console.WriteLine("Masa2-Sipariş");
                                    Console.WriteLine("-------------");
                                    Console.WriteLine("ANAYEMEKLER\t[1]");
                                    Console.WriteLine("PİZZALAR\t[2]");
                                    Console.WriteLine("iÇECEKLER\t[3]");
                                    Console.WriteLine("Kategori Seçiniz:");
                                    secim1 = Convert.ToInt32(Console.ReadLine());
                                    Console.Clear();
                                    switch (secim1)
                                    {
                                        case 1:
                                            anayemek();
                                            secim2 = Convert.ToInt32(Console.ReadLine());
                                            Console.WriteLine("Sipaiş Adeti");
                                            miktar = Convert.ToInt32(Console.ReadLine());
                                            Console.Clear();
                                            if (secim2 == 1)
                                            {
                                                miktarK += miktar;
                                                hesapK = hesapK + (miktar * 40);
                                                Console.WriteLine(miktarK + " " + " adet Karnıyarık");
                                                Console.ReadLine(); Console.Clear();
                                                Console.WriteLine("Sipariş vermeye devam etmek istiyor musunuz? (E / H)");
                                                devam = Console.ReadLine().ToUpper();
                                                Console.Clear();
                                                if (devam == "E")
                                                {
                                                    goto devam;
                                                    Console.Clear();
                                                }
                                                else
                                                    goto son;
                                            }
                                            else if (secim2 == 2)
                                            {
                                                miktarP += miktar;
                                                hesapP = hesapP + (miktar * 50);
                                                Console.WriteLine(miktarP + "  " + "adet Pehlili Pilav");
                                                Console.ReadLine(); Console.Clear();
                                                Console.WriteLine("Sipariş vermeye devam etmek istiyor musunuz? (E / H)");
                                                devam = Console.ReadLine().ToUpper();
                                                Console.Clear();
                                                if (devam == "E")
                                                {
                                                    goto devam;
                                                    Console.Clear();
                                                }
                                                else
                                                    goto son;
                                            }
                                            else if (secim2 == 3)
                                            {
                                                miktarTK = miktar;
                                                hesapT = hesapT + (miktar * 100);
                                                Console.WriteLine(miktarTK + " " + " adet Tokat Kebabı");
                                                Console.ReadLine(); Console.Clear();
                                                Console.WriteLine("Sipariş vermeye devam etmek istiyor musunuz? (E / H)");
                                                devam = Console.ReadLine().ToUpper();
                                                Console.Clear();
                                                if (devam == "E")
                                                {
                                                    goto devam;
                                                    Console.Clear();
                                                }
                                                else
                                                    goto son;
                                            }
                                            break;
                                        case 2:
                                            pizzalar();
                                            secim3 = Convert.ToInt32(Console.ReadLine());
                                            Console.WriteLine("Sipariş Adeti");
                                            miktar = Convert.ToInt32(Console.ReadLine());
                                            Console.Clear();
                                            if (secim3 == 1)
                                            {
                                                miktarP1 += miktar;
                                                hesapP1 = hesapP + (miktar * 55);
                                                Console.WriteLine(miktarP1 + " " + "adet Margaritta Pizza");
                                                Console.ReadLine(); Console.Clear();
                                                Console.WriteLine("Sipariş vermeye devam etmek istiyor musunuz? (E / H)");
                                                devam = Console.ReadLine().ToUpper();
                                                Console.Clear();
                                                if (devam == "E")
                                                {
                                                    goto devam;
                                                    Console.Clear();
                                                }
                                                else
                                                    goto son;
                                            }
                                            else if (secim3 == 2)
                                            {
                                                miktarP2 += miktar;
                                                hesapP2 = hesapP2 + (miktar * 65);
                                                Console.WriteLine(miktarP2 + " " + "adet Akdeniz Pizza");
                                                Console.ReadLine(); Console.Clear();
                                                Console.WriteLine("Sipariş vermeye devam etmek istiyor musunuz? (E / H)");
                                                devam = Console.ReadLine().ToUpper();
                                                Console.Clear();
                                                if (devam == "E")
                                                {
                                                    goto devam;
                                                    Console.Clear();
                                                }
                                                else
                                                    goto son;
                                            }
                                            else if (secim3 == 3)
                                            {
                                                miktarP3 += miktar;
                                                hesapP3 = hesapP3 + (miktar * 75);
                                                Console.WriteLine(miktarP3 + " " + " adet Geleneksel Pizza");
                                                Console.ReadLine(); Console.Clear();
                                                Console.WriteLine("Sipariş vermeye devam etmek istiyor musunuz? (E / H)");
                                                devam = Console.ReadLine().ToUpper();
                                                Console.Clear();
                                                if (devam == "E")
                                                {
                                                    goto devam;
                                                    Console.Clear();
                                                }
                                                else
                                                    goto son;
                                            }
                                            break;
                                        case 3:
                                            icecekler();
                                            secim4 = Convert.ToInt32(Console.ReadLine());
                                            Console.WriteLine("Sipariş Adeti");
                                            miktar = Convert.ToInt32(Console.ReadLine());
                                            Console.Clear();
                                            if (secim4 == 1)
                                            {
                                                miktarI1 += miktar;
                                                hesapI1 = hesapI1 + (miktar * 8);
                                                Console.WriteLine(miktarI1 + "  " + "adet Su");
                                                Console.ReadLine();
                                                Console.WriteLine("Sipariş vermeye devam etmek istiyor musunuz? (E / H)");
                                                devam = Console.ReadLine().ToUpper();
                                                Console.Clear();
                                                if (devam == "E")
                                                {
                                                    goto devam;
                                                    Console.Clear();
                                                }
                                                else
                                                    goto son;
                                            }
                                            else if (secim4 == 2)
                                            {
                                                miktarI2 += miktar;
                                                hesapI2 = hesapI2 + (miktar * 20);
                                                Console.WriteLine(miktarI2 + " " + " adet Kola");
                                                Console.ReadLine();
                                                Console.Clear();
                                                Console.WriteLine("Sipariş vermeye devam etmek istiyor musunuz? (E / H)");
                                                devam = Console.ReadLine().ToUpper();
                                                Console.Clear();
                                                if (devam == "E")
                                                {
                                                    goto devam;
                                                }
                                                else
                                                    goto son;
                                            }
                                            else if (secim4 == 3)
                                            {
                                                miktarI3 += miktar;
                                                hesapI3 = hesapI3 + (miktar * 22);
                                                Console.WriteLine(miktarI3 + " " + "Fanta");
                                                Console.ReadLine(); Console.Clear();
                                                Console.WriteLine("Sipariş vermeye devam etmek istiyor musunuz? (E / H)");
                                                devam = Console.ReadLine().ToUpper();
                                                Console.Clear();
                                                if (devam == "E")
                                                {
                                                    goto devam;
                                                }
                                                else
                                                    goto son;
                                            }
                                            else if (secim4 == 4)
                                            {
                                                miktarI4 += miktar;
                                                hesapI4 = hesapI4 + (miktar * 21);
                                                Console.WriteLine(miktarI4 + " " + "Gazoz");
                                                Console.ReadLine(); Console.Clear();
                                                Console.WriteLine("Sipariş vermeye devam etmek istiyor musunuz? (E / H)");
                                                devam = Console.ReadLine().ToUpper();
                                                Console.Clear();
                                                if (devam == "E")
                                                {
                                                    goto devam;
                                                }
                                                else
                                                    goto son;
                                            }
                                            break;
                                    }
                                    break;
                                }
                                break;
                        }
                        break;
                    case 2:
                        {
                            Console.Clear();
                            Console.WriteLine("HESAP İŞLEMLERİ");
                            Console.WriteLine(" ");
                            toplamhesap = hesapK + hesapP + hesapT + hesapP1 + hesapP2 + hesapP3 + hesapI1 + hesapI2 + hesapI3 + hesapI4;
                            Console.WriteLine("Toplam Hesap $" + toplamhesap.ToString());
                            string bahsis;
                            double bahsisDoub;
                            Console.WriteLine("Bahşiş bırkamak ister misiniz? (E veya H)");
                            bahsis = Console.ReadLine();

                            if (bahsis == "E")
                            {
                                bahsisDoub = toplamhesap * 0.1;
                                bahsisDoub = Math.Round(bahsisDoub, 2);
                                toplamhesap += bahsisDoub;
                                Console.WriteLine("Toplam Hesap:" + toplamhesap);
                                Console.ReadLine();
                                Console.Clear();
                                goto son;
                            }
                            else
                            {
                                Console.WriteLine("Toplam Hesap:" + toplamhesap);
                                Console.ReadLine();
                                Console.Clear();
                                goto son;
                            }
                        }
                        Console.Clear();
                        break;


                    case 3:
                        {
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

                            Console.WriteLine("Toplam Hesap:" + toplamhesap);
                            Console.ReadLine();
                            Console.Clear();
                            goto son;
                        }
                        break;
                    case 4:
                        {
                            Console.Clear();
                            valid = false;
                            Console.WriteLine("Hoşcakalın");
                            Console.WriteLine("Yine BEkleriz");
                            Console.ReadLine();
                        }
                        break;
                }
            }
        }
    }
}
