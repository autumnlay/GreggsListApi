using GreggsListApi.Models;
using GreggsListApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace GreggsListApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CarsController : ControllerBase
    {
        // REVIEW what is this privat and public thing doing??
        private readonly CarsService _cs;
        public CarsController(CarsService cs)
        {
            _cs = cs;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Car>> Get()
        {
            try
            {
                // REVIEW what is this line saying and linking to?? 
                //what is the _cs refering to??
                List<Car> cars = _cs.Get();
                return Ok(cars);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}