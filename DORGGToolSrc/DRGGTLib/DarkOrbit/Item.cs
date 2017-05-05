using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DRGGTLib.DarkOrbit
{
    class Item
    {
        public enum TipoDeItem
        {
            battery,
            rocket,
            part,
            ore,
            nanohull,
            voucher,
            logfile
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
            Data = new DateTime(data);
            Parse();
        }

        private void Parse()
        {
            if (Tipo == TipoDeItem.battery)
            {
                string calibre = "";
                if (IdItem == 2)
                {
                    calibre = "MCB-25";
                }
                else if (IdItem == 3)
                {
                    calibre = "MCB-50";
                }
                else if (IdItem == 4)
                {
                    calibre = "UCB-100";
                }
                else if (IdItem == 5)
                {
                    calibre = "SAB";
                }
                else
                {
                    calibre = "???";
                }
                Descricao = $"{Quantidade} {calibre}";
            }
            else if (Tipo == TipoDeItem.rocket)
            {
                string calibre = "";
                if (IdItem == 11)
                {
                    calibre = "ACM-01";
                }
                else if (IdItem == 3)
                {
                    calibre = "PLT-2021";
                }
                Descricao = $"{Quantidade} {calibre}";
            }
            else if (Tipo == TipoDeItem.ore)
            {
                Descricao = $"{Quantidade} xenomit";
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
            Descricao += $" em {NumeroGiros} giros";
        }
    }
}
