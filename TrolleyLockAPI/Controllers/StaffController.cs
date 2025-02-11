using Microsoft.AspNetCore.Mvc;
using TrolleyLockAPI.DummyData;
using TrolleyLockAPI.Objects;

namespace TrolleyLockAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class StaffController
    {
        CompanyDummyData CompanyData = new CompanyDummyData();
        StoreDummyData StoreData = new StoreDummyData();
        RoleDummyData RoleData = new RoleDummyData();
        StaffDummyData StaffData = new StaffDummyData();

        [HttpGet]
        public IEnumerable<Staff> GetStaffByCompany(string companyName)
        {
            var companyId = CompanyData.Companies().FirstOrDefault(c => c.CompanyName == companyName).CompanyId;
            var stores = StoreData.Stores().Select(st => st).Where(st => st.CompanyId == companyId);
            var storeIDs = stores.Select(st => st.StoreId);
            return StaffData.StaffData.Select(s => s).Where(s => storeIDs.Contains(s.StoreId));
        }

        [HttpGet]
        public Staff GetStaffByStaffName(string firstName, string lastName)
        {
            return StaffData.StaffData.FirstOrDefault(st => st.FirstName == firstName && st.LastName == lastName);
        }

        [HttpGet]
        public IEnumerable<Staff> GetStaffByStore(string storeName)
        {
            var storeId = StoreData.Stores().FirstOrDefault(st => st.StoreName == storeName).StoreId;
            return StaffData.StaffData.Select(s => s).Where(s => s.StoreId == storeId);
        }

        [HttpGet]
        public IEnumerable<Staff> GetStaffByRole(string roleDescription)
        {
            var roleId = RoleData.Roles().FirstOrDefault(c => c.RoleDescription == roleDescription).RoleId;
            return StaffData.StaffData.Select(st => st).Where(st => st.RoleId == roleId);
        }

    }
}
