using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace panel.header
{
    internal class PnlHeader3 : PnlHeader
    {
        public PnlHeader3(Form form) : base(form)
        {
            Label = "HEADER3";

            Name = "pnlHeader3";

            base.BackColor = Color.RoyalBlue;
        }
    }
}
