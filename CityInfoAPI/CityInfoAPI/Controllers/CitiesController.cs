using Microsoft.AspNetCore.Mvc;

namespace CityInfoAPI.Controllers
{
    [ApiController] //not required but this configs the controllers with features that improve development experience
    [Route("api/cities")]
    public class CitiesController : ControllerBase
    {
        [HttpGet]
        public JsonResult GetCities()
        {
            return new JsonResult(
                new List<object>
                {
                    new { id =  1, Name = "New York City" },
                    new { id = 2, Name = "Antwerp"}
                });
        }
    }
}
