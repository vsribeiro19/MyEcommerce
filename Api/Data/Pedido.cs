namespace Api.Data
{
    public class Pedido
    {
        public int IdPedido { get; set; }
        public int IdItem { get; set; }
        public int IdCliente { get; set; }
        public Item DescricaoPedido { get; set; }

        public decimal TotalCompra { get; set; }

        public string NomeComprador { get; set; }

        public string Cpf { get; set; }

        public string Email { get; set; }
    }
}
