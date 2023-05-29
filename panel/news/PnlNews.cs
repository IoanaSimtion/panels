using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace panel.news
{
    internal class PnlNews : Panel
    {
        private Label label;

        public PnlNews()
        {
            label = new Label();
            label.Text = "NEWS";
            //label.Location = new Point(81, 68);
            label.Size = new Size(100, 100);
            label.Dock = DockStyle.Fill;
            label.TextAlign = ContentAlignment.TopCenter;

            base.BackColor = Color.Orchid;
            Name = "pnlNews";
            base.Dock = DockStyle.Fill;
            Controls.Add(label);

        }

    }
}
