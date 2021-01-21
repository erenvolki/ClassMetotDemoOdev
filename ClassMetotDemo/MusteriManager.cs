using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Listele(Musteri[] musteriler)
        {
            Console.WriteLine("Müşteriler Listeleniyor....");
            Console.WriteLine();

            Console.WriteLine("ID" + "---" + "AD" + "--------" + "SOYAD" + "------" + "TCKN" + "---" + "HESAPNO");
            Console.WriteLine();

            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.Id + "--" + musteri.Adi + "---" + musteri.Soyadi + "--" + musteri.TCKN + "--" + musteri.HesapNo);

            }
            Console.WriteLine("*********************************************");
           
        }
        public void Ekle(Musteri musteri)
        {

            Console.WriteLine(musteri.Id + " -- " + musteri.Adi + " -- " + musteri.Soyadi + " -- " + musteri.TCKN + " -- " + musteri.HesapNo);
            Console.WriteLine();
            Console.WriteLine("Müşteri başarıyla eklendi");
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------");

        }
        public void Sil(Musteri musteri)
        {
            Console.WriteLine(musteri.Id + " " + musteri.Adi + " " + musteri.Soyadi);
            Console.WriteLine();
            Console.WriteLine("Müşteri başarıyla silindi");
        }
    }
}
