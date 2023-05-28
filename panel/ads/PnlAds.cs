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

        public PnlAds()
        {
            label = new Label();
            label.Text = "ADS";
            //label.Location = new Point(81, 50);
            label.Size = new Size(100, 100);
            label.Dock = DockStyle.Fill;
            label.TextAlign = ContentAlignment.TopCenter;

            base.BackColor = Color.Plum;
            Name = "pnlAds";
            Location = new Point(586, 100);
           
            //base.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
            this.Dock = DockStyle.Fill;
            Controls.Add(label);

        }

    }
}
