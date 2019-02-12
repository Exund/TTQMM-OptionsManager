using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Nuterra.OptionsManager
{
    public abstract class Option
    {
        public abstract void OnGUI();
        internal string name;
        internal string modName;
    }

    public abstract class Option<T> : Option
    {
        public abstract T Value { get; set; }

        public Option(string Name, string ModName)
        {
            this.name = Name;
            this.modName = ModName;
            OptionsManager.AddOption(this);
        }
    }
}
