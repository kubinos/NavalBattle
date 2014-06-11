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
        public List<Lod> lode = new List<Lod>();
        public List<Policko> policka = new List<Policko>();

        public HerniPole(byte height = 10, byte width = 10)    
        {
            this.height = height;
            this.width = width;
            for (byte i = 0; i < height; i++)
                for (byte j = 0; j < width; j++)
                    policka.Add(new Policko(j, i));
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