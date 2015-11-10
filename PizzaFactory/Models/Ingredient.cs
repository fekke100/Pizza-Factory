using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PizzaFactory.Models
{
    public class Ingredient
    {
        public int ID { get; set; }
        public int TypeID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public DateTime DateCreated { get; set; }
        public virtual IngredientType IngredientType { get; set; }
    }
}