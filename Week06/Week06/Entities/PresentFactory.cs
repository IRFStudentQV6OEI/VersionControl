using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week06
{
    public class PresentFactory : ItoyFactory
    {
        public Color Boxcolor { get; set; }
        public Color Ribboncolor { get; set; }
        public Toy CreateNew()
        {
            return new Present(Boxcolor,Ribboncolor);
        }
    }
}
