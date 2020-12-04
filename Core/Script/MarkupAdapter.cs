using System.Text;

namespace Aya.UI.Markup
{
	public class MarkupAdapter
	{
        private static StringBuilder AdapterBuilder { get; set; }

        public string LeftMark { get; }

        public string RightMark { get; }

        public string SingleMark { get; }

        public MarkupAdapter(string singleMark)
        {
            SingleMark = singleMark;
        }

        public MarkupAdapter(string leftMark, string rightMark)
		{
			LeftMark = leftMark;
			RightMark = rightMark;
		}

        public virtual string ToString(string str)
        {
            if (string.IsNullOrEmpty(SingleMark))
            {
                return BuildAdapter(LeftMark, str, RightMark);
            }
            else
            {
                return SingleMark;
            }
        }

        internal static string BuildAdapter(params object[] args)
        {
            if (AdapterBuilder == null) AdapterBuilder = new StringBuilder();
            lock (AdapterBuilder)
            {
                AdapterBuilder.Clear();
                for (var i = 0; i < args.Length; i++)
                {
                    AdapterBuilder.Append(args[i]);
                }

                return AdapterBuilder.ToString();
            }
        }
    }
}