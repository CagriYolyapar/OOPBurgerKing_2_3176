using OOPBurgerKing_2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPBurgerKing_2
{
    public partial class Form1 : Form
    {

        /*
                    Tag Property'si

        İstisnasız her kontrolün bir Tag Property'si vardır...Bu Property kontrollere özgü özel bir veri saklamak istediginizde cok işinize yarar...
         
         
         
         
         */
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Object Initializer yontemi ile instance almak...
            //HamburgerMenusu hb = new HamburgerMenusu()
            //{
            //    Ad = "Deneme"
            //};


            //Hamburger Menüleri listemizi object Initializer yontemi ile ekliyoruz

            List<HamburgerMenusu> menuler = new List<HamburgerMenusu>
            {
                new HamburgerMenusu{ Ad = "Texas Smokehouse",Fiyat = 15,Aciklama = "Gurme menusunden enfes bir lezzet"},
                new HamburgerMenusu{ Ad = "Barbekü Brioche",Fiyat = 20,Aciklama = "Barbekülü bir Meksika ateşine hazır mısınız?"},
                new HamburgerMenusu{ Ad = "Crispy Chicken",Fiyat = 30.5M,Aciklama = "Tavuklar cıldırdı"},
                new HamburgerMenusu{ Ad = "Steakhouse",Fiyat = 50,Aciklama = "O kadar begeneceksiniz ki daha fazla ödemek isteyeceksiniz"},
                new HamburgerMenusu{ Ad = "TenderCrisp",Fiyat = 15,Aciklama = "Hem cıtırı hem acıyı bal eyledik karsınıza sunduk"},

            };

            //foreach (HamburgerMenusu item in menuler)
            //{
            //    CmbMenuler.Items.Add(item);
            //}


            CmbMenuler.DataSource = menuler;
            CmbMenuler.SelectedIndex = -1;
           
        }

        private void CmbMenuler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbMenuler.SelectedItem != null)
                LblAciklama.Text = (CmbMenuler.SelectedItem as HamburgerMenusu).Aciklama;

            else LblAciklama.Text = "";
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            if(CmbMenuler.SelectedItem == null)
            {
                MessageBox.Show("Lutfen bir menü seciniz");
                return;
            }

            Siparis s = new Siparis(TxtIsim.Text);

            s.SecilenMenu = CmbMenuler.SelectedItem as HamburgerMenusu;
            s.Adet = Convert.ToInt32(NmrAdet.Value);

            if (RdbBuyuk.Checked) s.Buyuklugu = Enums.Boyut.Buyuk;
            else if (RdbOrta.Checked) s.Buyuklugu = Enums.Boyut.Orta;

            //Unutmayın ki foreach döngü mekanizması döngü parantezleri icerisinde implicit cast yapabilme özelligine sahiptir...Eger casting'te hata almayacagınız bir durum söz konusu ise(mesela mevcut durumda sadece CheckBox vardır dolayısıyla hata alınmaz) rahatca bu implicit casting'i kullanabilirsiniz.

            foreach (CheckBox item in groupBox1.Controls)
            {
                if (item.Checked)
                {
                    EkstraMalzeme eks = new EkstraMalzeme(); //EkstraMalzeme sınıfının instance'ini aldık...
                    eks.Ad = item.Text;
                    eks.Fiyat = Convert.ToDecimal(item.Tag); //Fiyatı checkbox kontrolünün Tag Property'sinden aldık...Tag özelligi bir kontrolün icerisinde istedigimiz tipte (object tipte deger aldıgı icin) deger tutmamızı saglar...O kontrolün deger tasıyabilecegi özel bir alanı olarak düsünebilirsiniz...Ancak object oldugu icin boxing ve unboxing olayını unutmamamız gerekir...
                    s.Malzemeleri.Add(eks);
                    
                    
                }
            }

            s.TutarHesapla(); //Siparişin tutarının hesaplanması icin bunu yapmalısınız...Yoksa hesaplanmaz...

            LstSiparisler.Items.Add(s);
        }

        private void BtnCiro_Click(object sender, EventArgs e)
        {
            decimal tutar = 0;

            foreach (Siparis item in LstSiparisler.Items)
            {
                tutar += item.Fiyat;
            }

            MessageBox.Show(tutar.ToString());

        }
    }
}
