using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace panel.header
{
    internal class PnlHeader2 : PnlHeader
    {


        public PnlHeader2(Form form) : base(form)
        {

            Label = "HEADER2";

            Name = "pnlHeader2";

            base.BackColor = Color.SlateBlue;
        }


    }
}
