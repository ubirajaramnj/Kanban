using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseKanban.Domain
{
    public class Deposito
    {
        public string Id { get; set; }
        public virtual List<Posto> Postos { get; set; }
    }
}
