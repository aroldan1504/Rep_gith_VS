﻿using System;


namespace Estructural_Adapter
{
    class RichCompound : Compound

    {
        private ChemicalDatabank _bank;

        // Constructor

        public RichCompound(string name)
          : base(name)
        {
        }

        public override void Display()
        {
            // The Adaptee

            _bank = new ChemicalDatabank();

            _boilingPoint = _bank.GetCriticalPoint(_chemical, "B");
            _meltingPoint = _bank.GetCriticalPoint(_chemical, "M");
            _molecularWeight = _bank.GetMolecularWeight(_chemical);
            _molecularFormula = _bank.GetMolecularStructure(_chemical);

            base.Display();
            Console.WriteLine(" Formula: {0}", _molecularFormula);
            Console.WriteLine(" Peso : {0}", _molecularWeight);
            Console.WriteLine(" Punto de fusión: {0}", _meltingPoint);
            Console.WriteLine(" Punto de ebullición: {0}", _boilingPoint);
        }
    }
}
