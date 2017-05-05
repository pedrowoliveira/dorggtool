using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DRGGTLib.DarkOrbit
{
    class Conta
    {   
        public string Usuario { get; private set; }
        public string Senha { get; private set; }

        public int IdUsuario { get; private set; }
        public string IdSessao { get; private set; }

        public int Uridium { get; set; }
        public int EnergiasExtra { get; set; }

        public Conta(){}
        public Conta(string usuario, string senha)
        {
            Usuario = usuario;
            Senha = senha;
        }
    }
}
