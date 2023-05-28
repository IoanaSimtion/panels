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
        public PnlMain(Panel panelMain)
        {
            label = new Label();

            label.Text = "MAIN";
            label.AutoSize = false;
            label.Height = 20;
            label.Width = 47;
            label.Dock = DockStyle.Fill;
            label.TextAlign = ContentAlignment.TopCenter;

            base.BackColor = Color.LightBlue;
          
            Name = "pnlMain";
            base.Dock = DockStyle.Fill;
            Controls.Add(label);
        }
    }
}
