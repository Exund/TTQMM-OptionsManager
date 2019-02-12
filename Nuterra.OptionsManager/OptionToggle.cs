using System;
using UnityEngine;

namespace Nuterra.OptionsManager
{
    public class OptionToggle : Option<bool>
    {
        public OptionToggle(string Name, string ModName) : base(Name, ModName) {}

        public override bool Value { get; set; }

        public override void OnGUI()
        {
            Value = GUILayout.Toggle(Value, "",Nuterra.UI.Elements.Toggle.Check);
        }
    }
}
