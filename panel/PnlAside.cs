using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using panel.about;
using panel.ads;
using panel.links;
using panel.news;

namespace panel
{
    internal class PnlAside : Panel
    {
        
        public PnlAside()
        {
            base.BackColor = Color.Teal;
            Name = "pnlAside";
            base.Dock = DockStyle.Right;


            Width = 400;
                   

        }

    }
}
