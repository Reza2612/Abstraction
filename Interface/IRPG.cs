using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Abstraction.Interface
{
    public class RPG : IGame
    {
        public void Kategori()
        {
            Console.WriteLine("Role Playing Game.");
            Console.WriteLine("Setiap karakter memiliki kemampuan dan kekuatan yang berbeda bahkan dapat berkembang sesuai yang dinginkan pemain.");
        }
    }
}