using WebApplication1.Data;
using Dapper;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace WebApplication1.Repositories
{
    public class ItemRepository : IItemRepository
    {
        private IDbSession _db;
        public ItemRepository(IDbSession dbSession)
        {
            _db = dbSession;
        }
        public async Task<List<Item>> GetItemAsync()
        {
            using (var conn = _db.Connection)
            {
                string query = "SELECT * FROM item";
                List<Item> itens = (await conn.QueryAsync<Item>(sql: query)).ToList();
                return itens;
            }
        }
        public async Task<Item> GetItemByIdAsync(int id)
        {
            using (var conn = _db.Connection)
            {
                string query = "SELECT * FROM Tarefas WHERE Id = @id";
                Item item = await conn.QueryFirstOrDefaultAsync<Item>
                    (sql: query, param: new { id });
                return item;
            }
        }
        public async Task<ItemContainer> GetItemsEContadorAsync()
        {
            using (var conn = _db.Connection)
            {
                string query =
                    @"SELECT COUNT(*) FROM item
    	          SELECT * FROM Items";
                var reader = await conn.QueryMultipleAsync(sql: query);
                return new ItemContainer
                {
                    Contador = (await reader.ReadAsync<int>()).FirstOrDefault(),
                    Itens = (await reader.ReadAsync<Item>()).ToList()
                };
            }
        }
        public async Task<int> SaveAsync(Item novoItem)
        {
            using (var conn = _db.Connection)
            {
                string command = @"NSERT INTO item(descricao, valor, qtdItem)
    		VALUES(@descricao, @valor, @qtdItem)";
                var result = await conn.ExecuteAsync(sql: command, param: novoItem);
                return result;
            }
        }
        public async Task<int> UpdateItemStatusAsync(Item atualizaItem)
        {
            using (var conn = _db.Connection)
            {
                string command = @"
    		     UPDATE item SET descricao = @descricao WHERE IdItem = @idItem";
                var result = await conn.ExecuteAsync(sql: command, param: atualizaItem);
                return result;
            }
        }
        public async Task<int> DeleteAsync(int id)
        {
            using (var conn = _db.Connection)
            {
                string command = @"DELETE FROM item WHERE IdItem = @id";
                var resultado = await conn.ExecuteAsync(sql: command, param: new { id });
                return resultado;
            }
        }
    }
}
