using System;
using System.ComponentModel.DataAnnotations;

namespace FoodDataApp.Core
{
    public class Food
    {
        public int FoodId { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "Food name is too long.")]
        public string Name { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Description is too long.")]
        public string Description { get; set; }
        public double Calories { get; set; }
        public double Fat { get; set; }
        public double Cholestrol { get; set; }
        public double Sodium { get; set; }
        public double Potassium { get; set; }
        public double Carbohydrates { get; set; }
        public double Protein { get; set; }
        public int VitaminId { get; set; }
        public Vitamin Vitamin { get; set; }
        public string Image { get; set; }

    }
}
