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

        public PnlAbout(Form from)
        {
            label = new Label();
            label.Text = "ABOUT";
            label.Location = new Point(81, 17);
            label.Size = new Size(70, 100);

            base.BackColor = Color.Plum;
            Name = "pnlAbout";
            Location = new Point(388, 73);
            Size = new Size(200, 61);
            base.Anchor = AnchorStyles.Left | AnchorStyles.Top;
            //base.Dock = DockStyle.Fill;
            Controls.Add(label);

        }
    }
}
