using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheLostFortress.gameClasses
{
    public class Thing
    {
        private string _name;
        private string _description;

        public Thing(string aName, string aDescriprion)
        {
            _name = aName;
            _description = aDescriprion;
        }

        public string Name // Name property
        {
            get => _name;
            set => _name = value;
        }

        public string Description // Description property
        {
            get => _description;
            set => _description = value;
        }

    }
}
