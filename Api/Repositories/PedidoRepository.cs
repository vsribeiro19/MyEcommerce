using Api.Data;
using Dapper;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Repositories
{
    public class PedidoRepository : IPedidoRepository
    {
        private IDbSession _db;
        public PedidoRepository(IDbSession dbSession)
        {
            _db = dbSession;
        }
        public async Task<List<Pedido>> GetPedidoAsync()
        {
            using (var conn = _db.Connection)
            {
                string query = "SELECT ite.descricao,pe.* FROM pedido pe INNER JOIN item ite on ite.idItem = pe.idItem";
                List<Pedido> pedidos = (await conn.QueryAsync<Pedido>(sql: query)).ToList();
                return pedidos;
            }
        }

        public async Task<Pedido> GetPedidoByIdAsync(int id)
        {
            using (var conn = _db.Connection)
            {
                string query = "SELECT * FROM pedido WHERE idPedido = @id";
                Pedido pedido = await conn.QueryFirstOrDefaultAsync<Pedido>
                    (sql: query, param: new { id });
                return pedido;
            }
        }

        public Task<int> SaveAsync(Pedido novoPedido)
        {
            throw new System.NotImplementedException();
        }

        public Task<int> UpdatePedidoStatusAsync(Pedido atualizaPedido)
        {
            throw new System.NotImplementedException();
        }

        public Task<int> DeleteAsync(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
