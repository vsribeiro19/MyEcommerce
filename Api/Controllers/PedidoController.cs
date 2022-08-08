using Api.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PedidoController : Controller
    {
        private readonly IPedidoRepository _pedidoRepo;
        public PedidoController(IPedidoRepository pedidoRepo)
        {
            _pedidoRepo = pedidoRepo;
        }
        [HttpGet]
        [Route("getAllPedidos")]
        public async Task<IActionResult> GetPedidosAsync()
        {
            var result = await _pedidoRepo.GetPedidoAsync();
            return Ok(result);
        }

        [HttpGet]
        [Route("getById")]
        public async Task<IActionResult> GetTodoPedidoByIdAsync(int id)
        {
            var pedido = await _pedidoRepo.GetPedidoByIdAsync(id);
            return Ok(pedido);
        }
    }
}
