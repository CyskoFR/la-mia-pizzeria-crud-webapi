using la_mia_pizzeria.Models;

namespace la_mia_pizzeria_crud_mvc.Models
{
    public class Ingredient
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Ingredient()
        {
        }

        public List<Pizza> Pizzas { get; set; }
    }
}