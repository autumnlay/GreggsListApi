using System.ComponentModel.DataAnnotations;

namespace GreggsListApi.Models
{
    public class Car
    {
        public string? Id { get; set; }
        [Range(1950, 2025)]
        public int Year { get; set; }
        [Range(1, int.MaxValue)]
        public int Price { get; set; }
        [Required]
        public string? Make { get; set; }
        [Required]
        public string? Model { get; set; }
        [Required]
        public string? Color { get; set; }
        [Required]
        public string? Description { get; set; }
        public string imgURL { get; set; }

        public Car(int year, int price, string make, string model, string color, string description, string? imgURL)
        {
            Id = Guid.NewGuid().ToString();
            Year = year;
            Price = price;
            Make = make;
            Model = model;
            Color = color;
            Description = description;
            this.imgURL = imgURL;
        }
    }
}