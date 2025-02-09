using Microsoft.AspNetCore.Mvc;
using TrolleyLockAPI.DummyData;
using TrolleyLockAPI.Objects;

namespace TrolleyLockAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class StoreController : ControllerBase
    {
        private StoreDummyData storeData = new StoreDummyData();

        [HttpGet]
        public IEnumerable<Store> GetStores()
        {
            return storeData.Stores();
        }

        [HttpGet]
        public Store GetStoreById (int storeId)
        {
            return storeData.Stores().FirstOrDefault(s => s.StoreId == storeId) ?? null;
        }
    }
}
