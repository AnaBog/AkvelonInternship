using System;

namespace AkvelonInternshipTask
{
    class Program
    {
        abstract internal class CelestialObject
        {
            public string Name { get; set; }
            public string Shape { get; set; }
            public string Description { get; set; }

            public virtual void GetDetails()
            {
                Console.WriteLine($"{Name} has a {Shape} shape and has {Description}");
            }

            //method overload
            public void GetDetails(int Density)
            {
                Console.WriteLine($"{Name} has a {Shape} shape and has {Description}. Density is {Density}. ");
            }

            //abstraction
            public abstract void CreateMe();
        }

        public static void Main(string[] args)
        {
            Galaxy galaxy = new Galaxy();
            galaxy.Name = "Messier Object 104";
            galaxy.Shape = "barred spiral";
            galaxy.Description 
                = "an overwhelming bright center, contrasting the intriguingly detailed dust band";
            galaxy.starCount = 100000000000;
            galaxy.GetDetails();
            //method overload
            galaxy.GetDetails(6);
            galaxy.Cruise();

            Nebulae nebulae = new Nebulae("purple", "supernova remnant");
            nebulae.Name = "Dark Horse Nebula";
            nebulae.Shape = "the side silhouette of a horse";
            nebulae.Description = "dark appearance as compared with the background glow of stars and star clouds";
            nebulae.GetDetails(100);

            //abstraction
            nebulae.CreateMe();

            Console.ReadKey();
        }
    }
}
