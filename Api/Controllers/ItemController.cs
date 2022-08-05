using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using WebApplication1.Data;
using WebApplication1.Repositories;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : Controller
    {
        private readonly IItemRepository _itemRepo;
        public ItemController(IItemRepository itemRepo)
        {
            _itemRepo = itemRepo;
        }
        [HttpGet]
        [Route("itens")]
        public async Task<IActionResult> GetItensAsync()
        {
            var result = await _itemRepo.GetItemAsync();
            return Ok(result);
        }
        [HttpGet]
        [Route("item")]
        public async Task<IActionResult> GetTodoItemByIdAsync(int id)
        {
            var item = await _itemRepo.GetItemByIdAsync(id);
            return Ok(item);
        }
        [HttpGet]
        [Route("itenscontador")]
        public async Task<IActionResult> GetTodosAndCountAsync()
        {
            var resultado = await _itemRepo.GetItemsEContadorAsync();
            return Ok(resultado);
        }
        [HttpPost]
        [Route("criaritem")]
        public async Task<IActionResult> SaveAsync(Item novoItem)
        {
            var result = await _itemRepo.SaveAsync(novoItem);
            return Ok(result);
        }
        [HttpPost]
        [Route("atualizastatus")]
        public async Task<IActionResult> UpdateTodoStatusAsync(Item atualizaItem)
        {
            var result = await _itemRepo.UpdateItemStatusAsync(atualizaItem);
            return Ok(result);
        }
        [HttpDelete]
        [Route("deletaitem")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            var resultado = await _itemRepo.DeleteAsync(id);
            return Ok(resultado);
        }
    }
}
