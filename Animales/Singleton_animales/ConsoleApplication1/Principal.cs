using System;

namespace ConsoleApplication1
{
    class Principal
    {
        static void Main(string[] args)
        {
            Datos datos1 = Datos.GetInstancia();
            datos1.ListaPerros.Add(new Perro() { Id = 1, Nombre = "Firulais", Edad = 2, Raza = "Poodle" });
            datos1.ListaPerros.Add(new Perro() { Id = 2, Nombre = "Scooby", Edad = 1, Raza = "Rotweller" });
            datos1.ListaPerros.Add(new Perro() { Id = 3, Nombre = "Pelusa", Edad = 3, Raza = "Cocker" });
            datos1.ListaPerros.Add(new Perro() { Id = 4, Nombre = "Tyzon", Edad = 2, Raza = "French poodle" });
            datos1.ListaPerros.Add(new Perro() { Id = 5, Nombre = "Suka", Edad = 4, Raza = "Pitt bull" });
            
            CargarDatos();

            foreach (Perro perro in datos1.ListaPerros)
            {
                Console.WriteLine("Id = " + perro.Id + ", Nombre = " + perro.Nombre + ", Edad = " + perro.Edad + ", Raza = " + perro.Raza+"\n");
            }
            Console.Read();
        }

        private static void CargarDatos()
        {
            Datos datos2 = Datos.GetInstancia();
            datos2.ListaPerros.Add(new Perro() { Id = 6, Nombre = "Rocko", Edad = 3, Raza = "Doverman" });
            datos2.ListaPerros.Add(new Perro() { Id = 7, Nombre = "Scrappy", Edad = 1, Raza = "Gran danés" });
            datos2.ListaPerros.Add(new Perro() { Id = 8, Nombre = "Coqueta", Edad = 5, Raza = "Cocker" });
            datos2.ListaPerros.Add(new Perro() { Id = 9, Nombre = "Wisky", Edad = 3, Raza = "Bulldog" });
            datos2.ListaPerros.Add(new Perro() { Id = 10, Nombre = "Apa", Edad = 5, Raza = "San bernardo" });
            
         }
    }
}
