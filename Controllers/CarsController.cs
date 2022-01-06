using GreggsListApi.Models;
using GreggsListApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace GreggsListApi.Controllers
{
    [ApiController]

    //REVIEW how will i know what goes into the controller part? where is that coming from?
    [Route("api/[controller]")]
    //the carsController is the name of the api/___
    public class CarsController : ControllerBase
    {
        // REVIEW what is this private and public thing doing??
        // This is an import ->
        //It is also "blocking" the data, extra protection
        //_cs is a variable now declared by CarService like string str
        private readonly CarsService _cs;
        // This is the constructor
        public CarsController(CarsService cs)
        {
            //re-defining the cs, now calling it _cs
            _cs = cs;
        }

        [HttpGet]
        // REVIEW why does this next part vary in each method? What is each saying?
        public ActionResult<IEnumerable<Car>> Get()
        //IEnumerable returning a collection of items
        //I is an interface
        // ActionResult<IEnumerable<Car>> this is what is being expected to return
        {
            try
            {
                // REVIEW what is this line saying and linking to?? 
                //what is the _cs refering to??
                //C# is reading 
                // define it, what of, then vaiable
                List<Car> cars = _cs.Get();
                return Ok(cars);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet("{id}")]

        public ActionResult<Car> Get(string id)
        // ActionResult<Car> this is what I'm expecting to return
        {
            try
            {
                // REVIEW what is this part doing/saying??
                // Car model, go to service, run .get method
                // vaiable car is a type Car that is how you return that variable as well
                Car car = _cs.Get(id);
                return Ok(car);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}