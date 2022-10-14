﻿using la_mia_pizzeria.Models;

namespace la_mia_pizzeria_crud_mvc.Models
{
    public class PizzasCategories
    {
        public Pizza Pizza { get; set; }

        public List<Category> Categories {get; set; }
        public List<Ingredient> Ingredients { get; set; }
        public List<int> SelectedIngredientsId { get; set; }

        public PizzasCategories()
        {
            Pizza = new Pizza();
            Categories = new List<Category>();
            Ingredients = new List<Ingredient>();
            SelectedIngredientsId = new List<int>();
        }
    }
}
