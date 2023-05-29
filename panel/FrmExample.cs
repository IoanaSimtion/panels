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

        public ComboBox comboBox;


        Panel panelContainer;

        //private FrmExample form= new FrmExample();

        void setComboBox()
        {

            comboBox = new ComboBox();
            comboBox.Name = "cmbBoxHeader";
            comboBox.Text = "Select header";
            comboBox.Location = new Point(30, 300);
            comboBox.Items.Add("Header1");
            comboBox.Items.Add("Header2");
            comboBox.Items.Add("Header3");
            comboBox.Items.Add("Header4");
            comboBox.Size = new Size(120, 28);

            base.BackColor = Color.Beige;
         
            this.Controls.Add(comboBox);
                     

            comboBox.SelectedIndexChanged += test_SelectedIndexChanged;


        }


        public void test_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Debug.WriteLine(comboBox.SelectedItem.ToString());

            eraseCurrentHeader();
            switch (comboBox.SelectedItem.ToString())
            {

                case "Header1":
                    //Debug.WriteLine("Sunt in header1");
                    //this.Controls.Add(new PnlHeader(this));
                    break;
                case "Header2":
                    //Debug.WriteLine("Sunt in header2");
                    //this.Controls.Add(new PnlHeader2(this));
                    break;
                case "Header3":
                    //Debug.WriteLine("Sunt in header3");
                    //this.Controls.Add(new PnlHeader3(this));
                    break;
                case "Header4":
                    //Debug.WriteLine("Sunt in header4");
                    //this.Controls.Add(new PnlHeader4(this));
                    break;
                //default: Debug.Write("da"); break;

            }

        }
               

        private void FrmExample_Load(object sender, EventArgs e)
        {

        }

       
        public void eraseCurrentHeader()
        {
            Control cautat = null;

            foreach(Control aux in this.Controls)
            {
                if (aux.Name.ToLower().Contains("pnlheader"))
                {
                    Debug.WriteLine("aici");

                    cautat = aux;
                }
            }
             this.Controls.Remove(cautat);
            if (cautat is Panel)
            {
               
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

            //this.Controls.Add(new PnlHeader4(this));

            //this.Controls.Add(new PnlFooter(this));

            //this.Controls.Add(new PnlMain(this));

            //this.Controls.Add(new PnlNews(this));

            //this.Controls.Add(new PnlAbout(this));

            //this.Controls.Add(new PnlAds(this));

            //this.Controls.Add(new PnlLinks(this));

            //setComboBox();
           
        }
    }
}
