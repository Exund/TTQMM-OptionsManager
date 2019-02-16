using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;
using System.Linq;

namespace Nuterra.OptionsManager
{
    public class OptionsManager : MonoBehaviour
    {
        private static List<Option> options = new List<Option>();
        private bool visible = false;
        private int ID = 0;
        private Rect win = new Rect(0, 0, Screen.width, Screen.height);
        private Vector2 scroll = Vector2.zero;
        private Rect button = new Rect((Screen.width - 200) / 2, 0, 200, 50);

		private string current = "";
		public static void AddOption(Option opt)
		{
			options.Add(opt);
			options = options.OrderBy(v => v.modName).ToList();
		}

		void Update()
        {

        }

        void OnGUI()
        {
            if (ManPauseGame.inst.IsPaused && !visible) visible = GUI.Button(button, "Mods options",Nuterra.UI.Elements.Buttons.Plain);


            if(ManPauseGame.inst.IsPaused && visible) GUI.Window(ID, win, Window, "Mods options");
        }

        private void Window(int id)
        {
            GUILayout.BeginHorizontal();
            GUILayout.FlexibleSpace();
            scroll = GUILayout.BeginScrollView(scroll, GUILayout.MaxWidth(Screen.width/2f));
            foreach (var option in options)
            {        
				if(option.modName != current)
				{
					GUILayout.Space(10);
					GUILayout.Label($"<size=20>{option.modName}</size>");
					current = option.modName;
				}
                GUILayout.BeginHorizontal();
                GUILayout.Label(option.name);
                option.OnGUI();
                GUILayout.EndHorizontal();
				GUILayout.Space(10);
            }
            GUILayout.EndScrollView();
            GUILayout.FlexibleSpace();
            GUILayout.EndHorizontal();
            if (GUILayout.Button("Close")) visible = false;

			if (Event.current.type == EventType.MouseDown || Event.current.type == EventType.MouseUp) Event.current.Use();
        }
    }
}
