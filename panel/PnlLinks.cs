using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace panel
{
    internal class PnlLinks : Panel
    {
        private Label label;
        public PnlLinks(Form from)
        {
            label = new Label();
            label.Text = "LINKS";
            label.Location = new Point(81, 50);
            label.Size = new Size(100, 100);

            base.BackColor = Color.Orchid;
            base.Name = "pnlLinks";
            base.Location = new Point(388, 100);
            base.Size = new Size(214, 100);
            base.Anchor = AnchorStyles.Left | AnchorStyles.Top;
            //base.Dock = DockStyle.Fill;
            base.Controls.Add(label);

        }
    }
}
