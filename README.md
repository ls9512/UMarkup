# UMarkup

**UMarkup** is a simplified extension for **Unity RichText Markup**，It can enhance the text style of **Log** / **UGUI Text** / **GUI Label**, also for **TextMeshPro**.

![topLanguage](https://img.shields.io/github/languages/top/ls9512/UMarkup)
![size](https://img.shields.io/github/languages/code-size/ls9512/UMarkup)
![issue](https://img.shields.io/github/issues/ls9512/UMarkup)
![license](https://img.shields.io/github/license/ls9512/UMarkup)
![last](https://img.shields.io/github/last-commit/ls9512/UMarkup)
[![996.icu](https://img.shields.io/badge/link-996.icu-red.svg)](https://996.icu)

<!-- vscode-markdown-toc -->
* 1. [How to use](#Howtouse)
	* 1.1. [Common Styles](#CommonStyles)
	* 1.2. [Extension Method](#ExtensionMethod)
	* 1.3. [Static Method](#StaticMethod)
* 2. [Supported Tags](#SupportedTags)
	* 2.1. [Font Sytle](#FontSytle)
	* 2.2. [Color Sytle](#ColorSytle)
	* 2.3. [Other](#Other)
* 3. [Custom Style](#CustomStyle)
* 4. [Extension for TextMeshPro](#ExtensionforTextMeshPro)
	* 4.1. [Supported Tags](#SupportedTags-1)
	* 4.2. [Supported Size Formart](#SupportedSizeFormart)

<!-- vscode-markdown-toc-config
	numbering=true
	autoSave=true
	/vscode-markdown-toc-config -->
<!-- /vscode-markdown-toc -->

##  1. <a name='Howtouse'></a>How to use
###  1.1. <a name='CommonStyles'></a>Common Styles
Use common styles in a concise way:
``` cs
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
```

###  1.2. <a name='ExtensionMethod'></a>Extension Method
Use extension methods to organize multiple different styles:
``` cs
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
```

###  1.3. <a name='StaticMethod'></a>Static Method 
``` cs
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
```
##  2. <a name='SupportedTags'></a>Supported Tags
###  2.1. <a name='FontSytle'></a>Font Sytle
* Size
* Bold
* Italic
###  2.2. <a name='ColorSytle'></a>Color Sytle
* Red
* Green
* Blue
* White
* Blank
* Yellow
* Cyan
* Magenta
* Gray
* Clear
* Color

###  2.3. <a name='Other'></a>Other
* Material
* Quad

##  3. <a name='CustomStyle'></a>Custom Style
Support for custom extended styles can be obtained by creating a **MarkupAdapter** with custom parameters.
``` cs
public static class MarkupCustomStyleSample
{
    // Custom single mark style
    public static MarkupAdapter CustomStyle1 { get; } = new MarkupAdapter("<singleMark>");

    // Custom left and right mark Style
    public static MarkupAdapter CustomStyle2 { get; } = new MarkupAdapter("<leftMark>", "</rightMark>");
}
```

##  4. <a name='ExtensionforTextMeshPro'></a>Extension for TextMeshPro
You can also use **UMarkup** to build strings for **TextMeshPro**. The supported tag styles are as follows:

###  4.1. <a name='SupportedTags-1'></a>Supported Tags
* AlignLeft
* AlignCenter
* AlignRight
* Alpha
* CharacterSpace
* Font
* Indentation
* LineHeight
* LineIndentation
* Link
* Lowercase
* Uppercase
* AllCaps
* SmallCaps
* Margin
* Mark
* MonoSpace
* Noparse
* NoBreakingSpaces
* PageBreak
* HorizontalPosition
* Size
* HorizontalSpace
* Sprite
* Underline
* Strikethrough
* Style
* Superscript
* Subscript
* VerticalOffset
* Width

###  4.2. <a name='SupportedSizeFormart'></a>Supported Size Formart
* Pixels
* FontUnits
* Percentages