using FoodDataApp.Core;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodDataApp.Server.Pages
{
    public class FoodOverviewBase : ComponentBase
    {
        public IEnumerable<Food> Foods { get; set; }
        private List<Vitamin> Vitamins { get; set; }
        public Food Food { get; set; } = new Food();
        public string SearchTerm { get; set; }
        protected override Task OnInitializedAsync()
        {
            InitializeVitamins();

            return base.OnInitializedAsync();
        }
        private void InitializeVitamins()
        {
            Vitamins = new List<Vitamin>()
            {
                new Vitamin{VitaminId=1, Name="A"},
                new Vitamin{VitaminId=2, Name="B"},
                new Vitamin{VitaminId=3, Name="C"},
                new Vitamin{VitaminId=4, Name="D"},
            };
        }

        private void InitializeFoods()
        {
            var f1 = new Food
            {
                FoodId = 1,
                Name = "APPLE",
                Calories = 95,
                Fat = 0.3,
                Cholestrol = 0,
                Sodium = 1.8,
                Potassium = 195,
                Carbohydrates = 25,
                Protein = 0.5,
                VitaminId = 1,
                Image= "https://www.busybeecandles.co.uk/wp-content/uploads/2013/08/apple-benefits32.jpg"
            };
            var f2 = new Food
            {
                FoodId = 2,
                Name = "BANANA",
                Calories = 95,
                Fat = 0.3,
                Cholestrol = 0,
                Sodium = 1.8,
                Potassium = 195,
                Carbohydrates = 25,
                Protein = 0.5,
                VitaminId = 1,
                Image = "https://assets.vogue.com/photos/5deec371e52fbd00086eb68b/16:9/w_2959,h_1664,c_limit/promo-banana.jpg"
            };
            var f3 = new Food
            {
                FoodId = 3,
                Name = "PEAR",
                Calories = 95,
                Fat = 0.3,
                Cholestrol = 0,
                Sodium = 1.8,
                Potassium = 195,
                Carbohydrates = 25,
                Protein = 0.5,
                VitaminId = 1,
                Image= "https://5.imimg.com/data5/KA/KH/MY-22541476/stark-crimson-pears-500x500.jpg"
            };
            Foods = new List<Food>() { f1, f2, f3 };
        }

        public void OnGet()
        {
            InitializeFoods();
            Food = Foods.FirstOrDefault(f => f.Name == SearchTerm.ToUpper());
        }
    }
}
