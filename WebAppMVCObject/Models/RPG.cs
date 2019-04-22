using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace WebAppMVCObject.Models
{
    [Serializable]
    public class RPG : IRPG, ISerializable
    {
        //Random rnd = new Random();

        public string Name { get; set; }
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Constitution { get; set; }
        public int Intelligence { get; set; }
        public int Wisdom { get; set; }
        public int Charisma { get; set; }

        public RPG() : this("RPG") { }

        public RPG(string Name) : this(Name, 15, 10, 13, 12, 8, 14) { }

        public RPG(string Name, int Strength, int Dexterity, int Constitutionn, int Intelligence, int Wisdom, int Charisma)
        {
            this.Name = Name;
            this.Strength = Strength;
            this.Dexterity = Dexterity;
            this.Constitution = Constitution;
            this.Intelligence = Intelligence;
            this.Wisdom = Wisdom;
            this.Charisma = Charisma;
            //this.Strength = (rnd.Next(1, 7) + rnd.Next(1, 7) + rnd.Next(1, 7));
            //this.Dexterity = (rnd.Next(1, 7) + rnd.Next(1, 7) + rnd.Next(1, 7));
            //this.Constitution = (rnd.Next(1, 7) + rnd.Next(1, 7) + rnd.Next(1, 7));
            //this.Intelligence = (rnd.Next(1, 7) + rnd.Next(1, 7) + rnd.Next(1, 7));
            //this.Wisdom = (rnd.Next(1, 7) + rnd.Next(1, 7) + rnd.Next(1, 7));
            //this.Charisma = (rnd.Next(1, 7) + rnd.Next(1, 7) + rnd.Next(1, 7));
        }

        public RPG(SerializationInfo info, StreamingContext context)
        {
            Name = info.GetString("Name");
            Strength = info.GetInt32("Strength");
            Dexterity = info.GetInt32("Dexterity");
            Constitution = info.GetInt32("Constitution");
            Intelligence = info.GetInt32("Intelligence");
            Wisdom = info.GetInt32("Wisdom");
            Charisma = info.GetInt32("Charisma");
        }



        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Name", Name);
            info.AddValue("Strength", Strength);
            info.AddValue("Dexterity", Dexterity);
            info.AddValue("Constitution", Constitution);
            info.AddValue("Intelligence", Intelligence);
            info.AddValue("Wisdom", Wisdom);
            info.AddValue("Charisma", Charisma);
        }

        public override bool Equals(object other)
        {
            var toCompareWith = other as RPG;
            if (toCompareWith == null)
                return false;
            return this.Name == toCompareWith.Name && this.Strength == toCompareWith.Strength && this.Dexterity == toCompareWith.Dexterity && this.Constitution == toCompareWith.Constitution && this.Intelligence == toCompareWith.Intelligence && this.Wisdom == toCompareWith.Wisdom && this.Charisma == toCompareWith.Charisma;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public string About()
        {
            return $"My name is {Name}";
        }
    }
}
