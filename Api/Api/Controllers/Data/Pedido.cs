namespace Api.Controllers.Data
{
    public class Pedido
    {
        public int IdPedido { get; set; }
        public string DescricaoPedido { get; set; }

        public double ValorTotal { get; set; }

        public int IdItem { get; set; }

        public int IdCliente { get; set; }

        public Pedido(Item item)
        {
            this.IdItem = IdItem;
            this.IdCliente = IdCliente;
        }
    }
}
