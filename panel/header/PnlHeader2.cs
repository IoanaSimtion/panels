using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace panel.header
{
    internal class PnlHeader2 : PnlHeader
    {


        public PnlHeader2()
        {
            Debug.WriteLine(base.label.Text);
            base.ResetText();
            base.label.Text = "HEADER2 asdasdsa asdsadsa";

            base.Name = "pnlHeader2";

            base.BackColor = Color.Red;
            Debug.WriteLine(base.label.Text);
        }


    }
}
