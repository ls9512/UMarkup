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
	* 1.1. [Extension Style](#ExtensionStyle)
	* 1.2. [Method Style](#MethodStyle)
* 2. [Supported Tags](#SupportedTags)
	* 2.1. [Font Sytle](#FontSytle)
	* 2.2. [Color Sytle](#ColorSytle)
	* 2.3. [Other](#Other)
* 3. [Extension for TextMeshPro](#ExtensionforTextMeshPro)
	* 3.1. [Supported Tags](#SupportedTags-1)
	* 3.2. [Supported Size Formart](#SupportedSizeFormart)

<!-- vscode-markdown-toc-config
	numbering=true
	autoSave=true
	/vscode-markdown-toc-config -->
<!-- /vscode-markdown-toc -->

##  1. <a name='Howtouse'></a>How to use
###  1.1. <a name='ExtensionStyle'></a>Extension Style
``` cs
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
```

###  1.2. <a name='MethodStyle'></a>Method Style 
``` cs
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
##  3. <a name='ExtensionforTextMeshPro'></a>Extension for TextMeshPro
You can also use **UMarkup** to build strings for **TextMeshPro**. The supported tag styles are as follows:

###  3.1. <a name='SupportedTags-1'></a>Supported Tags
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

###  3.2. <a name='SupportedSizeFormart'></a>Supported Size Formart
* Pixels
* FontUnits
* Percentages