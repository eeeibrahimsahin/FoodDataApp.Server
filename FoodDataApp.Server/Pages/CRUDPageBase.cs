using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodDataApp.Server.Pages
{
    public class CRUDPageBase : ComponentBase
    {
        [Parameter]
        public string FoodId { get; set; }
        
        public string Name { get; set; }

        public string Description { get; set; }
        public double Calories { get; set; }
        public double Fat { get; set; }
        public double Cholestrol { get; set; }
        public double Sodium { get; set; }
        public double Potassium { get; set; }
        public double Carbohydrates { get; set; }
        public double Protein { get; set; }
        public string Vitamin { get; set; }
        public string Image { get; set; }
    }
}
