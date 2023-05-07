using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace panel
{
    internal class PnlFooter : Panel
    {
        private Label label;
        public PnlFooter(Form form)
        {
            label = new Label();

            label.Text = "FOOTER";
            label.Location=new Point(364/2, 21);
            label.Width = 70;
            label.Height = 20;

            base.BackColor = Color.SkyBlue;
            base.Location = new Point(388, 200);
            base.Width = 412;
            base.Height = 61;
            base.Name = "pnlFooter";
            base.Anchor = AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Left;
            //base.Dock = DockStyle.Fill;
            base.Controls.Add(label);
        }
    }
}
