using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace panel.header
{
    internal class PnlHeader : Panel
    {

        private Label label;

        public PnlHeader(Form form)
        {
            label = new Label();
            label.Location = new Point(form.Width / 2, 20);
            label.Text = "HEADER";
            label.Height = 20;
            label.Width = 66;

            base.BackColor = Color.MediumPurple;
            Location = new Point(0, 0);
            Width = 800;
            Height = 73;
            Name = "pnlHeader";
            Controls.Add(label);
            base.Anchor = AnchorStyles.Right | AnchorStyles.Left;
            base.Dock = DockStyle.Top;


        }
        public string Label
        {
            get { return label.Text; }
            set { label.Text = value; }
        }


    }
}
