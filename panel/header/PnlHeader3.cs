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
            base.Label = "HEADER3";

            base.Name = "pnlHeader3";

            base.BackColor = Color.RoyalBlue;
        }
    }
}
