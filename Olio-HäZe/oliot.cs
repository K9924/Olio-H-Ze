using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{

    class Radio
    {
        private float kanava = 0;
        private int vola = 0;

       
        // alustetaan kanava stringi
        public float Kanava
        {
            get
            {
                return kanava;
            }
            set
            {
                kanava = value;
                if(kanava < 2000.0 || kanava > 26000.0)
                {
                    kanava = 2000;
                }
            }
        }

        // alustetaan inti vola
        public int Vola
        {
            get
            {
                return vola;
            }

            set
            {
                vola = value;
                if(vola < 1 || vola > 9)
                {
                    vola = 1;
                }
            }
        }

        public override string ToString()
        {
            return "kanava = " + Kanava + ", Vola = " + vola;
        }
    }
}