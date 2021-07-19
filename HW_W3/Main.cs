using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW_W3
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Taxbtn_Click(object sender, EventArgs e)
        {
            new TaxForm().Show();
        }

        private void VLTaxbtn_Click(object sender, EventArgs e)
        {
            new VLTaxFrorm().Show();
        }
    }
}
