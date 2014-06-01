﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavalBattle
{
    class Hra
    {
        private byte height;
        private byte width;
        private List<Lod> lode = new List<Lod>();
        private List<Policko> policko = new List<Policko>();

        public Hra(byte height = 10, byte width = 10)    
        {
            this.height = height;
            this.width = width;
            for (int i = 0; i < height*width; i++)
                policko.Add(new Policko());
        }

        public void pridejLod(Lod NovaLod)
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
            return policko[indexPolicka];
        }

        public void Rozmisteni()
        {

        }
    }
}
