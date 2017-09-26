using PANCodingExercise.Data.Domain;
using PANCodingExercise.Services.Contracts;
using System.Web.Http;

namespace PANCodingExercise.Api.Controllers
{
    /// <summary>
    /// Controller for url: api/item/
    /// </summary>
    public class ItemController : ApiController
    {
        private readonly IItemService _itemService;

        /// <summary>
        /// We are injecting 'ItemService' dependency into our api controller.
        /// </summary>
        /// <param name="itemService">Service responsible for implementing our requirements</param>
        public ItemController(IItemService itemService)
        {
            this._itemService = itemService;
        }

        /// <summary>
        /// Returns a list of items
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("api/item/")]
        public IHttpActionResult All()
        {
            var list = this._itemService.GetAll();

            return Json(new { items = list });
        }

        /// <summary>
        /// Add item to database
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Id of the added entity</returns>
        [HttpPost]
        [Route("api/item/add")]
        public IHttpActionResult Add(Item entity)
        {
            var id = this._itemService.Add(entity);

            return Json(new { key = id });
        }

        [HttpGet]
        [Route("api/item/get/{id}")]
        public IHttpActionResult Get(int id)
        {
            var entity = this._itemService.Get(id);

            return Json(new { item = entity });
        }

        /// <summary>
        /// Update item to the database
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("api/item/update")]
        public IHttpActionResult Update(Item item)
        {
            if (this._itemService.Update(item) < 0)
                return Json(new { error = $"Failed to update item with id: {item.Id} in the item table." });

            return Json(new { key = item.Id });
        }
    }
}
