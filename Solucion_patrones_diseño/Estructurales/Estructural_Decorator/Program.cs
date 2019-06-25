using System;

namespace Estructural_Decorator
{
    class Program
    {
        static void Main()
        {
            // Create book

            Book book = new Book("Worley", "Inside ASP.NET", 10);
            book.Display();

            // Create video

            Video video = new Video("Spielberg", "Jaws", 23, "92 Min.");
            video.Display();

            // Make video borrowable, then borrow and display

            Console.WriteLine("\nHaciendo Video Prestable:");

            Borrowable borrowvideo = new Borrowable(video);
            borrowvideo.BorrowItem("Cliente  #1");
            borrowvideo.BorrowItem("Cliente  #2");

            borrowvideo.Display();

            // Wait for user

            Console.ReadKey();
        }
    }
}
