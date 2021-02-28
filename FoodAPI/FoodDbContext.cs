using FoodDataApp.Core;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodAPI
{
    public class FoodDbContext : DbContext
    {
        public DbSet<Food> Foods { get; set; }

        public FoodDbContext(DbContextOptions<FoodDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Food>().HasData(
                new
                {
                    FoodId = 1,
                    Name = "APPLE",
                    Description = "This is an apple",
                    Calories = 95.0,
                    Fat = 0.3,
                    Cholestrol = 0.0,
                    Sodium = 1.8,
                    Potassium = 195.0,
                    Carbohydrates = 25.0,
                    Protein = 0.5,
                    Vitamin = "A",
                    Image = "https://www.busybeecandles.co.uk/wp-content/uploads/2013/08/apple-benefits32.jpg"
                },
                new
                {
                    FoodId = 2,
                    Name = "BANANA",
                    Description = "This is an apple",
                    Calories = 95.0,
                    Fat = 0.3,
                    Cholestrol = 0.0,
                    Sodium = 1.8,
                    Potassium = 195.0,
                    Carbohydrates = 25.0,
                    Protein = 0.5,
                    Vitamin = "B",
                    Image = "https://assets.vogue.com/photos/5deec371e52fbd00086eb68b/16:9/w_2959,h_1664,c_limit/promo-banana.jpg"
                },
                new
                {
                    FoodId = 3,
                    Name = "PEAR",
                    Description = "This is an apple",
                    Calories = 95.0,
                    Fat = 0.3,
                    Cholestrol = 0.0,
                    Sodium = 1.8,
                    Potassium = 195.0,
                    Carbohydrates = 25.0,
                    Protein = 0.5,
                    Vitamin = "C",
                    Image = "https://5.imimg.com/data5/KA/KH/MY-22541476/stark-crimson-pears-500x500.jpg"
                }
                );
        }
    }
}
