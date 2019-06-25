using System;


namespace Estructural_Decorator
{
    class Book : LibraryItem

    {
        private string _author;
        private string _title;

        // Constructor

        public Book(string author, string title, int numCopies)
        {
            this._author = author;
            this._title = title;
            this.NumCopies = numCopies;
        }

        public override void Display()
        {
            Console.WriteLine("\nLibro ------ ");
            Console.WriteLine(" Autor: {0}", _author);
            Console.WriteLine(" Título: {0}", _title);
            Console.WriteLine(" # Copias: {0}", NumCopies);
        }
    }
}
