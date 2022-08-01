using System.ComponentModel.DataAnnotations;

namespace Api.Data
{
    public class Item
    {
        [Key]
        public int IdItem { get; set; }
        public string DescricaoItem { get; set; }
        public int QtdItem { get; set; }
        public double Valor { get; set; }

        public int IdCliente { get; set; }
        public Item(Cliente cliente)
        {
            this.IdCliente = IdCliente;
        }
    }
}
