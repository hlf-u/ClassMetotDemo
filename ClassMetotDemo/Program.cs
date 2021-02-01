using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Adı = "Halef";
            musteri1.Soyadı = "Uludağ";
            musteri1.TcKimlikNo = 100001;

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Adı = "Kasım";
            musteri2.Soyadı = "Uludağ";
            musteri2.TcKimlikNo = 200002;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };

            

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Silme(musteri2);
            musteriManager.Listele(musteriler);

        }
    }
}
