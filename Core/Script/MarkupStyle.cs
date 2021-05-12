namespace Aya.UI.Markup
{
	public static partial class UMarkup
	{
        public static MarkupAdapter Bold { get; } = new MarkupAdapter("<b>", "</b>");

        public static MarkupAdapter Italic { get; } = new MarkupAdapter("<i>", "</i>");

        public static MarkupAdapter Size(int size)
        {
            size = size < 1 ? 1 : size;
            var leftMark = BuildStr("<size=", size, ">");
            var rightMark = "</size>";
            return new MarkupAdapter(leftMark, rightMark);
        }

        public static string Size(this string str, int size)
        {
            return str.ToMarkup(UMarkup.Size(size));
        }

		public static MarkupAdapter Material(int index) 
		{
			index = index < 0 ? 0 : index;
            var leftMark = BuildStr("<material=", index, ">");
            var rightMark = "</material>";
            return new MarkupAdapter(leftMark, rightMark);
        }

        public static MarkupAdapter Quad(int materialIndex, int size, float x, float y, float width, float height)
        {
            materialIndex = materialIndex < 0 ? 0 : materialIndex;
            var leftMark = BuildStr("<quad material=", materialIndex, " size=", size, " x=", x, " y=", y, " width=",
                width, " height=", height, ">");
            var rightMark = "</material>";
            return new MarkupAdapter(leftMark, rightMark);
        }

		public static MarkupAdapter Quad(string name, int size, float x, float y, float width, float height)
		{
			size = size < 0 ? 0 : size;
            var leftMark = BuildStr("<quad name=", name, " size=", size, " x=", x, " y=", y, " width=", width, " height=", height, ">");
            var rightMark = "</quad>";
            return new MarkupAdapter(leftMark, rightMark);
        }
	}
}
 