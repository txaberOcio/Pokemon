using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json.Linq;
using System.Reflection.Emit;

namespace Pokemon.Models
{
    public class Animal
    {
        public int MyProperty { get; set; }
        public int Vida { get; set; }
        public int DainoMagico { get; set; }
        public int DainoFisico { get; set; }
        public string Nombre { get; set; }
        public int velocidad { get; set; }

        public Animal(int idf, int vidaf, int DainoMagicof, int DainoFisicof, String nomf, int velocidadf) {
            MyProperty = idf;
            Vida = vidaf;
            DainoMagico = DainoMagicof;
            DainoFisico = DainoFisicof;
            Nombre = nomf;
            velocidad = velocidadf;
        }
        public Animal()
        {
        }

    }
}
