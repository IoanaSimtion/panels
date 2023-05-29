using panel.header;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace panel.footer
{
    internal class PnlFooter : Panel
    {
        private ComboBox comboBox;

        private Label label;

        Example3 ex3;



        public PnlFooter(Example3 ex3)
        {

            this.ex3 = ex3;

            label = new Label();

            label.Text = "FOOTER";
            label.Size = new Size(base.Width / 2, base.Height / 2);
            label.Dock = DockStyle.Fill;
            label.TextAlign = ContentAlignment.TopCenter;
            
            setComboBox();

            base.BackColor = Color.SkyBlue;
            Height = 100;
            Name = "pnlFooter";
            base.Dock = DockStyle.Bottom;
            Controls.Add(label);
            
        }

        void setComboBox()
        {

            comboBox = new ComboBox();
            comboBox.Name = "cmbBoxHeader";
            comboBox.Text = "Select header";
            comboBox.Location = new Point(20,30);
            comboBox.Items.Add("Header1");
            comboBox.Items.Add("Header2");
            comboBox.Items.Add("Header3");
            comboBox.Items.Add("Header4");
            comboBox.Size = new Size(120, 28);

            this.Controls.Add(comboBox);


            comboBox.SelectedIndexChanged += test_SelectedIndexChanged;


        }

        public void test_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            ex3.eraseCurrentHeader();
            this.PerformLayout();

            switch (comboBox.SelectedItem.ToString())
            {

                case "Header1":
                    ex3.panelContainer.Controls.Add(new PnlHeader());
                    break;
                case "Header2":
                      ex3.panelContainer.Controls.Add(new PnlHeader2());
                    break;
                case "Header3":
                    ex3.panelContainer.Controls.Add(new PnlHeader3());
                    break;
                case "Header4":
                    ex3.panelContainer.Controls.Add(new PnlHeader4());
                    break;

            }

        }

       
    }
}
