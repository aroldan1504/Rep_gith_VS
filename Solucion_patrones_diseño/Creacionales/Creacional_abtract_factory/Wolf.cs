using System;


namespace Creacional_abtract_factory
{
    class Lobo : Carnivore

    {
        public override void Eat(Herbivore h)
        {
            // Eat Bison

            Console.WriteLine(this.GetType().Name +
              " come " + h.GetType().Name);
        }
    }
}
