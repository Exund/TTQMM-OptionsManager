﻿using System;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace Nuterra.OptionsManager
{
    public class OptionsManagerMod
    {
        private static GameObject _holder;
        public static void Load()
        {
            _holder = new GameObject();
            _holder.AddComponent<OptionsManager>();
            GameObject.DontDestroyOnLoad(_holder);

            /*var opt1 = new OptionToggle("Test Toggle", "Manager")
            {
                Value = true
            };

            var opt2 = new OptionText("Test Text", "Manager 1", 10)
            {
                Value = "Hello, World!"
            };

			var items = new List<string>() { "Somebody", "once", "told", "me" };
			var opt5 = new OptionList<string>("Test List", "Manager 1", items, 0);

			var opt3 = new OptionRange("Test Slider", "Manager 1",-10f,10f,0.7f)
            {
                Value = 0.3f
            };		

			var opt4 = new OptionKey("Test Key", "Manager")
            {
                Value = KeyCode.B
            };*/			
        }
    }
}
