using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ct310h_project_contact
{
    public partial class RoundButton : PictureBox
    {
        private int _borderSize = 2;
        private int _cornerRadius = 30;

        public RoundButton()
        {
            this.SizeMode = PictureBoxSizeMode.StretchImage; // Ensure image stretches to fit
            this.BackColor = Color.Blue;
        }

        [Category("Custom Appearance")]
        public int BorderSize
        {
            get { return _borderSize; }
            set
            {
                _borderSize = value;
                this.Invalidate();
            }
        }

        [Category("Custom Appearance")]
        public int CornerRadius
        {
            get { return _cornerRadius; }
            set
            {
                _cornerRadius = value;
                this.Invalidate();
            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            using (var gp = new GraphicsPath())
            {
                gp.AddEllipse(new Rectangle(0, 0, this.Width - 1, this.Height - 1));
                this.Region = new Region(gp);
            }
        }

    }
}