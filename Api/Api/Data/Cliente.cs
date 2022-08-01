using System.ComponentModel.DataAnnotations;

namespace Api.Data
{
    public class Cliente
    {
        [Key]
        public int IdCliente { get; set; }
        public string NomeCompleto { get; set; }

        public string Email { get; set; }

        public string Cpf { get; set; }
    }
}
