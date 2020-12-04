using System.Text;

namespace Aya.UI.Markup
{
	public static partial class UMarkup
    {
        private static StringBuilder StringBuilder { get; set; }

        public static string Create(string str, params MarkupAdapter[] markups)
        {
            for (var i = 0; i < markups.Length; i++)
            {
                var markup = markups[i];
                str = markup.ToString(str);
            }

            return str;
        }

        internal static string BuildStr(params object[] args)
        {
            if (StringBuilder == null) StringBuilder = new StringBuilder();
            lock (StringBuilder)
            {
                StringBuilder.Clear();
                for (var i = 0; i < args.Length; i++)
                {
                    StringBuilder.Append(args[i]);
                }

                return StringBuilder.ToString();
            }
        }
	}

}
