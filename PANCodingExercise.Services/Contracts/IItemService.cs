using PANCodingExercise.Data.Domain;
using System.Collections.Generic;

namespace PANCodingExercise.Services.Contracts
{
    /// <summary>
    /// Requirements:
    ///     1. Get a list of items
    ///     2. Get a single item
    ///     3. Save Items
    ///     4. Update Items
    /// </summary>
    public interface IItemService
    {
        List<Item> GetAll();
        Item Get(int id);
        int Add(Item entity);
        int Update(Item entity);
    }
}
