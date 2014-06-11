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

        public void PridatLod(Typ typLodi, int x, int y)
        {
            //PoctyLodi.Add(typLodi, pocetLodíKPridani);
        }

        public void PridatMojiLod(Typ typLodi, Souradnice souradniceLodi, int rotace)
        {
            MojeHerniPole.lode.Add(new Lod(typLodi, souradniceLodi, rotace));
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