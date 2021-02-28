using FoodDataApp.Core;
using FoodDataApp.Server.Services;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodDataApp.Server.Pages
{
    public class FoodDetailBase : ComponentBase
    {
        [Inject]
        public IFoodDataService FoodDataService { get; set; }
        public IEnumerable<Food> Foods { get; set; }
        
        public Food Food { get; set; } = new Food();
        [Parameter]
        public string FoodId { get; set; }
        protected async override Task OnInitializedAsync()
        {
            Foods = (await FoodDataService.GetAllFood()).ToList();
            Food = Foods.FirstOrDefault(f => f.FoodId == int.Parse(FoodId));
       
        }
      

        

    }
}
