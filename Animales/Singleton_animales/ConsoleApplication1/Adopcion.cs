using System;

namespace ConsoleApplication1
{
    class Adopcion
    {
        public Persona PersonaAdopta { set; get; }
        public Perro PerroAdoptado { set; get; }
        public DateTime FehcaAdopcion
        {
            get
            {
                return DateTime.Now;
            }
        }
    }
}
