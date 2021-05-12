using UnityEngine;
using Aya.UI.Markup;

namespace Aya.Example
{
    public class MarkupSample : MonoBehaviour
    {
        private void Start()
        {
            // Common Styles —— Use common styles in a concise way
            var str1 = "[Markup Test 1]"
                       // <size=15><b><color=green>Complex Style</color></b></size>
                       + " Complex Style".Color(Color.green).Bold().Size(15)
                       // <color=#ffffff>White</color>
                       + " White".Color(Color.white)
                       // <i>Italics</i>
                       + " Italics".Italic()
                       // <b>Bold</b>
                       + " Bold".Bold();
            Debug.Log(str1);

            // Extension —— Use extension methods to organize multiple different styles
            var str2 = "[Markup Test 2]"
                       // <size=15><b><color=green>Complex Style</color></b></size>
                       + " Complex Style".ToMarkup(UMarkup.Green, UMarkup.Bold, UMarkup.Size(15))
                       // <color=#ffffff>White</color>
                       + " White".ToMarkup(Color.white)
                       // <i>Italics</i>
                       + " Italics".ToMarkup(UMarkup.Italic)
                       // <b>Bold</b>
                       + " Bold".ToMarkup(UMarkup.Bold);
            Debug.Log(str2);

            // Static Method
            var str3 = "[Markup Test 3]"
                       // <size=15><b><color=green>Complex Style</color></b></size>
                       + UMarkup.Create(" Complex Style", UMarkup.Green, UMarkup.Bold, UMarkup.Size(15))
                       // <color=#ffffff>White</color>
                       + UMarkup.Create(" White", UMarkup.Color(Color.white))
                       // <i>Italics</i>
                       + UMarkup.Create(" Italics", UMarkup.Italic)
                       // <b>Bold</b>
                       + UMarkup.Create(" Bold", UMarkup.Bold);
            Debug.Log(str3);
        }

        private void Update()
        {
        }
    }

    public static class MarkupCustomStyleSample
    {
        // Custom single mark style
        public static MarkupAdapter CustomStyle1 { get; } = new MarkupAdapter("<singleMark>");

        // Custom left and right mark Style
        public static MarkupAdapter CustomStyle2 { get; } = new MarkupAdapter("<leftMark>", "</rightMark>");
    }
}