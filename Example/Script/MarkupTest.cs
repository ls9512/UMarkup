using UnityEngine;
using Aya.UI.Markup;

namespace Aya.Example
{
	public class MarkupTest : MonoBehaviour
	{
        private void Start()
		{
            var str1 = "[Markup Test 1]"
                       // <size=15><b><color=green>Complex Style</color></b></size>
                       + " Complex Style".ToMarkup(UMarkup.Green, UMarkup.Bold, UMarkup.Size(15))
                       // <color=#ffffff>White</color>
                       + " White".ToMarkup(Color.white)
                       // <i>Italics</i>
                       + " Italics".ToMarkup(UMarkup.Italic)
                       // <b>Bold</b>
                       + " Bold".ToMarkup(UMarkup.Bold);
            Debug.Log(str1);

            var str2 = "[Markup Test 2]"
                       // <size=15><b><color=green>Complex Style</color></b></size>
                       + UMarkup.Create(" Complex Style", UMarkup.Yellow, UMarkup.Italic, UMarkup.Size(12))
                       // <color=#ffffff>White</color>
                       + UMarkup.Create(" White", UMarkup.Color(Color.white))
                       // <i>Italics</i>
                       + UMarkup.Create(" Italics", UMarkup.Italic)
                       // <b>Bold</b>
                       + UMarkup.Create(" Bold", UMarkup.Bold);
            Debug.Log(str2);
		}

		private void Update()
		{
		}
	}
}