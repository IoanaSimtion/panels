using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace panel.main
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
            Location = new Point(0, 73);
            Width = 388;
            Height = 377 / 2;
            Name = "pnlMain";
            base.Anchor = AnchorStyles.Left | AnchorStyles.Top;
            //base.Dock = DockStyle.Fill;
            Controls.Add(label);
        }
    }
}
