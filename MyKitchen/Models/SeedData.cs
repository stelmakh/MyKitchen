using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MyKitchen.Data;
using System;
using System.Linq;

namespace MyKitchen.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MyKitchenContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MyKitchenContext>>()))
            {
                if (context.Product.Any())
                {
                    return;
                }

                context.Product.AddRange(
                    new Product
                    {
                        Name = "Dark Chocolate",
                        Carbs = 46.36f,
                        Fats = 43.06f,
                        Protein = 7.87f,
                        Calories = 60f
                    },
                    new Product
                    {
                        Name = "Milk",
                        Carbs = 5f,
                        Fats = 1f,
                        Protein = 3.4f,
                        Calories = 642f
                    },
                    new Product
                    {
                        Name = "Tomatoes, red",
                        Carbs = 3.9f,
                        Fats = 0.2f,
                        Protein = 0.9f,
                        Calories = 18f
                    },
                    new Product
                    {
                        Name = "Onion",
                        Carbs = 9f,
                        Fats = 0.1f,
                        Protein = 1.1f,
                        Calories = 40f
                    }
                );
                context.SaveChanges();
            }
        }
    }
}