using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace panel.links
{
    internal class PnlLinks : Panel
    {
        private Label label;
        public PnlLinks()
        {
            label = new Label();
            label.Text = "LINKS";
            //label.Location = new Point(81, 50);
            label.Size = new Size(100, 100);
            label.Dock = DockStyle.Fill;
            label.TextAlign = ContentAlignment.TopCenter;

            base.BackColor = Color.Orchid;
            Name = "pnlLinks";
          
            base.Dock = DockStyle.Fill;
            Controls.Add(label);

        }
    }
}
