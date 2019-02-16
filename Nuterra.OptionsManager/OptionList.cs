using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Nuterra.OptionsManager
{
	public class OptionList<T> : Option<T>
	{
		public List<T> items;
		private bool visible = false;
		private int selected;
		public OptionList(string Name, string ModName, List<T> items, int selected) : base(Name, ModName)
		{
			this.selected = selected;
			this.items = items;
			Value = items[selected];
		}

		public override T Value { get; set; }

		public override void OnGUI()
		{
			GUIContent[] options = items.Select(o => new GUIContent(o.ToString())).ToArray();
			if (UI.NuterraGUI.List(ref visible, ref selected, options[selected], options)) Value = items[selected];
		}
	}
}
