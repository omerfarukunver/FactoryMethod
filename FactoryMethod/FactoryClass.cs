using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static FactoryMethod.Characters;
using static System.Net.Mime.MediaTypeNames;

namespace FactoryMethod
{
    public abstract class FactoryClass
    {
        // Bu fabrika metodunu alt sınıflar implement edecek
        public abstract ICharacters CreateCharacter();
    }
    public class SoldierFactory : FactoryClass
    {
        public override ICharacters CreateCharacter()
        {
            return new Soldier();
        }
    }
    public class ArcherFactory : FactoryClass
    {
        public override ICharacters CreateCharacter()
        {
            return new Archer();
        }
    }
    public class WizardFactory : FactoryClass
    {
        public override ICharacters CreateCharacter()
        {
            return new Wizard();
        }
    }
}
