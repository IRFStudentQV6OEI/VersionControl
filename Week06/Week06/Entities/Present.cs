using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week06
{
    public class Present : Toy
    {
        public SolidBrush BoxColor { get; private set; }
        public SolidBrush Ribboncolor { get; private set; }

        public Present(Color colorbox, Color colorribbon)
        {
            BoxColor = new SolidBrush(colorbox);
            Ribboncolor = new SolidBrush(colorribbon);
        }
        protected override void DrawImage(Graphics g)
        {
            g.FillRectangle(BoxColor, 0, 0, Width, Height);
            g.FillRectangle(Ribboncolor, 0, Height/2-Width/10 , Width, Height / 5);
            g.FillRectangle(Ribboncolor, Width/2-Width/10, 0, Width/5 , Height);
        }
    }
}
