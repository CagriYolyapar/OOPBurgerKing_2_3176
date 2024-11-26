using OOPBurgerKing_2.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBurgerKing_2.Models
{
    public class Siparis : BaseEntity
    {
        public Siparis(string ad)
        {
            Ad = ad;
            Malzemeleri = new List<EkstraMalzeme>();
            
        }
        public HamburgerMenusu SecilenMenu { get; set; }
        public int Adet { get; set; }
        public Boyut Buyuklugu { get; set; }
        public List<EkstraMalzeme> Malzemeleri { get; set; } //Burada Array yerine List kullanma nedenimiz ilgilendigimzi property'nin icerisine alacagı elemanların sayısının degişebilir olmasıdır...Yani buradaki koleksiyon fixed degildir...Eger Array kullansaydık bu array sürekli modifiye edilmek zorunda kalacak ve hem sisteme hem de bize yük cıkaracktır...List bizi bu durumdan kurtarır...

        public void TutarHesapla()
        {
            Fiyat = SecilenMenu.Fiyat; //Siparişimiz bir HamburgerMenusu tipindeki Property'si aracılıgı ile kullanıcı tarafından secilen menünün fiyatına ulasıp kendi Fiyat'ına önce o secilen menünün fiyatının atanmasını saglıyor...Yani TutarHesapla metodu calıstıgında ilk görev SecilenMenu'nun Fiyat property'sinin Sipar'in Fiyat property'sine atanması olacak...
            switch (Buyuklugu)
            {
               
                case Boyut.Orta:
                    Fiyat += 1;
                    break;
                case Boyut.Buyuk:
                    Fiyat += 2;
                    break;
                
            }

            foreach (EkstraMalzeme item in Malzemeleri)
            {

                Fiyat += item.Fiyat;
            }

            Fiyat *= Adet; //Fiyat = Fiyat * Adet;


        }


        public override string ToString()
        {
            if (Malzemeleri.Count < 1)
            {
                //Eger kullanıcı malzeme secmemişse bu malzemeler yazılmadan direkt menü yazdırılsın istiyoruz...
                return $"{Ad} kisisine : {SecilenMenu.Ad} Menüsü, X {Adet}, {Buyuklugu} boy, Toplam : {Fiyat:C2}";
            }

            //Kullanıcının sectigi malzemelerin isimlerini de göstermek istiyoruz...
            string malzemesi = null;

            //Döngümüz buradaki koleksiyondaki malzemelerin isimlerini yakalayarak yukarıdaki metinsel tipteki degişkenimize atacak...
            foreach (EkstraMalzeme item in Malzemeleri)
            {
                //Her gelen item bir EkstraMalzeme tipindedir
                malzemesi += $"{item.Ad},";
            }

            malzemesi = malzemesi.TrimEnd(','); //TrimEnd metodu bir metnin sonundaki bir karakteri silmekle görevlidir

            return $"{Ad} kisisine : {SecilenMenu.Ad} Menüsü, X {Adet}, {Buyuklugu} boy,Malzemeleri : ({malzemesi}) Toplam : {Fiyat:C2}";


        }
    }
}
