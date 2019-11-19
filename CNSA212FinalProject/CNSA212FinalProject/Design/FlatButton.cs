using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace CNSA212FinalProject.Design
{
    public class FlatButton : Button
    {
        private Color CurrentBackColor;

        private Color onHoverBackColor = Color.FromArgb(100, 181, 246);
        private Color onDisableBackColor = Color.FromArgb(223, 223, 223);
        private Color onDisableTextColor = Color.FromArgb(159, 159, 159);

        public FlatButton()
        {
            BackColor = Color.FromArgb(33, 150, 243);
            ForeColor = Color.White;
            CurrentBackColor = BackColor;


            if (this.Enabled)
            {
                CurrentBackColor = BackColor;
                ForeColor = Color.White;
            }
            else
            {
                CurrentBackColor = onDisableBackColor;
                ForeColor = onDisableTextColor;
            }
        }

        public Color OnHoverBackColor
        {
            get { return onHoverBackColor; }
            set { onHoverBackColor = value; Invalidate(); }
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            CurrentBackColor = onHoverBackColor;
            Invalidate();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            CurrentBackColor = BackColor;
            Invalidate();
        }

        protected override void OnMouseDown(MouseEventArgs mevent)
        {
            base.OnMouseDown(mevent);
            CurrentBackColor = Color.FromArgb(33, 150, 243);
            Invalidate();
        }

        protected override void OnEnabledChanged(EventArgs e)
        {
            base.OnEnabledChanged(e);
            if (this.Enabled)
            {
                CurrentBackColor = BackColor;
                ForeColor = Color.White;
            } else
            {
                CurrentBackColor = onDisableBackColor;
                ForeColor = onDisableTextColor;
            }
            Invalidate();
        }

        protected override void OnMouseUp(MouseEventArgs mevent)
        {
            base.OnMouseUp(mevent);
            CurrentBackColor = BackColor;
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            pevent.Graphics.FillRectangle(new SolidBrush(CurrentBackColor), 0, 0, Width, Height);
            TextFormatFlags flags = TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter;
            TextRenderer.DrawText(pevent.Graphics, Text, Font, new Point(Width + 3, Height / 2), ForeColor, flags);
        }
    }
}

