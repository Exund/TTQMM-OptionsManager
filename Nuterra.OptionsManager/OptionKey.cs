using System;
using UnityEngine;

namespace Nuterra.OptionsManager
{
    public class OptionKey : Option<KeyCode>
    {
        private bool changeKey = false;
        public OptionKey(string Name, string ModName) : base(Name, ModName) {}

        public override KeyCode Value { get; set; }

        public override void OnGUI()
        {
			GUILayout.BeginHorizontal(GUILayout.Width(200f));
            if (GUILayout.Button(changeKey ? "Press a key" : (int)Value == -1 ? "-" : Value.ToString(), GUILayout.Width(125f))) changeKey = true;
			if (changeKey)
			{
				Event current = Event.current;
				if (current.isKey)
				{
					Value = current.keyCode;
					changeKey = false;
				}
				else if (current.isMouse) changeKey = false;
			}
			if (GUILayout.Button("Unset", GUILayout.Width(65f))) Value = (KeyCode)(-1);
			GUILayout.EndHorizontal();
		}
    }
}
