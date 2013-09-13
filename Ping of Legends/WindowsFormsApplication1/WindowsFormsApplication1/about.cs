using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace WindowsFormsApplication1
{
    public partial class about : Form
    {
        public about()
        {
            InitializeComponent();
        }

        private void twitter_Click(object sender, EventArgs e)
        {
            Process.Start("https://twitter.com/lolinflames");
        }

        private void donate_button_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.paypal.com/cgi-bin/webscr?cmd=_donations&business=eduardocabrerapaypal%40gmail%2ecom&lc=US&item_name=Eduardo%20Cabrera&no_note=0&currency_code=USD&bn=PP%2dDonationsBF%3abtn_donate_SM%2egif%3aNonHostedGuest");
        }
    }
}
