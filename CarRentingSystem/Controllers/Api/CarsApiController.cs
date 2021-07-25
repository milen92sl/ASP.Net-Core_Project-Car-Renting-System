namespace CarRentingSystem.Controllers.Api
{
    using CarRentingSystem.Models.Api.Cars;
    using CarRentingSystem.Services.Cars;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    [Route("api/cars")]
    public class CarsApiController : ControllerBase
    {
        private readonly ICarService cars;

        public CarsApiController(ICarService cars) => this.cars = cars;

        //  [Route("details")] ==> /api/cars/details

        [HttpGet]
        public CarQueryServiceModel All([FromQuery] AllCarsApiRequestModel query)
        {
            return cars.All(
                query.Brand,
                query.SearchTerm,
                query.Sorting,
                query.CurrentPage,
                query.CarsPerPage);
        }
    }
}
