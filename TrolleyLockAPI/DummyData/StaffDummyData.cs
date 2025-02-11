using TrolleyLockAPI.Objects;

namespace TrolleyLockAPI.DummyData
{
    public class StaffDummyData
    {
        public IEnumerable<Staff> StaffData = CreateDummyData();

        private static IEnumerable<Staff> CreateDummyData()
        {
            int dataSize = 50;
            Random random = new Random();
            var staffList = new List<Staff>();

            for (int iteration = 0; iteration < dataSize; iteration++)
            {
                staffList.Add(new Staff
                {
                    StaffId = iteration,
                    FirstName = "Test",
                    LastName = $"Name: {iteration}",
                    StoreId = random.Next(10),
                    RoleId = random.Next(3)
                });
            }

            return staffList;
        }
    }
}
