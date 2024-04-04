using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinavHazirlik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public List<Kisi> kisiler1 = new List<Kisi>();
        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int sifre = Convert.ToInt32(textBox2.Text);
            foreach (var kisi in kisiler1)
            {
                if (sifre == kisi.Sifre)
                {
                    Form3 form3 = new Form3();
                    form3.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Girilen bilgiler yanlış");
                }
             }
        }
    }
}
