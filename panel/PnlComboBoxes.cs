using panel.header;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace panel
{
    internal class PnlComboBoxes:Panel
    {
        public ComboBox comboBox;

        private FrmExample form;
        public PnlComboBoxes(Form form)
        {
            comboBox = new ComboBox();
            comboBox.Name = "cmbBoxHeader";
            comboBox.Text = "Select header";
            comboBox.Location = new Point(30,280);
            comboBox.Items.Add("Header1");
            comboBox.Items.Add("Header2");
            comboBox.Items.Add("Header3");
            comboBox.Items.Add("Header4");
            comboBox.Size = new Size(120, 28);            

            base.BackColor = Color.Beige;
            base.Name = "pnlCmbBoxes";
            base.Dock = DockStyle.Bottom;
            base.Anchor = AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom;
            base.Size = new Size(1000, 600);
            base.Controls.Add(comboBox);

            this.form = form as FrmExample;

            comboBox.SelectedIndexChanged += test_SelectedIndexChanged;
            

        }


        public void test_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Debug.WriteLine(comboBox.SelectedItem.ToString());

            switch (comboBox.SelectedItem.ToString())
            {

                case "Header1":
                    Debug.WriteLine("Sunt in header1");
                    this.form.eraseCurrentHeader();
                    this.form.Controls.Add(new PnlHeader(this.form));
                    break;
                case "Header2":
                    Debug.WriteLine("Sunt in header2");
                    this.form.eraseCurrentHeader();
                    this.form.Controls.Add(new PnlHeader2(this.form));
                    break;
                case "Header3":
                    Debug.WriteLine("Sunt in header3");
                    this.form.eraseCurrentHeader();
                    this.form.Controls.Add(new PnlHeader3(this.form));
                    break;
                case "Header4":
                    Debug.WriteLine("Sunt in header4");
                    this.form.eraseCurrentHeader();
                    this.form.Controls.Add(new PnlHeader4(this.form));
                    break;
                default: Debug.Write("da"); break;

            }

        }
    }
}
