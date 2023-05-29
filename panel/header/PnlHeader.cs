using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace panel.header
{
    internal class PnlHeader : Panel
    {

        protected Label label;

        public PnlHeader()
        {

            Debug.WriteLine("Sunt in header baza");

            label = new Label();
            label.Text = "HEADER";
            label.Height = 20;
            label.Dock = DockStyle.Fill;
            label.TextAlign = ContentAlignment.TopCenter;

            Name = "pnlHeader";
            base.BackColor = Color.MediumPurple;
            Height = 100;           
            base.Dock = DockStyle.Top;
            Controls.Add(label);
            
        }
        public string Label
        {
            get { return label.Text; }
            set { label.Text = value; }
        }


    }
}
