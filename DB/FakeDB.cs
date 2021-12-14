using GreggsListApi.Models;

namespace GreggsListApi.DB
{
    public static class FakeDB
    {
        public static List<Car>? Cars { get; set; } = new List<Car>(){
            new Car(2009, 2000, "Toyota", "Tachoma", "Green", "It looks new", "img"),
            new Car(1998, 5000, "Ford", "F150", "White", "Its on its last wheel", "img"),
            new Car(2021, 14000, "NewPlace", "New Car", "Orange", "Its like brand brand new","https://ichef.bbci.co.uk/news/1024/branded_news/9942/production/_119143293_flying-car.jpg")
        };
    }
}