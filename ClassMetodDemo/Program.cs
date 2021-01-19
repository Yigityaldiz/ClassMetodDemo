using System;

namespace ClassMetodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Adi = "Kaan";
            musteri1.Soyadi = "kopru";
            musteri1.Id = 1238765;

            Musteri musteri2 = new Musteri();
            musteri2.Adi = "Emin";
            musteri2.Soyadi = "Albaysöken";
            musteri2.Id = 3234565;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };

            MusteriManager.Ekle(musteri2);
            MusteriManager.Sil(musteri1);
            MusteriManager.Listele(musteriler);
        }
        
    }
}
