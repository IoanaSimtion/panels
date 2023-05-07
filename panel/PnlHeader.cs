using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace panel
{
    internal class PnlHeader : Panel
    {

        private Label label;

        public PnlHeader(Form form)
        {
            label = new Label();
            label.Location = new Point(form.Width/2, 20);
            label.Text = "TEST";
            label.Height = 20;
            label.Width = 66;

            base.BackColor = Color.MediumPurple;
            base.Location = new Point(0, 0);
            base.Width = 800;
            base.Height = 73; 
            base.Name = "pnlHeader";
            base.Controls.Add(label);
            base.Anchor = AnchorStyles.Right | AnchorStyles.Left;
            base.Dock = DockStyle.Top;


        }       
        public string Label
        {
            get{ return label.Text; }
            set{ label.Text = value; }
        }

        
    }
}
