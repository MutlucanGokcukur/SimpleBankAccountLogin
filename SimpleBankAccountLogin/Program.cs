using System;

namespace SimpleBankAccountLogin
{
    class Program
    {
        static void Main(string[] args)
        {
            int sifre = 1234;
            int giris_hakkı = 3;
            int giris_sifre = 0;
            decimal bakiye = 1000;
        bb:

            try
            {
                Console.Write("Şifreyi Giriniz: ");
                giris_sifre = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Şifre Sadece Sayılardan Oluşmaktadır");
                goto bb;
            }

            if (sifre == giris_sifre)
            {
                Console.WriteLine("Sisteme Başarılı Bir Şekilde Giriş Yapıldı..");
            }
            else
            {
                Console.WriteLine("Yanlış Şifre Girildi");
                giris_hakkı = giris_hakkı - 1;
                if (giris_hakkı == 0)
                {
                    Console.Write("Giriş Hakkınız Kalmamıştır Sistem Sonlandırılıyor....");
                    goto aa;
                }
                else
                {
                    goto bb;
                }
            }
        ff:
            İslemler.menü();
            int secim = Convert.ToInt32(Console.ReadLine());

            switch (secim)
            {
                case 1:
                    İslemler.bakiyesorgu(bakiye);
                    break;
                case 2:
                    Console.Write("Çekilecek Miktarı Giriniz: ");
                    decimal cekme = Convert.ToDecimal(Console.ReadLine());
                    bakiye = İslemler.paracekme(bakiye, cekme);
                    break;
                case 3:
                    Console.Write("Yatırmak İstediğiniz Miktarı Giriniz: ");
                    decimal yatırma = Convert.ToDecimal(Console.ReadLine());
                    bakiye = İslemler.parayatırma(bakiye, yatırma);
                    break;
                case 4:
                hh:
                    Console.Write("Eski Şifrenizi Giriniz: ");
                    int _sifre = Convert.ToInt32(Console.ReadLine());
                    if (_sifre != sifre)
                    {
                        Console.WriteLine("Eski Şifreyi Yanlış Girdiniz\nTekrar Giriniz");
                        goto hh;
                    }
                gg:
                    if (giris_sifre == _sifre)
                    {
                        try
                        {
                            Console.Write("Değiştirmek İstediğiniz 4 Basamaklı Yeni Şifrenizi Giriniz: ");
                            int yeni_sifre = Convert.ToInt32(Console.ReadLine());
                            if (yeni_sifre == giris_sifre)
                            {
                                Console.WriteLine("Yeni Şifre İle Eski Şifre Aynı Olmamalıdır....");
                                goto gg;
                            }
                            else if (yeni_sifre.ToString().Length != 4)
                            {
                                Console.WriteLine("Şifreniz 4 Haneden Oluşmalıdır.\nTekrar Deneyiniz");
                                goto gg;
                            }
                            else
                            {
                                System.Threading.Thread.Sleep(2000);
                                Console.WriteLine("Şifreniz Başarılı Bir Şekilde Değiştirilmiştir.");
                                giris_sifre = yeni_sifre;
                            }
                        }
                        catch
                        {
                            Console.WriteLine("Şifre Sadece Rakamlardan Oluşmalıdır....");
                            goto gg;
                        }
                    }

                    else if (giris_sifre != _sifre)
                    {
                        giris_hakkı = giris_hakkı - 1;
                    }

                    break;
                default:
                    Console.WriteLine("Geçersiz İşlem Numarası Girildi\nTekrar Giriş Yapınız...");
                    goto ff;
            }
            Console.Write("\nBaşka Bir İşlem Yapmak İster Misiniz?(E/H)");
            string tekrarislem = Console.ReadLine();
            tekrarislem = tekrarislem.ToUpper();
            if (tekrarislem == "E")
            {
                Console.Clear();
                goto ff;
            }
            else
            {
                goto aa;
            }
        aa:;
            Console.Write("\nProgram Sonlandırılıyor");
            System.Threading.Thread.Sleep(2000);
        }
    }
}
