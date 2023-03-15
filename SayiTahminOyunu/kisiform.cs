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
    public partial class kisiform : Form
    {
        public kisiform()
        {
            InitializeComponent();
            MessageBox.Show("Aklımdan bir sayı tuttum.");
        }
        public int skor = 100;
        public int sayi1;
        public int hak = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            butonform butonform = new butonform();
            butonform.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
                       
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = true;
            label2.Text = ("Skor: " + skor.ToString());

            if (Convert.ToInt32(textBox1.Text) > sayi1)
            {
                MessageBox.Show("Aşağı");
                hak++;
                skor -= 10;
            }
            else if (Convert.ToInt32(textBox1.Text) < sayi1)
            {
                MessageBox.Show("Yukarı");
                hak++;
                skor -= 10;
            }
            else
            {
                MessageBox.Show("Tebrikler");
                button2.Visible = true;
                label2.Text =("Skor: " + skor.ToString());
               
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            sayi1 = rnd.Next(1, 100);
            label3.Text = sayi1.ToString();
            button3.Visible = false;
        }
    }
}
