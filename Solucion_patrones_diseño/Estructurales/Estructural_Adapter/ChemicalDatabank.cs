

namespace Estructural_Adapter
{
    class ChemicalDatabank

    {
        // The databank 'legacy API'

        public float GetCriticalPoint(string compound, string point)
        {
            // Melting Point

            if (point == "M")
            {
                switch (compound.ToLower())
                {
                    case "agua": return 0.0f;
                    case "benzeno": return 5.5f;
                    case "ethanol": return -114.1f;
                    default: return 0f;
                }
            }
            // Boiling Point

            else

            {
                switch (compound.ToLower())
                {
                    case "agua": return 100.0f;
                    case "benzeno": return 80.1f;
                    case "ethanol": return 78.3f;
                    default: return 0f;
                }
            }
        }

        public string GetMolecularStructure(string compound)
        {
            switch (compound.ToLower())
            {
                case "agua": return "H20";
                case "benzeno": return "C6H6";
                case "ethanol": return "C2H5OH";
                default: return "";
            }
        }

        public double GetMolecularWeight(string compound)
        {
            switch (compound.ToLower())
            {
                case "agua": return 18.015;
                case "benzeno": return 78.1134;
                case "ethanol": return 46.0688;
                default: return 0d;
            }
        }
    }
}
