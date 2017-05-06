using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DRGGTLib.DarkOrbit
{
    public class Item
    {
        public enum TipoDeItem
        {
            battery,
            rocket,
            part,
            ore,
            nanohull,
            voucher,
            logfile,
            multiplier
        }

        public string Descricao { get; protected set; }
        public TipoDeItem Tipo { get; set; }
        public int IdItem { get; set; }
        public int NumeroGiros { get; set; }
        public int Quantidade { get; set; }
        public DateTime Data { get; set; }

        public Item(){}
        public Item(int tipo, int idItem, int numeroGiros, int quantidade, long data)
        {
            Tipo = (TipoDeItem)tipo;
            IdItem = idItem;
            NumeroGiros = numeroGiros;
            Quantidade = quantidade;
            // Não é bem assim que funciona.
            Data = new DateTime(data);
            Parse();
        }

        private void Parse()
        {
            string tipo;
            if (Tipo == TipoDeItem.battery)
            {
                tipo = ((Municoes)IdItem).ToString();
                Descricao = $"{Quantidade} {tipo}";
            }
            else if (Tipo == TipoDeItem.rocket)
            {
                tipo = ((Misseis)IdItem).ToString();
                Descricao = $"{Quantidade} {tipo}";
            }
            else if (Tipo == TipoDeItem.ore)
            {
                tipo = ((Recurso)IdItem).ToString();
                Descricao = $"{Quantidade} {tipo}";
            }
            else if (Tipo == TipoDeItem.nanohull)
            {
                Descricao = $"{Quantidade} bônus de blindagem";
            }
            else if (Tipo == TipoDeItem.voucher)
            {
                Descricao = $"{Quantidade} bônus de reparo";
            }
            else if (Tipo == TipoDeItem.logfile)
            {
                Descricao = $"{Quantidade} arquivo(s) log";
            }
            else if (Tipo == TipoDeItem.multiplier)
            {
                Descricao = $"{Quantidade} multiplicador(es)";
            }
        }
    }
}
