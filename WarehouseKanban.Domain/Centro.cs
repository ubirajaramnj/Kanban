using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseKanban.Domain
{
    public class Centro
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Codigo { get; set; }
        public string Descricao { get; set; }
        public virtual List<Area> Areas { get; set; }
        public virtual List<Deposito> Depositos { get; set; }
    }
}
