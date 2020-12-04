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

