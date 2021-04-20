using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bagolyvar2
{
    public partial class Navigalo_Form : Form
    {
        public Navigalo_Form()
        {
            InitializeComponent();
        }

        private void btn_kolcsonzes_Click(object sender, EventArgs e)
        {
            Kölcsönző k = new Kölcsönző();
            k.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Késések k = new Késések();
            k.Show();
        }
    }
}
