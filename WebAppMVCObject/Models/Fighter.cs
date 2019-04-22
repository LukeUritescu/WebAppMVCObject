using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppMVCObject.Models
{
    public class Fighter : RPG
    {
        public Fighter() : this("Grog", 15, 10, 13, 12, 9, 14)
        {

        }

        public Fighter(string Name, int Strength, int Dexterity, int Constitution, int Intelligence, int Wisdom, int Charisma)
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
