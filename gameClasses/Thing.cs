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

        public Thing(string name, string descriprion)
        {
            _name = name;
            _description = descriprion;
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
