using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



using Abstraction.AbstractClass;    // Menggunakan Abstract Class
//using Abstraction.Interface;      // Menggunakan Interface

namespace Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game;          // Menggunakan Abstract Class
            game = new FPS();
            game.Kategori();

            Console.WriteLine();
            game = new RPG();
            game.Kategori();

            Console.WriteLine();
            game = new RTS();
            game.Kategori();


            
			/*IGame game;       // Menggunakan Abstract Class
            game = new FPS();
            game.Kategori();
            
			Console.WriteLine();
            game = new RPG();
            game.Kategori();
            
			Console.WriteLine();
            game = new RTS();
            game.Kategori()*/

            Console.ReadKey();
        }
    }
}