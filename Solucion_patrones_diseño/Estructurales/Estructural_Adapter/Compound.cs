using System;


namespace Estructural_Adapter
{
    class Compound

    {
        protected string _chemical;
        protected float _boilingPoint;
        protected float _meltingPoint;
        protected double _molecularWeight;
        protected string _molecularFormula;

        // Constructor

        public Compound(string chemical)
        {
            this._chemical = chemical;
        }

        public virtual void Display()
        {
            Console.WriteLine("\nCompuesto: {0} ------ ", _chemical);
        }
    }
}
