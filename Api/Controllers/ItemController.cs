using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Api.Data;
using Api.Repositories;

namespace Api.Controllers
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
        [Route("getAllItems")]
        public async Task<IActionResult> GetItensAsync()
        {
            var result = await _itemRepo.GetItemAsync();
            return Ok(result);
        }
        [HttpGet]
        [Route("getById")]
        public async Task<IActionResult> GetTodoItemByIdAsync(int id)
        {
            var item = await _itemRepo.GetItemByIdAsync(id);
            return Ok(item);
        }
        [HttpPost]
        [Route("create")]
        public async Task<IActionResult> SaveAsync(Item novoItem)
        {
            var result = await _itemRepo.SaveAsync(novoItem);
            return Ok(result);
        }
        [HttpPut]
        [Route("update")]
        public async Task<IActionResult> UpdateTodoStatusAsync(Item atualizaItem)
        {
            var result = await _itemRepo.UpdateItemStatusAsync(atualizaItem);
            return Ok(result);
        }
        [HttpDelete]
        [Route("delete")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            var resultado = await _itemRepo.DeleteAsync(id);
            return Ok(resultado);
        }
    }
}