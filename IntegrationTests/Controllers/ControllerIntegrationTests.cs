


using CarDealership;
using System.Net.Http;
using System.Threading.Tasks;
using Web.Api.IntegrationTests;
using Xunit;
using Xunit.Abstractions;

namespace IntegrationTests
{
    public class ControllerIntegrationTests : IClassFixture<CustomWebApplicationFactory<Startup>> 
    {

        //==================================================NOTICE=======================================================
        // If the data you are testing  for doesn't exist in the database, add them as needed.
        // Ensure that all of your tests are passing, and that interactions between two or more tests do not cause a fail
        //===============================================================================================================

        private readonly HttpClient _client;
        private readonly ITestOutputHelper _output;

        public ControllerIntegrationTests(CustomWebApplicationFactory<Startup> factory, ITestOutputHelper output)
        {
            //Create a the client to handle HTTP requests.
            _client = factory.CreateClient();

            //Helpers
            _output = output;
        }


        [Fact]
        public async Task GetAllCars()
        {
            // The endpoint or route of the controller action.
            var httpResponse = await _client.GetAsync("/Cars");

            // Must be successful.
            httpResponse.EnsureSuccessStatusCode();

            //Deserialize result

            //Assert
        }



        //Create a car and assert that it exists in the DB

        //Retrieve all values of a car by its ID

        //Update (patch) the model of a specific car by its Id and assert that the update was successful

        //Update (put) all properties of a single car by its Id and assert

        //Delete a car and assert that it was deleted


        //Get all cars with MilePerGallon in between 150 to 300 and assert that each fall within this range


        //Get all Mustang cars and assert that each car is of this model


        //Get all cars that are 2 years or older


    }
}
