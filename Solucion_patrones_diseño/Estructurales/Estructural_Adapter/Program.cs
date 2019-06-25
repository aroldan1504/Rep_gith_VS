using System;


namespace Estructural_Adapter
{
    class Program
    {

        static void Main()
        {
            // Non-adapted chemical compound

            Compound unknown = new Compound("Desconocido");
            unknown.Display();

            // Adapted chemical compounds

            Compound water = new RichCompound("Agua");
            water.Display();

            Compound benzene = new RichCompound("Benzeno");
            benzene.Display();

            Compound ethanol = new RichCompound("Ethanol");
            ethanol.Display();

            // Wait for user

            Console.ReadKey();
        }
    }
}
