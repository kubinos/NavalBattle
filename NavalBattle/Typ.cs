using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavalBattle
{
    class Typ
    {
        private string nazevTypuLodi;
        public List<Souradnice> souradnice = new List<Souradnice>();

        public Typ()
        {
            nazevTypuLodi = "Ponorka";
            souradnice.Add(new Souradnice(1,1));
        }

        /*public Typ(string nazevTypuLodi, List<Souradnice> souradnice)
        {
            this.nazevTypuLodi = nazevTypuLodi;
            this.souradnice = souradnice;
        }*/
    }
}
