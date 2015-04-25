﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Ohana3DS_Rebirth.GUI
{
    class DrawingHelper
    {
        /// <summary>
        ///     Draws the face of a button.
        /// </summary>
        /// <param name="g">The graphics you want to render to</param>
        /// <param name="rect">Rectangle with position/size the face will be rendered</param>
        /// <param name="color1">First color of the gradient (Outline)</param>
        /// <param name="color2">2nd color of the gradient (Outline)</param>
        /// <param name="bgColor1">First color of the gradient (Background)</param>
        /// <param name="bgColor2">2nd color of the gradient (Background)</param>
        public static void drawButtonFace(Graphics g, Rectangle rect, Color color1, Color color2, Color bgColor1, Color bgColor2)
        {
            Rectangle rect2 = new Rectangle(rect.X + 1, rect.Y, rect.Width - 2, rect.Height - 1);
            g.FillRectangle(new LinearGradientBrush(rect2, bgColor1, bgColor2, LinearGradientMode.Vertical), rect2);
            g.DrawLine(new Pen(color1), new Point(rect.X + 1, rect.Y), new Point((rect.X + rect.Width) - 2, rect.Y));
            g.DrawLine(new Pen(new LinearGradientBrush(rect, color1, color2, LinearGradientMode.Vertical)), new Point(rect.X, rect.Y + 1), new Point(rect.X, (rect.Y + rect.Height) - 2));
            g.DrawLine(new Pen(new LinearGradientBrush(rect, color1, color2, LinearGradientMode.Vertical)), new Point((rect.X + rect.Width) - 1, rect.Y + 1), new Point((rect.X + rect.Width) - 1, (rect.Y + rect.Height) - 2));
            g.DrawLine(new Pen(color2), new Point(rect.X + 1, (rect.Y + rect.Height) - 1), new Point((rect.X + rect.Width) - 2, (rect.Y + rect.Height) - 1));
        }
    }
}