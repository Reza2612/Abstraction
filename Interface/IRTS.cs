using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Abstraction.Interface
{
    public class RTS : IGame
    {
        public void Kategori()
        {
            Console.WriteLine("Real Time Strategy.");
            Console.WriteLine("Memerlukan kemampuan pemain untuk memimpin sebuah pasukan, kemudian mengelola sumber daya hingga membangun peradaban.");
        }
    }
}