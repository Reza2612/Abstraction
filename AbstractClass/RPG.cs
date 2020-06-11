using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Abstraction.AbstractClass
{
    public class RPG : Game
    {
        public override void Kategori()
        {
            Console.WriteLine("Role Playing Game.");
            Console.WriteLine("Setiap karakter memiliki kemampuan dan kekuatan yang berbeda bahkan dapat berkembang sesuai yang dinginkan pemain.");
        }
    }
}