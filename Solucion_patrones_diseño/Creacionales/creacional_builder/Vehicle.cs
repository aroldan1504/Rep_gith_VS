using System;
using System.Collections.Generic;


namespace creacional_builder
{
    class Vehicle

    {
        private string _vehicleType;
        private Dictionary<string, string> _parts =
          new Dictionary<string, string>();

        // Constructor

        public Vehicle(string vehicleType)
        {
            this._vehicleType = vehicleType;
        }

        // Indexer

        public string this[string key]
        {
            get { return _parts[key]; }
            set { _parts[key] = value; }
        }

        public void Show()
        {
            Console.WriteLine("\n---------------------------");
            Console.WriteLine("Tipo de vehículo: {0}", _vehicleType);
            Console.WriteLine(" Chasís : {0}", _parts["frame"]);
            Console.WriteLine(" Motor : {0}", _parts["engine"]);
            Console.WriteLine(" # de llantas: {0}", _parts["wheels"]);
            Console.WriteLine(" # de puertas : {0}", _parts["doors"]);
        }
    }
}
