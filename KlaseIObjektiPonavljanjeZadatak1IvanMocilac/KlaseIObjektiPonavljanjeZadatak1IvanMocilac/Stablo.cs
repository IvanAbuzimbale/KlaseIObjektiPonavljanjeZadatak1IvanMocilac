using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlaseIObjektiPonavljanjeZadatak1IvanMocilac
{
    class Stablo : Biljka
    {
        bool opadajuListovi;

        public bool OpadajuListovi
        {
            get => opadajuListovi;
            set => opadajuListovi = value;
        }

        public Stablo(bool opadajuListovi)
        {
            this.opadajuListovi = opadajuListovi;
        }
    }
}
