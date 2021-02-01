using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle (Musteri musteri)
        {
            Console.WriteLine(musteri.Adı+" "+musteri.Soyadı+" "+"Adlı Müşteri Sisteme Eklendi!");
        }
     
        public void Silme (Musteri musteri)
        {
            Console.WriteLine(musteri.Adı+" "+musteri.Soyadı+" "+"Adlı Müşteri Sistemden Silindi!");
        }
        public void Listele(Musteri[] musteriler)
        {
            foreach (var musteri in musteriler)
            {

                Console.WriteLine(musteri.Id + " " + musteri.Adı + " " + musteri.Soyadı + " " + musteri.TcKimlikNo);
            }

        }
    }
}
