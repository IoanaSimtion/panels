using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace panel
{
    internal class PnlHeader4:PnlHeader
    {
        public PnlHeader4(Form form) : base(form)
        {
            this.Label = "HEADER4";

            base.Name = "pnlHeader4";

            base.BackColor = Color.Aqua;
        }
    }
}
