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


            dbContext.SaveChanges();
        }
    }
}