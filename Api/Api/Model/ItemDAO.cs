using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;

namespace Api.Model
{
    public class ItemDAO
    {
        private IConfiguration _configuracoes;
        public ItemDAO(IConfiguration config)
        {
            _configuracoes = config;
        }

        public IEnumerable<Item> FindAll()
        {
            using (SqlConnection conexao = new SqlConnection(
                _configuracoes.GetConnectionString("myecommerce")))
            {
                return conexao.Query<Item>("SELECT * FROM item");
            }
        }

        public Item FindById(int idItem)
        {
            using (SqlConnection conexao = new SqlConnection(
                _configuracoes.GetConnectionString("myecommerce")))
            {
                return conexao.QueryFirstOrDefault<Item>(
                    "SELECT idItem, descricaoItem, qtdItem, valor from dbo.item WHERE idItem = @IdItem",
                new { IdItem = idItem });
            }
        }
    }
}
