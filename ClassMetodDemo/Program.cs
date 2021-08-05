using System;

namespace ClassMetodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri = new Musteri();
            musteri.Id = 1;
            musteri.FirstName = "Mervenur";
            musteri.LastName = "Karakaya";
            MusteriManager musteriManager = new MusteriManager();
            musteriManager.musteriEkle(musteri);
            musteriManager.musteriListele(musteri);
            musteriManager.musteriSil(musteri);
        }
    }
}
