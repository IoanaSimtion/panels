using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace panel.about
{
    internal class PnlAbout : Panel
    {
        private Label label;

        public PnlAbout()
        {
            label = new Label();
            label.Text = "ABOUT";
            //label.Location = new Point(81, 17);
            label.Size = new Size(70, 100);
            label.Dock = DockStyle.Fill;
            label.TextAlign = ContentAlignment.TopCenter;

            base.BackColor = Color.Plum;
            Name = "pnlAbout";
            //Location = new Point(388, 73);
            //Size = new Size(200, 61);
         
            base.Dock = DockStyle.Fill;
            Controls.Add(label);

        }
    }
}
