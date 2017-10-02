using System.Collections.Generic;

namespace WarehouseKanban.Domain
{
    public class Item
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Codigo { get; set; }
        public string Descricao { get; set; }
        public string CodigoSap { get; set; }
        public string UnidadeDeMedida { get; set; }

        public virtual List<Attachiment> Attachiments { get; set; }
    }
}