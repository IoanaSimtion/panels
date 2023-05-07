using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace panel
{
    internal class PnlComboBoxes:Panel
    {
        public ComboBox comboBox;
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
        }
    }
}
