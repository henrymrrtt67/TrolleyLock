using System.Security.Cryptography.X509Certificates;
using TrolleyLockAPI.Objects;

namespace TrolleyLockAPI.DummyData
{
    public class TrolleyDummyData
    {

        public IEnumerable<Trolley> Trolleys() 
        {   
            Random random = new Random();

            return new List<Trolley>()
                {
                    new Trolley
                    {
                        TrolleyId = new Guid(),
                        StoreId   = random.Next(10)
                    },
                    new Trolley
                    {
                        TrolleyId = new Guid(),
                        StoreId   = random.Next(10)
                    },
                    new Trolley
                    {
                        TrolleyId = new Guid(),
                        StoreId   = random.Next(10)
                    },
                    new Trolley
                    {
                        TrolleyId = new Guid(),
                        StoreId   = random.Next(10)
                    },
                    new Trolley
                    {
                        TrolleyId = new Guid(),
                        StoreId   = random.Next(10)
                    },
                    new Trolley
                    {
                        TrolleyId = new Guid(),
                        StoreId   = random.Next(10)
                    },
                    new Trolley
                    {
                        TrolleyId = new Guid(),
                        StoreId   = random.Next(10)
                    },
                    new Trolley
                    {
                        TrolleyId = new Guid(),
                        StoreId   = random.Next(10)
                    },
                    new Trolley
                    {
                        TrolleyId = new Guid(),
                        StoreId   = random.Next(10)
                    },
                    new Trolley
                    {
                        TrolleyId = new Guid(),
                        StoreId   = random.Next(10)
                    },
                    new Trolley
                    {
                        TrolleyId = new Guid(),
                        StoreId   = random.Next(10)
                    },
                    new Trolley
                    {
                        TrolleyId = new Guid(),
                        StoreId   = random.Next(10)
                    },
                    new Trolley
                    {
                        TrolleyId = new Guid(),
                        StoreId   = random.Next(10)
                    },
                    new Trolley
                    {
                        TrolleyId = new Guid(),
                        StoreId   = random.Next(10)
                    },
                    new Trolley
                    {
                        TrolleyId = new Guid(),
                        StoreId   = random.Next(10)
                    },
                    new Trolley
                    {
                        TrolleyId = new Guid(),
                        StoreId   = random.Next(10)
                    },
                    new Trolley
                    {
                        TrolleyId = new Guid(),
                        StoreId   = random.Next(10)
                    },
                    new Trolley
                    {
                        TrolleyId = new Guid(),
                        StoreId   = random.Next(10)
                    },
                    new Trolley
                    {
                        TrolleyId = new Guid(),
                        StoreId   = random.Next(10)
                    },
                    new Trolley
                    {
                        TrolleyId = new Guid(),
                        StoreId   = random.Next(10)
                    },
                    new Trolley
                    {
                        TrolleyId = new Guid(),
                        StoreId   = random.Next(10)
                    },
                    new Trolley
                    {
                        TrolleyId = new Guid(),
                        StoreId   = random.Next(10)
                    },
                    new Trolley
                    {
                        TrolleyId = new Guid(),
                        StoreId   = random.Next(10)
                    },
                    new Trolley
                    {
                        TrolleyId = new Guid(),
                        StoreId   = random.Next(10)
                    },
                    new Trolley
                    {
                        TrolleyId = new Guid(),
                        StoreId   = random.Next(10)
                    },
                    new Trolley
                    {
                        TrolleyId = new Guid(),
                        StoreId   = random.Next(10)
                    },
                    new Trolley
                    {
                        TrolleyId = new Guid(),
                        StoreId   = random.Next(10)
                    }
                };
        
        }

    }
}
