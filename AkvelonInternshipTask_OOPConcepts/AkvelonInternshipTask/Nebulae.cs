using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AkvelonInternshipTask.Program;

namespace AkvelonInternshipTask
{
    class Nebulae : CelestialObject
    {
        //encapsulation

        private string _finalForm;

        public string FinalForm
        {
            get { return _finalForm; }
        }


        public Nebulae(string nebulaeColor, string nebulaeType)
        {
            _finalForm = CreateAStar(nebulaeColor, nebulaeType);
        }

        private string CreateAStar(string nebulaeColor, string nebulaeType)
        {
            string star = nebulaeColor + " " + nebulaeType;
            return star;
            Console.WriteLine(star);
        }

        //abstraction
        public override void CreateMe()
        {
            Console.WriteLine("Nebulae created.");
        }
    }
}
