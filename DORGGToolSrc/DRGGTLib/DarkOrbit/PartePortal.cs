using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DRGGTLib.DarkOrbit
{
    class PartePortal : Item
    {
        public Portais Portal { get; set; }
        public int QuantidadeDePartesAtual { get; set; }
        public int QuantidadeDePartesTotal { get; set; }
        public int IdParte { get; set; }
        public bool Completo { get; set; } = false;

        public PartePortal(){}
        public PartePortal(int tipo, int idItem, int numeroGiros, int quantidade, long data, int portal, int qntAtual, int qntTotal, int idParte) : base(tipo, idItem, numeroGiros, quantidade, data)
        {
            if(Tipo != TipoDeItem.part)
            {
                throw new ArgumentOutOfRangeException("tipo", "Não é possível instanciar um item comum como parte de portal.");
            }
            else
            {
                Portal = (Portais)portal;
                QuantidadeDePartesAtual = qntAtual;
                QuantidadeDePartesTotal = qntTotal;
                IdParte = idParte;
                Completo = (qntTotal == qntAtual) ? true : false;
            }
        }

        public void Parse()
        {
            Descricao = $"{(Completo == true ? "[Completo]" :  "")} Parte {IdParte} do Portal {Portal}";
        } 
    }
}
