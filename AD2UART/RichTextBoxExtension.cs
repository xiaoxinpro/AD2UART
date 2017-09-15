﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DocDetector.Core.Extensions
{
    public static class RichTextBoxExtension
    {
        /// <summary>
        /// 富文本框扩展类
        /// </summary>
        /// <param name="rtBox">RichTextBox</param>
        /// <param name="text">增加的文本</param>
        /// <param name="color">颜色</param>
        /// <param name="addNewLine">是否换行</param>
        /// <example>RichTextBox1.AppendTextColorful("Your message here",Color.Green);</example>
        public static void AppendTextColorful(this RichTextBox rtBox, string text, Color color, bool addNewLine = true)
        {
            if (addNewLine)
            {
                text += Environment.NewLine;
            }
            rtBox.SelectionStart = rtBox.TextLength;
            rtBox.SelectionLength = 0;
            rtBox.SelectionColor = color;
            rtBox.AppendText(text);
            rtBox.SelectionColor = rtBox.ForeColor;
        }
    }
}
