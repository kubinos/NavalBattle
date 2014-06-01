using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavalBattle
{
    class Policko
    {
        private Lod lod;
        private int soucastLodi;
        private bool jeObjeveno;
        private bool jeLod;

        public Policko()
        {
            this.lod = null;
            this.soucastLodi = -1;
        }

        public Policko(Lod lod, int soucastLodi)
        {
            this.lod = lod;
            this.soucastLodi = soucastLodi;
        }

        public int JeSoucastLodi
        {
            get
            {
                return soucastLodi;
            }
            set
            {
                soucastLodi = value;
            }
        }

        public bool JeObjeveno
        {
            get
            {
                return jeObjeveno;
            }
            set
            {
                jeObjeveno = value;
            }
        }

        public bool JeLod
        {
            get
            {
                return jeLod;
            }
            set
            {
                jeLod = value;
            }
        }

        public Lod Lod
        {
            get
            {
                return lod;
            }
            set
            {
                lod = value;
            }
        }
    }
}
