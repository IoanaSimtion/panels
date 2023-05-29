using panel.about;
using panel.ads;
using panel.footer;
using panel.header;
using panel.links;
using panel.main;
using panel.news;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace panel
{
    public partial class Example3 : Form
    {

        public Panel panelContainer;

        public Panel aside = new PnlAside();



        public Example3()
        {
            InitializeComponent();
            setMainContainer();

            configTable();



            panelContainer.Controls.Add(new PnlMain(panelContainer));
            panelContainer.Controls.Add(aside);



            panelContainer.Controls.Add(new PnlHeader());
            panelContainer.Controls.Add(new PnlFooter(this));

           





        }

        void setMainContainer()
        {
            panelContainer = new Panel();
            panelContainer.PerformLayout();
            panelContainer.Dock = DockStyle.Fill;
            this.Controls.Add(panelContainer);
        }

        private void Example3_Load(object sender, EventArgs e)
        {

        }

        void configTable()
        {
            TableLayoutPanel tableLayoutPanel;
            tableLayoutPanel = new TableLayoutPanel();

            tableLayoutPanel.Dock = DockStyle.Fill;


            tableLayoutPanel.RowCount = 2;
            tableLayoutPanel.ColumnCount = 2;

            tableLayoutPanel.Controls.Add(new PnlAbout(), 0, 0);
            tableLayoutPanel.Controls.Add(new PnlNews(), 1, 0);
            tableLayoutPanel.Controls.Add(new PnlLinks(), 0, 1);
            tableLayoutPanel.Controls.Add(new PnlAds(), 1, 1);


            aside.Controls.Add(tableLayoutPanel);

           
        }


        public void eraseCurrentHeader()
        {
            Debug.WriteLine("test");
            Control cautat = null;

            foreach (Control aux in this.panelContainer.Controls)
            {
                if (aux.Name.ToLower().Contains("pnlh"))
                {
                    cautat = aux;
                    Debug.WriteLine("test");
                   
                    PerformLayout();
                }
            }

            this.panelContainer.Controls.Remove(cautat);
            PerformLayout();

        }
    }

  
}
