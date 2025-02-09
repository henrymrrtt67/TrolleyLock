using TrolleyLockAPI.Objects;

namespace TrolleyLockAPI.DummyData
{
    public class StoreDummyData
    {
        public IEnumerable<Store> Stores()
        {
            return new List<Store>()
            {
                new Store (){
                    StoreId = 1,
                    StoreName = "Store 1",
                    StreetAddress = "7/30 Lawrence Dr",
                    Suburb = "Gold Coast City",
                    City = "Gold Coast City",
                    State = "Queensland",
                    PostCode = "4211",
                    Country = "Australia"
                },
                new Store (){
                    StoreId = 2,
                    StoreName = "Store 2",
                    StreetAddress = "316 Maroondah Hwy",
                    Suburb = "Melbourne",
                    City = "Melbourne",
                    State = "Victoria",
                    PostCode = "3777",
                    Country = "Australia"
                },
                new Store (){
                    StoreId = 3,
                    StoreName = "Store 3",
                    StreetAddress = "65 Georges River Rd",
                    Suburb = "Sydney",
                    City = "Sydney",
                    State = "New South Wales",
                    PostCode = "2133",
                    Country = "Australia"
                },
                new Store (){
                    StoreId = 4,
                    StoreName = "Store 4",
                    StreetAddress = "88 The Grand Parade",
                    Suburb = "Sydney",
                    City = "Sydney",
                    State = "New South Wales",
                    PostCode = "2216",
                    Country = "Australia"
                },
                new Store (){
                   StoreId = 5,
                   StoreName = "Store 5",
                   StreetAddress = "25 Lennox St",
                   Suburb = "Melbourne",
                   City = "Melbourne",
                   State = "Victoria",
                   PostCode = "3121",
                   Country = "Australia"
                },
                new Store (){
                    StoreId = 6,
                    StoreName = "Store 6",
                    StreetAddress = "32 Erin St",
                    Suburb = "Melbourne",
                    City = "Melbourne",
                    State = "Victoria",
                    PostCode = "3121",
                    Country = "Australia"
                },
                new Store (){
                    StoreId = 7,
                    StoreName = "Store 7",
                    StreetAddress = "1/99 Devonshire St",
                    Suburb = "Sydney",
                    City = "Sydney",
                    State = "New South Wales",
                    PostCode = "2010",
                    Country = "Australia"
                },
                new Store (){
                    StoreId = 8,
                    StoreName = "Store 8",
                    StreetAddress = "254-256 Parramatta Rd",
                    Suburb = "Sydney",
                    City = "Sydney",
                    State = "New South Wales",
                    PostCode = "2048",
                    Country = "Australia"
                },
                new Store (){
                    StoreId = 9,
                    StoreName = "Store 9",
                    StreetAddress = "g2/624 George St",
                    Suburb = "Sydney",
                    City = "Sydney",
                    State = "New South Wales",
                    PostCode = "2000",
                    Country = "Australia"
                },
                new Store (){
                    StoreId = 10,
                    StoreName = "Store 10",
                    StreetAddress = "14 The Link",
                    Suburb = "Melbourne",
                    City = "Melbourne",
                    State = "Victoria",
                    PostCode = "3032",
                    Country = "Australia"
                }
            };
        }
    }
}    
