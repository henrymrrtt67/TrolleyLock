using TrolleyLockAPI.Objects;

namespace TrolleyLockAPI.DummyData
{
    public class CompanyDummyData
    {
        public IEnumerable<Company> Companies()
        {
            return new List<Company> {
                new Company
                {
                    CompanyId = 1,
                    CompanyName = "Woolworths"
                },
                new Company
                {
                    CompanyId = 2,
                    CompanyName = "Coles"
                }
            };
        }

    }
}
