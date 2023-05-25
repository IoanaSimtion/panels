using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace panel.ads
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
            Name = "pnlAds";
            Location = new Point(586, 100);
            Size = new Size(214, 100);
            base.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
            //base.Dock = DockStyle.Fill;
            Controls.Add(label);

        }

    }
}
