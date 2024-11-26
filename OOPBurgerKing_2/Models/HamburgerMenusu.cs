using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OOPBurgerKing_2.Models
{
    public class HamburgerMenusu : BaseEntity
    {
        public string Aciklama { get; set; }

      

        public override string ToString()
        {
            return $"{Ad} => {Fiyat:C2}"; //Fiyat: C2 ifadesi Fiyat property'sinin yanında işletim sisteminizin nation'ina göre döziv işareti cıkmasını saglar...Decimal'in özelligidir...
        }
    }
}
