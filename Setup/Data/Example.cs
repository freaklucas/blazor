using System;
using Classes;
using Classes2;
using Classes3;
namespace Classes
{
    public class People
    {
        public string? Name { get; set; }
        public int Age { get; set; }
        public int Shoes {get; set;} = 2;
        public bool Walk {get; set;}
        public int Height { get; set; } = 160;

        public string SumAgeAndHeight => $"{Age} + {Height}";
    }
}

namespace Classes2
{
    public class Animal
    {
        public string? Name { get; set; }
        public string? Action { get; set; }

        public void Say()
        {
            Console.WriteLine($"Gatinho diz: {Action}");
        }
    }
}


namespace Classes3 {
    class Alien : Classes.People {
        new public string? Name {get;set;} 
        public bool Antenna {get;set;}
        public int VisitedPlanets {get;set;}
        new public int Height {get;set;}

        public void Fluttuent() {
            Console.WriteLine($"Hello Humans, i Fluttuent, my name is {Name}");
        }

        public void Consol() {
            Console.WriteLine("Oi!!!!!!!!!!!");
        }
    }
}

namespace ExampleComplete {
    public class Elements {
         public static void Run() {
            People pessoa = new People();
            pessoa.Name = "João";
            pessoa.Age = 20;
            pessoa.Walk = true;
            pessoa.Height = 180;
            Console.WriteLine(pessoa.SumAgeAndHeight);
        
            Alien alien = new Alien();

            alien.Consol();
        }
    }
}