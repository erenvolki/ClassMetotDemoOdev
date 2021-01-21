using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();

            musteri1.Id = 1;
            musteri1.Adi = "Gürsoy";
            musteri1.Soyadi = "KIZILDAĞ";
            musteri1.TCKN = "11111111111";
            musteri1.HesapNo = 100;

            Musteri musteri2 = new Musteri();

            musteri2.Id = 2;
            musteri2.Adi = "İsmail";
            musteri2.Soyadi = "AKSOY";
            musteri2.TCKN = "22222222222";
            musteri2.HesapNo = 200;

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.Adi = "Burcu";
            musteri3.Soyadi = "GÜNEŞ";
            musteri3.TCKN = "33333333333";
            musteri3.HesapNo = 300;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };


            MusteriManager musteriManager = new MusteriManager();


            musteriManager.Ekle(musteri1);
            musteriManager.Listele(musteriler);
            musteriManager.Sil(musteri2);

        }
    }
}
