using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace panel
{
    internal class PnlMain : Panel
    {

        private Label label;
        public PnlMain(Form form)
        {
            label = new Label();

            label.Text = "MAIN";
            label.Location = new Point(159, 17);
            label.Height = 20;
            label.Width = 47;

            base.BackColor = Color.LightBlue;
            base.Location = new Point(0,73) ;
            base.Width = 388;
            base.Height = 377 / 2;
            base.Name = "pnlMain";
            base.Anchor = AnchorStyles.Left | AnchorStyles.Top;
            //base.Dock = DockStyle.Fill;
            base.Controls.Add(label);
        }
    }
}
