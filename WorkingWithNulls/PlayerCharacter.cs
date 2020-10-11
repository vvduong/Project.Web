using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithNulls
{
    class PlayerCharacter
    {
        public string Name { get; set; }

        public int DaysSinceLastLogin { get; set; }

        public DateTime DateOrBirth { get; set; }
        public PlayerCharacter()
        {
            DateOrBirth = DateTime.MinValue;
            DaysSinceLastLogin = -1;   
        }
    }
}
