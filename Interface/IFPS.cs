using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Abstraction.Interface
{
    public class FPS : IGame
    {
        public void Kategori()
        {
            Console.WriteLine("First Person Shooter.");
            Console.WriteLine("Memainkan tokoh dengan cara sudut pandang orang pertama.");
        }
    }
}