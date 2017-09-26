using PANCodingExercise.Data.Contracts;
using PANCodingExercise.Data.Domain;
using PANCodingExercise.Services.Contracts;
using System.Collections.Generic;
using System.Linq;

namespace PANCodingExercise.Services
{
    public class ItemService : IItemService
    {
        private readonly IRepository<Item> _itemRepository;

        public ItemService(IRepository<Item> itemRepository)
        {
            this._itemRepository = itemRepository;
        }

        public List<Data.Domain.Item> GetAll()
        {
            return this._itemRepository.Table.ToList();
        }

        public Data.Domain.Item Get(int id)
        {
            return this._itemRepository.GetById(id);
        }

        public int Add(Item entity)
        {
            this._itemRepository.Insert(entity);

            return entity.Id;
        }

        public int Update(Item entity)
        {
            var item = Get(entity.Id);
            if (item != null)
            {
                item.Name = entity.Name;
                item.DisplayName = entity.DisplayName;
                item.Description = entity.Description;

                this._itemRepository.Update(item);
                return item.Id;
            }
            return -1; 
        }
    }
}
