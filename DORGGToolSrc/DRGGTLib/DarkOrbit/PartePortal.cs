using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DRGGTLib.DarkOrbit
{
    public class PartePortal : Item
    {
        public Portais Portal { get; set; }
        public int QuantidadeDePartesAtual { get; set; }
        public int QuantidadeDePartesTotal { get; set; }
        public int IdParte { get; set; }
        public bool Duplicada { get; set; }
        public bool Completo { get; set; } = false;

        public PartePortal(){}
        public PartePortal(long data, int portal, int qntAtual, int qntTotal, int idParte, bool duplicada = false)
        {
            Tipo = TipoDeItem.part;
            Quantidade = 1;
            Portal = (Portais)portal;
            QuantidadeDePartesAtual = qntAtual;
            QuantidadeDePartesTotal = qntTotal;
            IdParte = idParte;
            Duplicada = duplicada;  
            Completo = (qntTotal == qntAtual) ? true : false;
            Parse();            
        }

        public PartePortal(int portal, int idParte, bool duplicada = true)
        {
            Tipo = TipoDeItem.part;
            Quantidade = 1;
            Portal = (Portais)portal;
            IdParte = idParte;
            Duplicada = duplicada;
            Parse();
        }

        public void Parse()
        {
            if(!Duplicada)
            { 
                Descricao = $"{(Completo == true ? "[Completo] " :  "")}Parte {IdParte} do Portal {Portal}";
            }
            else
            {
                Descricao = $"[Duplicada] Parte {IdParte} do Portal {Portal}";
            }
        } 
    }
}
