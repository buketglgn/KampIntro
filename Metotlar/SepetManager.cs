using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        //burada sepete ürün ekleme işlemi yapabiliriz. (metod)
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Tebrikler.Sepete eklendi!: "+urun.Adi+ " stok adedi gösteriliyor "+ urun.StokAdedi);
            
        }

        public void Ekle2(string ad, string aciklama, int fiyat)
        {
            Console.WriteLine("eklendi-2:"+ad);
        }
    }
}
