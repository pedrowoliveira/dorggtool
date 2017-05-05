using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DRGGTLib.DarkOrbit
{
    class Giro
    {
        // Do giro
        public List<Item> Itens { get; set; }
        public Portais Portal { get; set; }
        public int CustoGiro { get; set; }
        public int NumeroDeGiros { get; set; }
        public List<Multiplicador> Multiplicadores { get; private set; }

        // Promocões?
        public bool EmPromocao { get; set; }
        public double FatorDeDesconto { get; set; }
        public bool RecompensaEmDobro { get; set; }
        public bool DiaDeKronos { get; set; }

        // Da conta
        public int Uridium { get; set; }
        public int EnergiasExtra { get; set; }

        public Giro(){}
        public Giro(int portal, int numeroDeGiros, List<Multiplicador> multiplicadores = null, bool emPromocao = false, double fatorDeDesconto = 0.0, bool recompensaEmDobro = false, bool diaDeKronos = false)
        {
            Portal = (Portais)portal;
            NumeroDeGiros = numeroDeGiros;
            Multiplicadores = multiplicadores;
            EmPromocao = emPromocao;
            FatorDeDesconto = fatorDeDesconto;
            RecompensaEmDobro = recompensaEmDobro;
            DiaDeKronos = diaDeKronos;
        }

        public void AdicionarItens(List<Item> itens)
        {
            foreach (var item in itens)
            {
                AdicionarItem(item);
            }
        }
        public void AdicionarItem(Item item)
        {
            Itens.Add(item);
        }
    }
}
