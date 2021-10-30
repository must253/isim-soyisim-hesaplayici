using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Boy_Yaş_Kilo_hesaplayıcı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string message = "Bu Programı Kapatmak İstediğine Emin Misin?";
            string title = "Uygulamayı Kapatmak";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                // Do something  
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox3.Text.Length == 0)
            {
                MessageBox.Show("Bir yeri boş bıraktın.");
            }
            else if (textBox4.Text.Length == 0)
            {
                MessageBox.Show("Bir yeri boş bıraktın.");
            }else
            {
                MessageBox.Show("İsim Ve Soy İsim: " + textBox3.Text + ' ' + textBox4.Text);
            }

           
        }

       
    }

}
