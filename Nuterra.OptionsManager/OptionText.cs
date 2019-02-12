using System;
using UnityEngine;

namespace Nuterra.OptionsManager
{
    public class OptionText : Option<string>
    {
        private int maxLength;
        public OptionText(string Name, string ModName, int MaxLength = int.MaxValue) : base(Name, ModName)
        {
            this.maxLength = MaxLength;
        }

        private string value = "";
        public override string Value
        {
            get { return this.value; }
            set
            {
                if (value.Length <= maxLength) this.value = value;
            }
        }

        public override void OnGUI()
        {
            Value = GUILayout.TextField(Value, GUILayout.Width(200f));
        }
    }
}
