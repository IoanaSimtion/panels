using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace panel
{
    internal class PnlAds : Panel
    {
        private Label label;

        public PnlAds(Form from)
        {
            label = new Label();
            label.Text = "ADS";
            label.Location = new Point(81, 50);
            label.Size = new Size(100, 100);

            base.BackColor = Color.Plum;
            base.Name = "pnlAds";
            base.Location = new Point(586, 100);
            base.Size = new Size(214, 100);
            base.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
            //base.Dock = DockStyle.Fill;
            base.Controls.Add(label);

        }

    }
}
