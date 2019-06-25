
namespace Creacional_abtract_factory
{
    class AmericaFactory : ContinentFactory

    {
        public override Herbivore CreateHerbivore()
        {
            return new Bisonte();
        }
        public override Carnivore CreateCarnivore()
        {
            return new Lobo();
        }
    }
}
