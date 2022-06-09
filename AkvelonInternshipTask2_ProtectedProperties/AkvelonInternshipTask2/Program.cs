using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkvelonInternshipTask2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Proton proton = new Proton();

            proton.Make(10, 20);
            proton.Show();
            proton.ShowSpeed();
            proton.Whoosh();

            Console.ReadKey();
        }
    }

    //protected properties with parent and child class

    public class Rocket
    {
        protected int width, length;

        public void Make(int w, int l)
        {
            width = w;
            length = l;
        }

        public void Show()
        {
            Console.WriteLine(width + length);
        }
    }

    public class Proton : Rocket
    {
        int speed;

        public void ShowSpeed()
        {
            speed = width * length;
        }

        public void Whoosh()
        {
            Console.WriteLine(speed);
        }
    }
    
}
