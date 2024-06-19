using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheLostFortress.gameClasses
{
    
        public class Player : Thing
        {
            private Room _location; //Room where player is currently residing

            public Player(string aName, string aDescription, Room aRoom) : 
                base(aName, aDescription) 
            {
            _location = aRoom;
            }
            public Room Location
            {
                get => _location;
                set => _location = value;
            }
        }
}
