using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FactoryMethod.ICharacters;

namespace FactoryMethod
{
    public class Characters
    {
        public class Soldier : ICharacters
        {
            public void Attack()
            {
                Console.WriteLine($"Asker Kılıcını Çekti!");
            }
        }
        public class Archer : ICharacters
        {
            public void Attack()
            {
                Console.WriteLine($"Okçu Yayına Ok Yerleştirdi!");
            }
        }
        public class Wizard : ICharacters
        {
            public void Attack()
            {
                Console.WriteLine($"Büyücü Sözlerini Söyledi!");
            }
        }
    }
}
