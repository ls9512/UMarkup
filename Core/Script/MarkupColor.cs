using System.Text;
using UnityEngine;

namespace Aya.UI.Markup
{
	public static partial class UMarkup
    {
        private static StringBuilder ColorBuilder { get; set; }

        #region Custom Color

        public static MarkupAdapter Red { get; } = Color(new Color(1f, 0f, 0f, 1f));

		public static MarkupAdapter Green { get; } = Color(new Color(0f, 1f, 0f, 1f));

		public static MarkupAdapter Blue { get; } = Color(new Color(0f, 0f, 1f, 1f));

		public static MarkupAdapter White { get; } = Color(new Color(1f, 1f, 1f, 1f));

		public static MarkupAdapter Black { get; } = Color(new Color(0f, 0f, 0f, 1f));

		public static MarkupAdapter Yellow { get; } = Color(new Color(1f, 0.9215686f, 0.01568628f, 1f));

		public static MarkupAdapter Cyan { get; } = Color(new Color(0.0f, 1f, 1f, 1f));

		public static MarkupAdapter Magenta { get; } = Color(new Color(1f, 0.0f, 1f, 1f));

		public static MarkupAdapter Gray { get; } = Color(new Color(0.5f, 0.5f, 0.5f, 1f));

		public static MarkupAdapter Clear { get; } = Color(new Color(0.0f, 0.0f, 0.0f, 0.0f));

		#endregion

		#region Create Color Markup Adapter

		public static MarkupAdapter Color(Color color)
		{
            var leftMark = BuildStr("<color=", ColorToMarkup(color), ">");
            var rightMark = "</color>";
            return new MarkupAdapter(leftMark, rightMark);
        }

        private static string ColorToMarkup(Color color)
        {
            if (ColorBuilder == null) ColorBuilder = new StringBuilder();
            lock (ColorBuilder)
            {
                var r = (int)(color.r * 255);
                var g = (int)(color.g * 255);
                var b = (int)(color.b * 255);
                var a = (int)(color.a * 255);
                ColorBuilder.Clear();
                ColorBuilder.Append("#");
                ColorBuilder.Append(r.ToString("x2"));
                ColorBuilder.Append(g.ToString("x2"));
                ColorBuilder.Append(b.ToString("x2"));
                ColorBuilder.Append(a.ToString("x2"));
                var result = ColorBuilder.ToString();
                return result;
            }
        }

        #endregion
	}
}
