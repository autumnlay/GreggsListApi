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
        //returning Car, its expecting that later as well
        internal Car Get(string id)
        {
            //REVIEW so... is this a lot like how we used find it in Node?
            Car found = FakeDB.Cars.Find(c => c.Id == id);
            if (found == null)
            {
                throw new Exception("Invalid Id");
            }
            return found;
        }

    }
}