using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppMVCObject.Models
{
    public class Wizard : RPG
    {
        public Wizard() : this("Gandalf", 8, 10, 13, 15, 12, 14) { }

        public Wizard(string Name, int Strength, int Dexterity, int Constitution, int Intelligence, int Wisdom, int Charisma)
        {
            this.Name = Name;
            this.Strength = Strength;
            this.Dexterity = Dexterity;
            this.Constitution = Constitution;
            this.Intelligence = Intelligence;
            this.Wisdom = Wisdom;
            this.Charisma = Charisma;
        }
    }
}
