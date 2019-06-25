using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creacional_abtract_factory
{
    class AfricaFactory : ContinentFactory

    {
        public override Herbivore CreateHerbivore()
        {
            return new Animales_Salvajes();
        }
        public override Carnivore CreateCarnivore()
        {
            return new Leon();
        }
    }
}
