using System;
namespace MyKitchen.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Carbs { get; set; }
        public float Fats { get; set; }
        public float Protein { get; set; }
        public float Calories { get; set; }
    }
}
