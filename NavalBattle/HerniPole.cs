using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavalBattle
{
    class HerniPole
    {
        private byte height;
        private byte width;
        private List<Lod> lode = new List<Lod>();
        public List<Policko> policka { private set; public get; }

        public HerniPole()
        {
            policka = new List<Policko>();
        }

        public HerniPole(byte height = 10, byte width = 10)    
        {
            policka = new List<Policko>();
            this.height = height;
            this.width = width;
            for (byte i = 0; i < height; i++)
                for (byte j = 0; j < width; j++)
                    policka.Add(new Policko(j, i));
        }

        public bool UmistiLod(byte indexLode, Souradnice referencniBod)
        {
            foreach(Policko pole in policka)
            {
                if (pole.JeSoucastLodi <= 0) { return true; }
            } return false;
        }

        public void PridejLod(Lod NovaLod)
        {
            lode.Add(NovaLod);
        }

        public byte Height
        {
            get
            {
                return height;
            }
        }

        public byte Width
        {
            get
            {
                return width;
            }
        }

        public Policko GetPolickoXY(byte x, byte y)
        {
            int indexPolicka = y * width + x;
            return policka[indexPolicka];
        }

        public void Rozmisteni()
        {

        }
    }
}