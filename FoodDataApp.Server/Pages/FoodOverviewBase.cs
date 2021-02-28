using FoodDataApp.Core;
using FoodDataApp.Server.Services;
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
        [Inject]
        public IFoodDataService FoodDataService { get; set; }
        public List<Food> Foods { get; set; }
       
        public Food Food { get; set; } = new Food();
        public string SearchTerm { get; set; }
        protected override async Task OnInitializedAsync()
        {
            Foods = (await FoodDataService.GetAllFood()).ToList();
        }
   
        public void OnGet()
        {
   
            Food = Foods.FirstOrDefault(f => f.Name == SearchTerm.ToUpper());
        }
    }
}
