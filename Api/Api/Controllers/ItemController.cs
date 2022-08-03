using Microsoft.AspNetCore.Mvc;
using Api.Model;
using System;
using Microsoft.Extensions.Logging;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    public class ItemController : Controller
    {
        //ItemDAO itemDAO;
        //[HttpGet]
        //public IActionResult ListAllItens()
        //{
        //    try
        //    {
        //        //retornar uma lista (IEnumerable)

        //        //return Ok(data);
        //    }
        //    catch (Exception)
        //    {
        //        Console.WriteLine("Erro ao tentar obter dados");
        //        return new StatusCodeResult(500);
        //    }
        //}

        [HttpGet("{id}")]
        public Item Get(
            [FromServices] ItemDAO itensDAO,
            int id)
        {
            return itensDAO.FindById(id);
        }
    }
}
