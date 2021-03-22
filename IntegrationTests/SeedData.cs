using CarDealership.Models;
using CarDealership.Repositories;
using System;


namespace Web.Api.IntegrationTests
{
    public static class SeedData
    {
        public static void PopulateTestData(DealershipContext dbContext)
        {
            //Seed your data as needed.


            dbContext.Cars.Add(new Car() { Make = "Test1", Model = "Genesis", Year = 2014, Price = 35000, Horsepower = 333, BodyStyle = BodyStyles.Coupe, TransmissionType = TransmissionTypes.Manual });
            dbContext.Cars.Add(new Car() { Make = "Test2", Model = "Quest", Year = 2008, Price = 6000, Horsepower = 235, BodyStyle = BodyStyles.Minivan, TransmissionType = TransmissionTypes.Automatic });
            dbContext.Cars.Add(new Car() { Make = "Test3", Model = "QX60", Year = 2016, Price = 26500, Horsepower = 295, BodyStyle = BodyStyles.SUV, TransmissionType = TransmissionTypes.CVT });
            dbContext.Cars.Add(new Car() { Make = "Test4", Model = "Mustang", Year = 2015, Price = 18500, Horsepower = 300, BodyStyle = BodyStyles.Coupe, TransmissionType = TransmissionTypes.Automatic });
            dbContext.Cars.Add(new Car() { Make = "Test5", Model = "Corolla", Year = 2017, Price = 13500, Horsepower = 132, BodyStyle = BodyStyles.Sedan, TransmissionType = TransmissionTypes.Automatic });
            dbContext.Cars.Add(new Car() { Make = "Test6", Model = "F-150", Year = 2021, Price = 75945, Horsepower = 430, BodyStyle = BodyStyles.PickupTruck, TransmissionType = TransmissionTypes.Automatic });

            dbContext.SaveChanges();
        }
    }
}