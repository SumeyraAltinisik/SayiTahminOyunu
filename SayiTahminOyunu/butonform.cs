using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SayiTahminOyunu
{
    public partial class butonform : Form
    {
        public butonform()
        {
            InitializeComponent();
        }

        private void butonform_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pcform form1 = new pcform();
            form1.Show();
            this.Hide();

        }
    }
}
