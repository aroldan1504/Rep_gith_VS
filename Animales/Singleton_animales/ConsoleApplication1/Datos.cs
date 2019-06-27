using System.Collections.Generic;

namespace ConsoleApplication1
{
    class Datos
    {
        private static Datos instancia;
        public List<Perro> ListaPerros = new List<Perro>();
        private Datos() { }

        public static Datos GetInstancia(){
            if (instancia == null) { 
            instancia = new Datos();
        }
        return instancia;
        }

    }
}
