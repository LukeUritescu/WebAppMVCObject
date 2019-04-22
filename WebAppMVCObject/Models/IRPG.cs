using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppMVCObject.Models
{
    public interface IRPG : IAboutable
    {
         string Name { get;  set; }
         int Strength { get;  set; }
         int Dexterity { get; set; }
         int Constitution { get; set; }
         int Intelligence { get; set; }
         int Wisdom { get; set; }
         int Charisma { get; set; }



    }

    public interface IAboutable
    {
        string About();
    }
}
