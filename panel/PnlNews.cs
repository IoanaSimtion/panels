﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace panel
{
    internal class PnlNews : Panel
    {
        private Label label;

        public PnlNews(Form from)
        {
            label = new Label();
            label.Text = "NEWS";
            label.Location = new Point(81, 68);
            label.Size = new Size(100, 100);

            base.BackColor = Color.Orchid;
            base.Name = "pnlNews";
            base.Location = new Point(586, 21);
            base.Size = new Size(214, 113);
            base.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
            base.Controls.Add(label);

        }
        
    }
}
