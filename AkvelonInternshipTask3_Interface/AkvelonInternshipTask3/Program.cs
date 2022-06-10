using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkvelonInternshipTask3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Reflector reflector = new Reflector();
            Refractor refractor = new Refractor();
            reflector.ChangeType(refractor);

            Console.WriteLine(reflector.ToString());

            Console.ReadKey();

        }
    }

    public class Reflector : ITelescope
    {
        public void ChangeType<Refractor>(Refractor refractor)
        {
            Console.WriteLine(refractor);
        }

    }

    public class Refractor : ITelescope
    {
        public void ChangeType<Reflector>(Reflector reflector)
        {
            throw new NotImplementedException();
        }
    }
}
