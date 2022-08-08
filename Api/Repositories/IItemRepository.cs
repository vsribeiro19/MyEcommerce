using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Data;

namespace Api.Repositories
{
    public interface IItemRepository
    {
        Task<List<Item>> GetItemAsync();
        Task<Item> GetItemByIdAsync(int id);
        //Task<ItemContainer> GetItemsEContadorAsync();
        Task<int> SaveAsync(Item novoItem);
        Task<int> UpdateItemStatusAsync(Item atualizaItem);
        Task<int> DeleteAsync(int id);
    }
}
