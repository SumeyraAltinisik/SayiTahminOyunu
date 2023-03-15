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
    public partial class pcform : Form
    {
        public pcform()
        {
            InitializeComponent();
        }

        private void pcform_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            kisiform form2 = new kisiform();
            form2.Show();
            this.Hide();
        }
    }
}
