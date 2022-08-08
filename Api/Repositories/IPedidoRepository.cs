using Api.Data;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Api.Repositories
{
    public interface IPedidoRepository
    {
        Task<List<Pedido>> GetPedidoAsync();
        Task<Pedido> GetPedidoByIdAsync(int id);
        Task<int> SaveAsync(Pedido novoPedido);
        Task<int> UpdatePedidoStatusAsync(Pedido atualizaPedido);
        Task<int> DeleteAsync(int id);
    }
}
