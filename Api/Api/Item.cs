using Api.Model;

namespace Api
{
    public class Item
    {
        //[Key]
        public int IdItem { get; set; }
        public string DescricaoItem { get; set; }
        public int QtdItem { get; set; }
        public double Valor { get; set; }

        public int IdCliente { get; set; }
        public Item(Cliente cliente)
        {
            IdCliente = IdCliente;
        }
    }
}
