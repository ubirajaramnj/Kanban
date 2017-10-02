using System;
using System.Collections.Generic;

namespace WarehouseKanban.Domain
{
    public class Posto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Codigo { get; set; }
        public string Descricao { get; set; }

        public DateTime DataDaInauguracao { get; set; }
        public DateTime DataDeCriacao { get; set; }
        public string CriadoPor { get; set; }

        public string Custeio { get; set; }
        public string Cc { get; set; }

        public virtual List<ItemDePosto> Itens { get; set; }
    }
}