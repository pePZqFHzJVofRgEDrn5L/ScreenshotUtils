using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms.Design;

namespace ScreenshotUtils.ControlExt
{
    public class ColorBoxDesginer : ControlDesigner
    {
        public override SelectionRules SelectionRules
        {
            get
            {
                return base.SelectionRules & ~SelectionRules.AllSizeable;
            }
        }
    }
}
