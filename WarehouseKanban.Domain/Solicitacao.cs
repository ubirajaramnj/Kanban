using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseKanban.Domain
{
    public class Solicitacao
    {
        public int Id { get; set; } //Número da Solicitação de Reposição (2017000001)
        public virtual Ordem Ordem { get; set; }
        public virtual Centro Centro { get; set; }
        public virtual Posto Posto { get; set; }

        public virtual ItemDePosto Item { get; set; }

        public DateTime DataDaSolicitacao { get; set; }
        public string SolicitadoPor { get; set; }

        public string Status { get; set; }
        public string Baixado { get; set; }
        public string Entregue { get; set; }
        public string Pendente { get; set; }
        public string Separado { get; set; }

        public DateTime DataDaModificacao { get; set; }
        public string ModificadoPor { get; set; }

        public string Endereco { get; set; }

        public string CentroDeCustoOuOm { get; set; } //Tipo de Movimento

    }
}
