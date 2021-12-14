using GreggsListApi.DB;
using GreggsListApi.Models;

namespace GreggsListApi.Services
{
    public class CarsService
    {
        internal List<Car> Get()
        {
            return FakeDB.Cars;
        }
    }
}