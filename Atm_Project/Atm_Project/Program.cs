using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atm_Project
{
    class Program
    {
        class banka
        {
            string isim = "umut";
            int sifre = 123;
            bool x = true;
            double bakiye;
            double altin;
            public banka()
            {
                Console.WriteLine("Bankamıza hoşgeldiniz. giriş yapmak için 1'e kaydolmak için 2'ye basınız;");
                int secim = Convert.ToInt32(Console.ReadLine());
                if (secim == 1) 
                {
                    giris();
                }                   
                else
                {
                    Console.WriteLine("Kullanıcı adınızı giriniz.");
                    string yeni_isim = Console.ReadLine();
                    Console.WriteLine("Şifrenizi giriniz.");
                    int yeni_sifre = Convert.ToInt32(Console.ReadLine());
                    kayit( yeni_isim,yeni_sifre);                    
                    giris();
                }
            }


            public void giris()
            {
                while (x == true) 
                {
                    Console.WriteLine("Kullanıcı isminizi giriniz");
                    string girilen_isim = Console.ReadLine();
                    Console.WriteLine("Şifrenizi giriniz.");
                    int girilen_sifre = Convert.ToInt32(Console.ReadLine());
                    if (girilen_isim == isim || girilen_isim == isim) 
                    {
                        if (girilen_sifre == sifre||girilen_sifre == sifre)
                        {
                            Console.WriteLine("Hosgeldiniz.");
                            x = false;
                        }
                        else
                        {
                            Console.WriteLine("Yanlış şifre");
                        }
                    }
                    else if (girilen_sifre == sifre||girilen_sifre == sifre)
                    {
                        Console.WriteLine("Kullanıcı adınız yanlış");
                    }
                    else
                    {
                        Console.WriteLine("Kullanıcı bilgileriniz yanlış");
                    }
                }
            }
            public void kayit(string yeni_isim, int yeni_sifre)
            {                
                this.isim = yeni_isim;
                this.sifre = yeni_sifre;
                Console.WriteLine("Kayıt olma işleminiz başarıyla tamamlanmıştır.");
            }
            public void bakiyemi_belirle(double bakiye)
            {
                this.bakiye = bakiye;
            }
            public double bakiyemi_goster()
            {                
                return  bakiye;
            }
            public void para_cek(int miktar)
            {
                bakiye -= miktar;
                Console.WriteLine("Kalan bakiyeniz: {0}", bakiye);
            }
            public void para_yatir(int miktar)
            {
                bakiye += miktar;
                Console.WriteLine("Kalan bakiyeniz {0}", bakiye);
            }
            public void altinimi_belirle(double altin)
            {
                this.altin = altin;
            }
            public double altinimi_goster()
            {
                return altin;
            }
            public void altin_al(double bakiye)
            {
                altin += bakiye / 99;
                Console.WriteLine("Kalan altın miktarınız: {0}.",altin);
                this.bakiye -= bakiye;
            }
            public void altin_bozdur(double bakiye)
            {
                altin -= bakiye / 99;
                Console.WriteLine("Kalan altın miktarınız: {0}.", altin);
                this.bakiye += bakiye;
            }


        }
        static void Main(string[] args)
        {
            banka i1 = new banka();           
            i1.bakiyemi_belirle(1000);
            i1.altinimi_belirle(3.2);
            Console.WriteLine("Bakiye miktarınız: {0}", i1.bakiyemi_goster());
            Console.WriteLine("Altın miktarınız: {0}", i1.altinimi_goster());
            Console.WriteLine("Yapmak istediğiniz işlemi seçiniz. (1: para çekme 2: para yatırma 3: altın alma");
            int secim = Convert.ToInt32(Console.ReadLine());
            if (secim == 1)
            {
                Console.WriteLine("Kaç para çekmek istiyorsunuz.");
                int miktar = Convert.ToInt32(Console.ReadLine());
                i1.para_cek(miktar);
            }
            else if (secim == 2)
            {
                Console.WriteLine("Kaç para yatırmak istiyorsunuz.");
                int miktar = Convert.ToInt32(Console.ReadLine());
                i1.para_yatir(miktar);
            }
            else if (secim == 3)
            {
                Console.WriteLine("Altın almak için 1'i altın bozdurmak için 2'yi seçiniz");
                int x = Convert.ToInt32(Console.ReadLine());
                if (x == 1)
                {
                    Console.WriteLine("kaç bakiye miktarında altın almak istiyorsunuz.");
                    double y = Convert.ToInt32(Console.ReadLine());
                    i1.altin_al(y);
                }
                else if (x == 2)
                {
                    Console.WriteLine("kaç bakiye miktarında altın bozdurmak istiyorsunuz.");
                    double z = Convert.ToInt32(Console.ReadLine());
                    i1.altin_bozdur(z);
                }
                else
                    Console.WriteLine("Yanlış komut verdiniz.");

            }
            else
                Console.WriteLine("Yanlış komut verdiniz.");
            Console.WriteLine("Bakiye miktarınız: {0}", i1.bakiyemi_goster());
            Console.WriteLine("Altın miktarınız: {0}", i1.altinimi_goster());
            Console.ReadLine();
        }
    }
}
