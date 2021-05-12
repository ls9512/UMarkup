using UnityEngine;

namespace Aya.UI.Markup
{
    public static class MarkupExtension
    {
        #region String ToMarkup

        public static string ToMarkup(this string str, params MarkupAdapter[] markups)
        {
            return UMarkup.Create(str, markups);
        }

        public static string ToMarkup(this string str, Color color)
        {
            return UMarkup.Create(str, UMarkup.Color(color));
        }

        public static string Color(this string str, Color color)
        {
            return str.ToMarkup(color);
        }

        public static string Bold(this string str)
        {
            return str.ToMarkup(UMarkup.Bold);
        }

        public static string Italic(this string str)
        {
            return str.ToMarkup(UMarkup.Italic);
        }

        #endregion

        #region Object ToMarkup

        public static string ToMarkup(this object obj, params MarkupAdapter[] markups)
        {
            return UMarkup.Create(obj.ToString(), markups);
        }

        public static string ToMarkup(this object obj, Color color)
        {
            return UMarkup.Create(obj.ToString(), UMarkup.Color(color));
        }

        #endregion
    }
}

