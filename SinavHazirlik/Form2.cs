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

    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
       
        public static List<Kisi> kisiler = new List<Kisi>();
        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.kisiler1 = kisiler;
            form1.Show();
            
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kisi kisi = new Kisi();
            kisi.kullaniciAdi = textBox2.Text;
            kisi.Sifre = Convert.ToInt32(textBox3.Text);
            kisiler.Add(kisi);

            


            if (textBox3.Text != textBox4.Text)
            {
                MessageBox.Show("şifre tekrar yanlış"); 
            }
             if(textBox5.Text != textBox6.Text)
            {
                MessageBox.Show("ipucu tekrar yanlış");
            }
        }
    }
}
