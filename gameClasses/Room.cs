using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheLostFortress.gameClasses
{
    public class Room : Thing
    {
        public int _n;
        public int _s;
        public int _w;
        public int _e;

        public Room(string aName, string aDescription, int aN, int aS, int aW, int aE)
        : base(aName, aDescription)
        {
            _n = aN;
            _s = aS;
            _w = aW;
            _e = aE;
        }
        public int N
        {
            get => _n;
            set => _n = value;
        }
        public int S
        {
            get => _s;
            set => _s = value;
        }
        public int W
        {
            get => _w;
            set => _w = value;
        }
        public int E
        {
            get => _e;
            set => _e = value;
        }
    }
}
