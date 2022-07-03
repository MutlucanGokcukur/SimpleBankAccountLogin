using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleBankAccountLogin
{
    class İslemler
    {
        public static void menü()
        {
            Console.WriteLine("1-Bakiye Görüntüleme\n2-Para Çekme\n3-Para Yatırma\n4-Şifre Değiştirme");
            Console.Write("\nYapılacak İşlemi Seçiniz: ");
        }
        public static void bakiyesorgu(decimal bakiye)
        {
            Console.WriteLine("Hesabınızdaki Bakiye Miktarı: {0}", bakiye);
        }
        public static decimal paracekme(decimal bakiye, decimal cekilecekmiktar)
        {
            if (cekilecekmiktar > bakiye)
            {
                Console.WriteLine("Çekmek İstediğiniz Miktar Hesabınızda Bulunmamaktadır...");
            }
            else
            {
                System.Threading.Thread.Sleep(2000);
                bakiye = bakiye - cekilecekmiktar;
                Console.Write("İstenilen Miktar Başarılı Bir Şekilde Çekilmiştir");
            }
            return bakiye;
        }
        public static decimal parayatırma(decimal bakiye, decimal yatacakmiktar)
        {
            System.Threading.Thread.Sleep(2000);
            bakiye = bakiye + yatacakmiktar;
            Console.WriteLine("İşleminiz Başarılı Bir Şekilde Gerçekleşmiştir\nYeni Bakiyenizi Görmek İster Misiniz?(E/H)");
            string sorgutekrar = Console.ReadLine();
            sorgutekrar = sorgutekrar.ToUpper();
            if (sorgutekrar == "E")
            {
                bakiyesorgu(bakiye);
            }
            return bakiye;
        }
    }
}
