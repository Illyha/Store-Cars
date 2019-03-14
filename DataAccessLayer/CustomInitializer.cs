using System.Data.Entity;

namespace DataAccessLayer
{
    internal class CustomInitializer<T> : DropCreateDatabaseAlways<ConcreteMarket>
    {
        protected override void Seed(ConcreteMarket context)
        {
            var con1 = new Country { Name = "UK" };
            var con2 = new Country { Name = "Italy" };
            var con3 = new Country { Name = "Germany" };
            var con4 = new Country { Name = "USA" };

            var pr1 = new Producer
            {
                Name = "Aston Martin",
                Country = con1,
            };
            var pr2 = new Producer
            {
                Name = "Bentley Motors",
                Country = con1,
            };
            var pr3 = new Producer
            {
                Name = "Ferrari",
                Country = con2,
            };
            var pr4 = new Producer
            {
                Name = "Lamborghini",
                Country = con2,
            };
            var pr5 = new Producer
            {
                Name = "Mercedes-Benz",
                Country = con3,
            };
            var pr6 = new Producer
            {
                Name = "BMW",
                Country = con3,
            };
            var pr7 = new Producer
            {
                Name = "GMC",
                Country = con4,
            };
            var pr8 = new Producer
            {
                Name = "Dodge",
                Country = con4,
            };

            var ctr1 = new Concrete { Mark = "2000",Producer=pr1 };
            var ctr2 = new Concrete { Mark = "1500", Producer = pr4 };
            var ctr3 = new Concrete { Mark = "257", Producer = pr3 };
            var ctr4 = new Concrete { Mark = "500", Producer = pr1 };
            var ctr5 = new Concrete { Mark = "1000", Producer = pr2 };
            var ctr6 = new Concrete { Mark = "4", Producer = pr5 };
            var ctr7 = new Concrete { Mark = "64", Producer = pr1 };
            var ctr8 = new Concrete { Mark = "100", Producer = pr7 };
            var ctr9 = new Concrete { Mark = "500", Producer = pr8 };
            var ctr10 = new Concrete { Mark = "257", Producer = pr3 };
            var ctr11= new Concrete { Mark = "257", Producer = pr6 };
            var ctr12 = new Concrete { Mark = "100", Producer = pr8 };
            var ctr13 = new Concrete { Mark = "122", Producer = pr1 };
            var ctr14 = new Concrete { Mark = "10", Producer = pr4 };
            var ctr15 = new Concrete { Mark = "64", Producer = pr8 };
            var ctr16 = new Concrete { Mark = "1000", Producer = pr3 };
            var ctr17 = new Concrete { Mark = "500", Producer = pr7 };
            var ctr18 = new Concrete { Mark = "4", Producer = pr8 };
            var ctr19 = new Concrete { Mark = "4", Producer = pr5 };
            var ctr20 = new Concrete { Mark = "500", Producer = pr2 };


            context.Concretes.AddRange(new Concrete[] { ctr1,ctr2,ctr3,ctr4,ctr5,ctr6,ctr7,ctr8,ctr9,ctr10,ctr11,ctr12,ctr13,ctr14,ctr15,ctr16,ctr17,ctr18,ctr19,ctr20});

            context.SaveChanges();
        }
    }
}