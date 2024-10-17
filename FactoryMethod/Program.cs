using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FactoryClass characters;

            Console.WriteLine("Hangi karakteri yaratmak istersiniz? (Soldier/Archer/Wizard)");
            string choice = Console.ReadLine();

            // Kullanıcının seçimine göre fabrika sınıfını belirliyoruz
            if (choice.ToLower() == "soldier")
            {
                characters = new SoldierFactory();
            }
            else if (choice.ToLower() == "archer")
            {
                characters = new ArcherFactory();
            }
            else if (choice.ToLower() == "wizard")
            {
                characters = new WizardFactory();
            }
            else
            {
                Console.WriteLine("Geçersiz seçim!");
                return;
            }

            // Factory metodu ile karakter yaratılıyor
            ICharacters character = characters.CreateCharacter();
            character.Attack(); // Seçilen karakterin saldırı davranışını çağırıyoruz
        
        }
    }
}
