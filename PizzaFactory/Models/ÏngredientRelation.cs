using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PizzaFactory.Models
{
    public class ÏngredientRelation
    {
        [Key]
        public int IngredientID { get; set; }
        public int CrustID { get; set; }
        public int Amount { get; set; }

        public virtual Ingredient IngredientType { get; set; }
        public virtual Crust Crust { get; set; }
    }
}