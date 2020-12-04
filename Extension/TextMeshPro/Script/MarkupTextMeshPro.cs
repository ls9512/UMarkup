using UnityEngine;

namespace Aya.UI.Markup
{
    public enum SizeFormat
    {
        /// <summary>
        /// 像素
        /// </summary>
        Pixels,
        /// <summary>
        /// 字体单位（em）
        /// </summary>
        FontUnits,
        /// <summary>
        /// 百分比
        /// </summary>
        Percentages,
    }

    public static partial class UMarkup
    {
        /// <summary>
        /// 左对齐
        /// </summary>
        public static MarkupAdapter AlignLeft { get; } = new MarkupAdapter("<align=\"left\">", "</align>");

        /// <summary>
        /// 居中对齐
        /// </summary>
        public static MarkupAdapter AlignCenter { get; } = new MarkupAdapter("<align=\"center\">", "</align>");

        /// <summary>
        /// 右对齐
        /// </summary>
        public static MarkupAdapter AlignRight { get; } = new MarkupAdapter("<align=\"right\">", "</align>");

        /// <summary>
        /// 透明度
        /// </summary>
        /// <param name="alpha">透明度</param>
        /// <returns>结果</returns>
        public static MarkupAdapter Alpha(float alpha)
        {
            alpha = Mathf.Clamp01(alpha);
            var alphaValue = ((int) (alpha * 255)).ToString("x2");
            var leftMark = BuildStr("<alpha=#", alphaValue, ">");
            var rightMark = "</alpha>";
            return new MarkupAdapter(leftMark, rightMark);
        }

        /// <summary>
        /// 字符间距(pixel/font units)
        /// </summary>
        /// <param name="size">尺寸</param>
        /// <param name="format">尺寸格式</param>
        /// <returns>结果</returns>
        public static MarkupAdapter CharacterSpace(float size, SizeFormat format)
        {
            var leftMark = BuildStr("<cspace=", size, GetSizeUnit(format), ">");
            var rightMark = "</cspace>";
            return new MarkupAdapter(leftMark, rightMark);
        }

        /// <summary>
        /// 字体
        /// </summary>
        /// <param name="fontAssetName">字体资源名</param>
        /// <returns>结果</returns>
        public static MarkupAdapter Font(string fontAssetName)
        {
            var leftMark = BuildStr("<font=\"", fontAssetName, "\">");
            var rightMark = "</font>";
            return new MarkupAdapter(leftMark, rightMark);
        }

        /// <summary>
        /// 缩进(pixels/font units/percentages)
        /// </summary>
        /// <param name="size">尺寸</param>
        /// <param name="format">尺寸格式</param>
        /// <returns>结果</returns>
        public static MarkupAdapter Indentation(float size, SizeFormat format)
        {
            var leftMark = BuildStr("<cspace=", GetSizeUnit(format), ">");
            var rightMark = "</cspace>";
            return new MarkupAdapter(leftMark, rightMark);
        }

        /// <summary>
        /// 行高
        /// </summary>
        /// <param name="percentages">百分比</param>
        /// <returns>结果</returns>
        public static MarkupAdapter LineHeight(int percentages)
        {
            var leftMark = BuildStr("<line-height=", percentages, "%>");
            var rightMark = "</line-height>";
            return new MarkupAdapter(leftMark, rightMark);
        }

        /// <summary>
        /// 行缩进(pixels/font units/percentages)
        /// </summary>
        /// <param name="size">尺寸</param>
        /// <param name="format">尺寸格式</param>
        /// <returns>结果</returns>
        public static MarkupAdapter LineIndentation(float size, SizeFormat format)
        {
            var leftMark = BuildStr("<line-indent=", size, GetSizeUnit(format), ">");
            var rightMark = "</line-indent>";
            return new MarkupAdapter(leftMark, rightMark);
        }

        /// <summary>
        /// 链接
        /// </summary>
        /// <param name="id">id</param>
        /// <returns>结果</returns>
        public static MarkupAdapter Link(string id)
        {
            var leftMark = BuildStr("<link=\"", id, "\">");
            var rightMark = "</link>";
            return new MarkupAdapter(leftMark, rightMark);
        }

        /// <summary>
        /// 全部小写
        /// </summary>
        public static MarkupAdapter Lowercase { get; } = new MarkupAdapter("<lowercase>", "</lowercase>");

        /// <summary>
        /// 全部大写
        /// </summary>
        public static MarkupAdapter Uppercase { get; } = new MarkupAdapter("<uppercase>", "</uppercase>");

        /// <summary>
        /// 全部大写
        /// </summary>
        public static MarkupAdapter AllCaps { get; } = new MarkupAdapter("<allcaps>", "</allcaps>");

        /// <summary>
        /// 全部大写（原本非大写的字符略微缩小尺寸）
        /// </summary>
        public static MarkupAdapter SmallCaps { get; } = new MarkupAdapter("<smallcaps>", "</smallcaps>");


        /// <summary>
        /// 边缘空白(pixels/font units/percentages)
        /// </summary>
        /// <param name="size">尺寸</param>
        /// <param name="format">尺寸格式</param>
        /// <returns>结果</returns>
        public static MarkupAdapter Margin(float size, SizeFormat format)
        {
            var leftMark = BuildStr("<margin=", size, GetSizeUnit(format), ">");
            var rightMark = "</margin>";
            return new MarkupAdapter(leftMark, rightMark);
        }

        /// <summary>
        /// 高亮
        /// </summary>
        /// <param name="color">高亮颜色</param>
        /// <returns>结果</returns>
        public static MarkupAdapter Mark(Color color)
        {
            var leftMark = BuildStr("<mark=", ColorToMarkup(color), ">");
            var rightMark = "</color>";
            return new MarkupAdapter(leftMark, rightMark);
        }

        /// <summary>
        /// 等宽字符(pixels/font units)
        /// </summary>
        /// <param name="size">尺寸</param>
        /// <param name="format">尺寸格式</param>
        /// <returns>结果</returns>
        public static MarkupAdapter MonoSpace(float size, SizeFormat format)
        {
            var leftMark = BuildStr("<mspace=", size, GetSizeUnit(format), ">");
            var rightMark = "</mspace>";
            return new MarkupAdapter(leftMark, rightMark);
        }

        /// <summary>
        /// 不处理标签
        /// </summary>
        public static MarkupAdapter Noparse { get; } = new MarkupAdapter("<noparse>", "</noparse>");

        /// <summary>
        /// 不中断单词换行
        /// </summary>
        public static MarkupAdapter NoBreakingSpaces { get; } = new MarkupAdapter("<nobr>", "</nobr>");

        /// <summary>
        /// 分割段落
        /// </summary>
        public static MarkupAdapter PageBreak { get; } = new MarkupAdapter("<page>", "</page>");

        /// <summary>
        /// 水平位置(pixels/font units/percentages)
        /// </summary>
        /// <param name="size">尺寸</param>
        /// <param name="format">尺寸格式</param>
        /// <returns>结果</returns>
        public static MarkupAdapter HorizontalPosition(int size, SizeFormat format)
        {
            var singleMark = BuildStr("<pos=", size, GetSizeUnit(format), ">");
            return new MarkupAdapter(singleMark);
        }

        /// <summary>
        /// 字体尺寸(pixels/font units/percentages)
        /// </summary>
        /// <param name="size">尺寸</param>
        /// <param name="format">尺寸格式</param>
        /// <returns>结果</returns>
        public static MarkupAdapter Size(int size, SizeFormat format)
        {
            var leftMark = BuildStr("<size=", size, GetSizeUnit(format), ">");
            var rightMark = "</size>";
            return new MarkupAdapter(leftMark, rightMark);
        }

        /// <summary>
        /// 水平留空(pixels/font units)
        /// </summary>
        /// <param name="size">尺寸</param>
        /// <param name="format">尺寸格式</param>
        /// <returns>结果</returns>
        public static MarkupAdapter HorizontalSpace(int size, SizeFormat format)
        {
            var singleMark = BuildStr("<space=", size, GetSizeUnit(format), ">");
            return new MarkupAdapter(singleMark);
        }

        #region Sprite

        /// <summary>
        /// 精灵
        /// </summary>
        /// <param name="assetName">图集</param>
        /// <param name="spriteName">名字</param>
        /// <returns>结果</returns>
        public static MarkupAdapter Sprite(string assetName, string spriteName)
        {
            var singleMark = BuildStr("<sprite=", assetName, " name=", spriteName, ">");
            return new MarkupAdapter(singleMark);
        }

        /// <summary>
        /// 精灵
        /// </summary>
        /// <param name="assetName">图集</param>
        /// <param name="index">索引</param>
        /// <returns>结果</returns>
        public static MarkupAdapter Sprite(string assetName, int index)
        {
            var singleMark = BuildStr("<sprite=", assetName, " index=", index, ">");
            return new MarkupAdapter(singleMark);
        }

        /// <summary>
        /// 精灵(默认图集)
        /// </summary>
        /// <param name="spriteName">名字</param>
        /// <returns>结果</returns>
        public static MarkupAdapter Sprite(string spriteName)
        {
            var singleMark = BuildStr("<sprite= name=", spriteName, ">");
            return new MarkupAdapter(singleMark);
        }

        /// <summary>
        /// 精灵(默认图集)
        /// </summary>
        /// <param name="index">索引</param>
        /// <returns>结果</returns>
        public static MarkupAdapter Sprite(int index)
        {
            var singleMark = BuildStr("<sprite=", index, ">");
            return new MarkupAdapter(singleMark);
        }

        /// <summary>
        /// 精灵
        /// </summary>
        /// <param name="assetName">图集</param>
        /// <param name="spriteName">名字</param>
        /// <param name="color">颜色</param>
        /// <returns>结果</returns>
        public static MarkupAdapter Sprite(string assetName, string spriteName, Color color)
        {
            var singleMark = BuildStr("<sprite=", assetName, " name=", spriteName, " color=", ColorToMarkup(color), ">");
            return new MarkupAdapter(singleMark);
        }

        /// <summary>
        /// 精灵
        /// </summary>
        /// <param name="assetName">图集</param>
        /// <param name="index">索引</param>
        /// <param name="color">颜色</param>
        /// <returns>结果</returns>
        public static MarkupAdapter Sprite(string assetName, int index, Color color)
        {
            var singleMark = BuildStr("<sprite=", assetName, " index=", index, " color=", ColorToMarkup(color), ">");
            return new MarkupAdapter(singleMark);
        }

        /// <summary>
        /// 精灵(默认图集)
        /// </summary>
        /// <param name="spriteName">名字</param>
        /// <param name="color">颜色</param>
        /// <returns>结果</returns>
        public static MarkupAdapter Sprite(string spriteName, Color color)
        {
            var singleMark = BuildStr("<sprite= name=", spriteName, " color=", ColorToMarkup(color), ">");
            return new MarkupAdapter(singleMark);
        }

        /// <summary>
        /// 精灵(默认图集)
        /// </summary>
        /// <param name="index">索引</param>
        /// <param name="color">颜色</param>
        /// <returns>结果</returns>
        public static MarkupAdapter Sprite(int index, Color color)
        {
            var singleMark = BuildStr("<sprite=", index, " color=", ColorToMarkup(color), ">");
            return new MarkupAdapter(singleMark);
        }

        #endregion

        /// <summary>
        /// 下划线
        /// </summary>
        public static MarkupAdapter Underline { get; } = new MarkupAdapter("<u>", "</u>");

        /// <summary>
        /// 删除线/中划线
        /// </summary>
        public static MarkupAdapter Strikethrough { get; } = new MarkupAdapter("<s>", "</s>");

        /// <summary>
        /// 样式
        /// </summary>
        /// <param name="style">样式</param>
        /// <returns>结果</returns>
        public static MarkupAdapter Style(string style)
        {
            var leftMark = BuildStr("<style=\"", style, "\">");
            var rightMark = "</style>";
            return new MarkupAdapter(leftMark, rightMark);
        }

        /// <summary>
        /// 上标/上角文字
        /// </summary>
        public static MarkupAdapter Superscript { get; } = new MarkupAdapter("<sup>", "</sup>");

        /// <summary>
        /// 下标/下角文字
        /// </summary>
        public static MarkupAdapter Subscript { get; } = new MarkupAdapter("<sub>", "</sub>");

        /// <summary>
        /// 垂直偏移(pixels/font units)
        /// </summary>
        /// <param name="size">尺寸</param>
        /// <param name="format">尺寸格式</param>
        /// <returns>结果</returns>
        public static MarkupAdapter VerticalOffset(int size, SizeFormat format)
        {
            var singleMark = BuildStr("<voffset=", size, GetSizeUnit(format), ">");
            return new MarkupAdapter(singleMark);
        }

        /// <summary>
        /// 字体宽度(pixels/font units/percentages)
        /// </summary>
        /// <param name="size">尺寸</param>
        /// <param name="format">尺寸格式</param>
        /// <returns>结果</returns>
        public static MarkupAdapter Width(int size, SizeFormat format)
        {
            var leftMark = BuildStr("<width=", size, GetSizeUnit(format), ">");
            var rightMark = "</width>";
            return new MarkupAdapter(leftMark, rightMark);
        }

        /// <summary>
        /// 获取尺寸单位
        /// </summary>
        /// <param name="format">格式</param>
        /// <returns>结果</returns>
        private static string GetSizeUnit(SizeFormat format)
        {
            switch (format)
            {
                case SizeFormat.Pixels: return "";
                case SizeFormat.FontUnits: return "em";
                case SizeFormat.Percentages: return "%";
            }

            return "";
        }
    }
}
