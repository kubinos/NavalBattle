using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavalBattle
{
    class Lod
    {
        private Typ typLodi;
        private int rotaceLodi;
        private Souradnice referencniBod;
        private List<bool> sestreleneSoucasti; 

        public Lod(Typ typLodi, Souradnice referencniBod, int rotaceLodi)
        {
            sestreleneSoucasti = new List<bool>();
            for (int i = 0; i < typLodi.souradnice.Count; i++)
            {
                sestreleneSoucasti.Add(false);
            }
            this.typLodi = typLodi;
            this.referencniBod = referencniBod;
            this.rotaceLodi = rotaceLodi;
        }        
    }
}