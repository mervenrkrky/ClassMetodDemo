using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetodDemo
{
    class MusteriManager
    {
        public void musteriEkle(Musteri musteri)
        {
            Console.WriteLine( musteri.FirstName +" adlı müşteri eklendi");
        }

        public void musteriListele(Musteri musteri)
        {
            Console.WriteLine(musteri.LastName+ " soyadlı muşteri listelendi");
        }

        public void musteriSil(Musteri musteri)
        {
            Console.WriteLine(musteri.FirstName + " adlı musteri silindi");
        }
    }
}
