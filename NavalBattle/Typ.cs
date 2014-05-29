using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavalBattle
{
    class Typ
    {
        private string typLodi;
        private string[] pozice;

        public void Typ(string typLodi, string[] pozice)
        {
            this.typLodi = typLodi;
            this.pozice = pozice;
        }

        public string[] Pozice
        {
            get
            {
                return pozice;
            }
            set
            {
                
            }
        }

        public string TypLodi
        {
            get
            {
                return typLodi;
            }
            set
            {

            }
        }

    }
}
