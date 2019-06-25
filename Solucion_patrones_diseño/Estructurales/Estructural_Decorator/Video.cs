using System;


namespace Estructural_Decorator
{
    class Video : LibraryItem

    {
        private string _director;
        private string _title;
        private string _playTime;

        // Constructor

        public Video(string director, string title,
          int numCopies, string playTime)
        {
            this._director = director;
            this._title = title;
            this.NumCopies = numCopies;
            this._playTime = playTime;
        }

        public override void Display()
        {
            Console.WriteLine("\nVideo ----- ");
            Console.WriteLine(" Director: {0}", _director);
            Console.WriteLine(" Título: {0}", _title);
            Console.WriteLine(" # Copias: {0}", NumCopies);
            Console.WriteLine(" Duración: {0}\n", _playTime);
        }
    }
}
