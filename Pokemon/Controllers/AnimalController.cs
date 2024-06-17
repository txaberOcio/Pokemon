using Microsoft.AspNetCore.Mvc;
using Microsoft.DotNet.Scaffolding.Shared.Messaging;
using Newtonsoft.Json.Linq;
using Pokemon.Models;
using System.Configuration;

namespace Pokemon.Controllers
{
    public class AnimalController : Controller
    {
        private static List<Animal> animales = new List<Animal>();
        public static List<Animal> AnimalesProp
        {
            get{
            return animales;    
            }  
        }

        public IActionResult Index()
        {
            //aqui mostramos todos los animes           
            return View(animales);
        }
        public ActionResult Create()
        {
            if (animales.Count <= 6) {
                /*sacarid*/
                int idf;
                if (animales.Count > 0)
                {
                    Animal animalConMayorMyProperty = animales.OrderByDescending(a => a.MyProperty).FirstOrDefault();
                    idf = animalConMayorMyProperty.MyProperty + 1;
                }
                else
                {
                    idf = 1;
                }
                // Aquí va tu lógica para la acción "Create"
                Random rand = new Random();
                int min = 10; // valor mínimo
                int max = 20; // valor máximo
                int numeroAleatorio = rand.Next(min, max);
                int vidaf = numeroAleatorio;
                int myproperty = animales.Count + 1;
                min = 1; // valor mínimo
                max = 10; // valor máximo
                numeroAleatorio = rand.Next(min, max);
                int DainoMagicof = numeroAleatorio;
                numeroAleatorio = rand.Next(min, max);
                int DainoFisicof = numeroAleatorio;
                numeroAleatorio = rand.Next(min, max);
                int velocidadf = numeroAleatorio;
                /*nombre*/
                List<Animal> pokemons = new List<Animal>();
                string[] nombresPokemon = new string[] {  "Caterpie","Beedrill", "Pidgey","Arbok","Sandslash","Vulpix", "Ninetales", "Jigglypuff", "Parasect","Dugtrio" };
                numeroAleatorio = rand.Next(1, nombresPokemon.Length);
                String Nombref = nombresPokemon[numeroAleatorio];
                Animal obk = new Animal(idf,vidaf, DainoMagicof, DainoFisicof, Nombref, velocidadf);
                animales.Add(obk);
                Console.WriteLine("aaa");
            }
            
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int MyProperty)
        {
            Console.WriteLine(MyProperty);
            for (int i = 0; i < animales.Count(); i++)
            {
                if (animales[i].MyProperty == MyProperty)
                {
                    animales.RemoveAt(i);
                    i = 50;
                }
            }
            return RedirectToAction("Index");
        }
        public ActionResult Pelear()
        {
            ViewBag["HayPokemon"] = animales;
            return View(animales);
        }
    }
}
