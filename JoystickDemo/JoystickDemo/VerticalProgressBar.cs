using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibHHControlTest
{
    public class VerticalProgressBar : ProgressBar
    {
        public VerticalProgressBar()
        {
            this.SetStyle(ControlStyles.UserPaint, true);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Rectangle rect = new Rectangle(base.ClientRectangle.Location, new Size(base.Width, base.Height));
            ProgressBarRenderer.DrawVerticalBar(e.Graphics, rect);
            LinearGradientBrush lb = new LinearGradientBrush(new Rectangle(base.ClientRectangle.X, base.ClientRectangle.Y + base.ClientRectangle.Height - base.Height * base.Value / base.Maximum, base.Width, base.Height * base.Value / base.Maximum + 1), Color.White, Color.Red, 0F);
            e.Graphics.FillRectangle(lb, new Rectangle(base.ClientRectangle.X, base.ClientRectangle.Y + base.ClientRectangle.Height - base.Height * base.Value / 100, base.Width, base.Height * base.Value / base.Maximum));
        }
    }
}
