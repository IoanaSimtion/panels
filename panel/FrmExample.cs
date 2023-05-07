using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace panel
{
    public partial class FrmExample : Form
    {

        private PnlHeader pnlHeader;
        private PnlFooter pnlFooter;
        private PnlMain pnlMain;
        private PnlNews pnlNews;
        private PnlAbout pnlAbout;
        private PnlLinks pnlLinks;
        private PnlAds pnlAds;
        private PnlComboBoxes pnlComboBoxes;

        
        public FrmExample()
        {
            InitializeComponent();

            this.setFirstPage();

            
        }

        private void FrmExample_Load(object sender, EventArgs e)
        {

        }

        private void cmbBoxHeader_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void setFirstPage()
        {
            pnlHeader = new PnlHeader(this);
            this.Controls.Add(pnlHeader);

            pnlFooter = new PnlFooter(this);
            this.Controls.Add(pnlFooter);

            pnlMain = new PnlMain(this);
            this.Controls.Add(pnlMain);

            pnlNews = new PnlNews(this);
            this.Controls.Add(pnlNews);

            pnlAbout = new PnlAbout(this);
            this.Controls.Add(pnlAbout);

            pnlAds = new PnlAds(this);
            this.Controls.Add(pnlAds);

            pnlLinks = new PnlLinks(this);
            this.Controls.Add(pnlLinks);

            pnlComboBoxes = new PnlComboBoxes(this);
            this.Controls.Add(pnlComboBoxes);
        }
    }
}
