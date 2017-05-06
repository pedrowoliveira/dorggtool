using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DRGGTLib.DarkOrbit
{
    public class Multiplicador
    {
        public Portais Portal { get; set; }
        public int Fator { get; set; }
        public bool Ativo { get; set; }

        public Multiplicador(){}
        public Multiplicador(int portal, int fator, bool ativo)
        {
            Portal = (Portais)portal;
            Fator = fator;
            Ativo = ativo;
        }
    }
}
