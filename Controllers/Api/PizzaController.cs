using la_mia_pizzeria.Models;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;

namespace la_mia_pizzeria_crud_mvc.Controllers.Api
{
    [Route("api/[controller]/[action]")]
    [ApiController]

    public class PizzaController : Controller
    {
        PizzeriaContext context = new PizzeriaContext();

        public PizzaController()
        {
            context = new PizzeriaContext();
        }

        public IActionResult Get()
        {
            List<Pizza> pizzas = context.Pizzas.ToList();

            return Ok(pizzas);
        }
    }
}
