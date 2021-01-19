using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetodDemo
{
    class MusteriManager
    {
        public static void Ekle(Musteri musteri)

        {
            Console.WriteLine("Musteri eklendi:" + musteri.Adi + " \t " + musteri.Soyadi);
        }

        public static void Sil(Musteri musteri)   
        {
            Console.WriteLine("Musteri silindi:" + musteri.Adi + " \t " + musteri.Soyadi);
        }
        
        public static void Listele(Musteri[] musteri)

        {
            Console.WriteLine("Musteri Listesi:\n ");
           foreach( Musteri musterilerlist in musteri  )
           {
                Console.WriteLine(musterilerlist.Adi + "\t"+         musterilerlist.Soyadi +"\t"+                 musterilerlist.Id);
           }
        }

    }
}
