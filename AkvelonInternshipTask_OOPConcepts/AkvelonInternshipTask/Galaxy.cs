using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AkvelonInternshipTask.Program;

namespace AkvelonInternshipTask
{

    internal class Galaxy : CelestialObject
    {
        public long starCount;

        public void Cruise()
        {
            Console.WriteLine("I'm floating around.");
        }

        //method override
        public override void GetDetails()
        {
            Console.WriteLine("Overriding the details from the CelectialObject class is fun. :)");
        }

        //abstraction
        public override void CreateMe()
        {
            Console.WriteLine("Galaxy created.");
        }
    }
}
