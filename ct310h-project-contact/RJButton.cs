// Source: https://github.com/RJCodeAdvance/Custom-Button-WinForm/blob/main/RJButton.cs
// Modified by ChatGPT

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace ct310h_project_contact.RJControls
{
    public class RJButton : Button
    {
        // Fields
        private int borderSize = 0;
        private int borderRadius = 0;
        private Color borderColor = Color.PaleVioletRed;

        private Color normalBackColor;
        private Color hoverBackColor = Color.FromArgb(100, Color.Gray); // Semi-transparent hover effect
        private bool isHovering = false;

        // Properties
        [Category("RJ Code Advance")]
        public int BorderSize
        {
            get { return borderSize; }
            set { borderSize = value; this.Invalidate(); }
        }

        [Category("RJ Code Advance")]
        public int BorderRadius
        {
            get { return borderRadius; }
            set { borderRadius = value; this.Invalidate(); }
        }

        [Category("RJ Code Advance")]
        public Color BorderColor
        {
            get { return borderColor; }
            set { borderColor = value; this.Invalidate(); }
        }

        [Category("RJ Code Advance")]
        public Color BackgroundColor
        {
            get { return this.BackColor; }
            set { this.BackColor = value; normalBackColor = value; }
        }

        [Category("RJ Code Advance")]
        public Color HoverColor
        {
            get { return hoverBackColor; }
            set { hoverBackColor = Color.FromArgb(100, value); }
        }

        [Category("RJ Code Advance")]
        public Color TextColor
        {
            get { return this.ForeColor; }
            set { this.ForeColor = value; }
        }

        // Constructor
        public RJButton()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.Size = new Size(150, 40);
            this.BackColor = Color.MediumSlateBlue;
            this.ForeColor = Color.White;
            normalBackColor = this.BackColor;

            this.Resize += Button_Resize;
            this.MouseEnter += RJButton_MouseEnter;
            this.MouseLeave += RJButton_MouseLeave;
        }

        // Hover effect handlers
        private void RJButton_MouseEnter(object sender, EventArgs e)
        {
            isHovering = true;
            this.Invalidate(); // Force repaint
        }

        private void RJButton_MouseLeave(object sender, EventArgs e)
        {
            isHovering = false;
            this.Invalidate(); // Force repaint
        }

        // Rounded button rendering
        private GraphicsPath GetFigurePath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2F;

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();
            return path;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);

            Rectangle rectSurface = this.ClientRectangle;
            Rectangle rectBorder = Rectangle.Inflate(rectSurface, -borderSize, -borderSize);
            int smoothSize = borderSize > 0 ? borderSize : 2;

            using (GraphicsPath pathSurface = GetFigurePath(rectSurface, borderRadius))
            using (GraphicsPath pathBorder = GetFigurePath(rectBorder, borderRadius - borderSize))
            using (Pen penSurface = new Pen(this.Parent.BackColor, smoothSize))
            using (Pen penBorder = new Pen(borderColor, borderSize))
            {
                pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                //Button surface
                this.Region = new Region(pathSurface);
                //Draw surface border for HD result
                pevent.Graphics.DrawPath(penSurface, pathSurface);

                //Button border                    
                if (borderSize >= 1)
                    //Draw control border
                    pevent.Graphics.DrawPath(penBorder, pathBorder);

                // Remove clipping so hover effect applies correctly
                pevent.Graphics.ResetClip();

                // Draw hover effect on top of everything
                if (isHovering)
                {
                    using (SolidBrush hoverBrush = new SolidBrush(hoverBackColor))
                    {
                        pevent.Graphics.FillPath(hoverBrush, pathSurface);
                    }
                }

                // Draw border
                if (borderSize >= 1)
                {
                    pevent.Graphics.DrawPath(penBorder, pathBorder);
                }
            }
        }

        private void Button_Resize(object sender, EventArgs e)
        {
            if (borderRadius > this.Height)
                borderRadius = this.Height;
        }
    }
}
