using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavalBattle
{
    class Hra
    {
        private Dictionary<Typ, int> PoctyLodi = new Dictionary<Typ, int>();

        public void PridatTypLodi(Typ typLodi, int pocetLodíKPridani)
        {
            PoctyLodi.Add(typLodi, pocetLodíKPridani);
        }

    }
}