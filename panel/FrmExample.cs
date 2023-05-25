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
    public partial class FrmExample : Form
    {

       

        
        public FrmExample()
        {
            InitializeComponent();

            this.setFirstPage();

            
        }

        private void FrmExample_Load(object sender, EventArgs e)
        {

        }

       
        public void eraseCurrentHeader()
        {
            Control cautat = null;

            foreach(Control aux in this.Controls)
            {
                if (aux.Name.ToLower().Contains("header"))
                {
                    Debug.WriteLine("aici");

                    cautat = aux;
                }
            }

            if (cautat is Panel)
            {
                this.Controls.Remove(cautat);
            }
           
        }

        private void setFirstPage()
        {
            //this.Controls.Add(new PnlHeader(this));

            //eraseCurrentHeader();

            //this.Controls.Add(new PnlHeader2(this));
            //eraseCurrentHeader();

            //this.Controls.Add(new PnlHeader3(this));
            //eraseCurrentHeader();

            this.Controls.Add(new PnlHeader4(this));

            this.Controls.Add(new PnlFooter(this));

            this.Controls.Add(new PnlMain(this));

            this.Controls.Add(new PnlNews(this));

            this.Controls.Add(new PnlAbout(this));

            this.Controls.Add(new PnlAds(this));

            this.Controls.Add(new PnlLinks(this));

            this.Controls.Add(new PnlComboBoxes(this));
        }
    }
}
