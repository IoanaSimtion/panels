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
    public partial class FrmExample2 : Form
    {
        Panel panelContainer;

        TableLayoutPanel tableLayoutPanel;

        void setMainContainer()
        {
            panelContainer = new Panel();
            //panelContainer.Height = 1000;
            panelContainer.PerformLayout();
            panelContainer.Dock = DockStyle.Fill;
            //panelContainer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.Controls.Add(panelContainer);
        }

        void setTableLayoutPanel(Panel panel)
        {
            tableLayoutPanel = new TableLayoutPanel();
            tableLayoutPanel.Dock = DockStyle.Fill;
            tableLayoutPanel.RowCount = 2;
            tableLayoutPanel.ColumnCount = 2;
            for (int row = 0; row < tableLayoutPanel.RowCount; row++)
            {
                for (int col = 0; col < tableLayoutPanel.ColumnCount; col++)
                {
                    switch (row)
                    {
                        case 0:
                            if (col == 0)
                            {
                                Panel panel1 = new PnlAbout();
                                //panel.BackColor = Color.LightGray;
                                //panel.Dock = DockStyle.Fill;
                                tableLayoutPanel.Controls.Add(panel1, col, row);
                                panel1.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom;
                            }
                            else
                            {
                                Panel panel2 = new PnlNews();
                                //panel.BackColor = Color.LightGray;
                                //panel.Dock = DockStyle.Fill;
                                tableLayoutPanel.Controls.Add(panel2, col, row);
                                panel2.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom;
                            }
                            break;
                        case 1:
                            if (col == 0)
                            {
                                Panel panel3 = new PnlLinks();
                                //panel.BackColor = Color.LightGray;
                                //panel.Dock = DockStyle.Fill;
                                tableLayoutPanel.Controls.Add(panel3, col, row);
                                panel3.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom;
                            }
                            else
                            {
                                Panel panel4 = new PnlAds();
                                //panel.BackColor = Color.LightGray;
                                //panel.Dock = DockStyle.Fill;
                                tableLayoutPanel.Controls.Add(panel4, col, row);
                                panel4.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom;
                            }
                            break;
                    }

                }
            }
            panel.Controls.Add(tableLayoutPanel);
        }
        public FrmExample2()
        {
            InitializeComponent();

            setMainContainer();

            //Panel asidePanel = new Panel();
            //asidePanel.BackColor = Color.Coral;
            //asidePanel.Width = 400;
            //asidePanel.Dock = DockStyle.Left;
            //asidePanel.Controls.Add(new PnlMain(asidePanel));
            //panelContainer.Controls.Add(asidePanel);


            //Panel footerPanel = new Panel();
            //footerPanel.BackColor = Color.Violet;
            //footerPanel.Height = 100;
            //footerPanel.Dock = DockStyle.Bottom;
            //footerPanel.Controls.Add(new PnlFooter(footerPanel));
            //panelContainer.Controls.Add(footerPanel);


            //Panel mainPanel = new Panel();
            //mainPanel.BackColor = Color.Teal;
            //mainPanel.Dock = DockStyle.Fill;
            //mainPanel.Controls.Add(tableLayoutPanel);
            ////setTableLayoutPanel(mainPanel);
            //mainPanel.Controls.Add(new PnlAbout(mainPanel));
            //mainPanel.Controls.Add(new PnlNews(mainPanel));
            //mainPanel.Controls.Add(new PnlLinks(mainPanel));
            //mainPanel.Controls.Add(new PnlAds(mainPanel));
            //panelContainer.Controls.Add(mainPanel);


            //Panel headerPanel = new Panel();
            //headerPanel.BackColor = Color.Blue;
            //headerPanel.Height = 100;
            //headerPanel.Dock = DockStyle.Top;
            //panelContainer.Controls.Add(headerPanel);
            //headerPanel.Controls.Add(new PnlHeader(headerPanel));


        }

        private void FrmExample2_Load(object sender, EventArgs e)
        {

        }

       
    }
}
