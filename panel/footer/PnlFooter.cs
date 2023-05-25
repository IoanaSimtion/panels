using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace panel.footer
{
    internal class PnlFooter : Panel
    {
        private Label label;
        public PnlFooter(Form form)
        {
            label = new Label();

            label.Text = "FOOTER";
            label.Location = new Point(364 / 2, 21);
            label.Width = 70;
            label.Height = 20;

            base.BackColor = Color.SkyBlue;
            Location = new Point(388, 200);
            Width = 412;
            Height = 61;
            Name = "pnlFooter";
            base.Anchor = AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Left;
            //base.Dock = DockStyle.Fill;
            Controls.Add(label);
        }
    }
}
