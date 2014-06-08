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
        HerniPole MojeHerniPole = new HerniPole();
        HerniPole SouperovoHerniPole = new HerniPole();

        public void PridatTypLodi(Typ typLodi, int pocetLodíKPridani)
        {
            PoctyLodi.Add(typLodi, pocetLodíKPridani);
        }

        public void PridatLod()
        {
            MojeHerniPole.PridejLod();
        }

        public HerniPole UpravMojeHerniPole
        {
            get
            {
                return MojeHerniPole;
            }
            set
            {
                MojeHerniPole = value;
            }
        }

        public HerniPole GetSouperovoHerniPole
        {
            get
            {
                return SouperovoHerniPole;
            }
        }
    }
}