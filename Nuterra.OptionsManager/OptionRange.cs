using System;
using UnityEngine;

namespace Nuterra.OptionsManager
{
    public class OptionRange : Option<float>
    {
        private float minValue;
        private float maxValue;
        private float roundTo;
        //private int roundLength;
        public OptionRange(string Name, string ModName, float MinValue = 0f, float MaxValue = 100f, float RoundTo = 1f) : base(Name, ModName)
        {
            minValue = MinValue;
            maxValue = MaxValue;
            roundTo = RoundTo;
            //var s = roundTo.ToString().Split('.');
            //roundLength = s.Length > 1 ? s[1].Length : 0;
        }
        //private float temp;
        private float value;
        //private float last = Time.time - 0.1f;
        public override float Value
        {
            get { return value; }
            set
            {
				if (value >= minValue && value <= maxValue)
				{
					//this.value = Mathf.RoundToInt(value*(1f/roundTo))
					//temp = this.value;
					this.value = Mathf.RoundToInt(value / roundTo) * roundTo;
				}
			}
        }

        public override void OnGUI()
        {
			//GUILayout.Label(Value.ToString());
			/*temp = GUILayout.HorizontalSlider(temp, minValue, maxValue, GUILayout.Width(200f));
            if(Time.time-last > 0.4f)
            {
                Value = temp;
                temp = Value;
                last = Time.time;
            }*/
			GUILayout.BeginHorizontal(GUILayout.Width(200f));
			GUILayout.Label(Math.Round(Value,4).ToString(), GUILayout.Width(50f));
			Value = /*Mathf.RoundToInt(*/GUILayout.HorizontalSlider(Value, minValue, maxValue, GUILayout.Width(150f));// / roundTo) * roundTo;
			//if (GUILayout.Button("Set", GUILayout.Width(75f))) Value = temp;
			GUILayout.EndHorizontal();
		}
    }
}
