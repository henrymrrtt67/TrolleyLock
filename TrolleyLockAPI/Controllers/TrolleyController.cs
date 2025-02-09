using Microsoft.AspNetCore.Mvc;
using TrolleyLockAPI.DummyData;
using TrolleyLockAPI.Objects;

namespace TrolleyLockAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class TrolleyController : ControllerBase
    {
        private TrolleyDummyData trolleyDummyData = new TrolleyDummyData();

        [HttpGet]
        public IEnumerable<Trolley> GetTrolleys()
        {
            //return JSON content
            return trolleyDummyData.Trolleys();
        }

        [HttpGet]
        public IEnumerable<Trolley> GetTrolleysByStore(int storeId)
        {
            IList<Trolley> trolleys = trolleyDummyData.Trolleys().ToList();

            return trolleys.Select(t => t).Where(t => t.StoreId == storeId);

        }

        [HttpPut]
        //Soft Delete trolley, keep in the system in case the trolley can be retrieved.
        public bool RemoveTrolleyFromStore(Guid trolleyId)
        {
            IList<Trolley> trolleys = trolleyDummyData.Trolleys().ToList();
            Trolley currentTrolley = trolleys.FirstOrDefault(t => t.TrolleyId == trolleyId);
            if (currentTrolley is not null)
            {
                currentTrolley.StoreId = null;
                return true;
            }
            return false;
        }
    }
}
