using TrolleyLockAPI.Objects;

namespace TrolleyLockAPI.DummyData
{
    public class RoleDummyData
    {
        public IEnumerable<Role> Roles()
        {
            return new List<Role>
            {
                new Role
                {
                    RoleId = 1,
                    RoleDescription = "Employee"
                },
                new Role
                {
                    RoleId = 2,
                    RoleDescription = "Manager"
                },
                new Role
                {
                    RoleId = 3,
                    RoleDescription = "Owner"
                }
            };
        }

    }
}
