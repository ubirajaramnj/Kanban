namespace WarehouseKanban.Domain
{
    public class ItemDePosto : Item
    {
        public string CodigoDeBarras { get; set; }
        public string QuantidadeDeReposicao { get; set; }
        public string QuantidadeMinima { get; set; }
        public string QuantidadeMaxima { get; set; }
    }
}