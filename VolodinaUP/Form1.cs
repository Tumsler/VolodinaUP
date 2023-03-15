using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VolodinaUP
{
    public partial class Form1 : Form
    {
        public static string strTextChangeN { get; set; }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            Form1.strTextChangeN = textBox3.Text;
        }


        public Form1()
        {
            InitializeComponent();
            form2 = new Form2();
            form5 = new Form5();
        }
        Form2 form2;
        Form5 form5;
        string Login = "admin";
        string Password = "VOL";

        private void button1_Click(object sender, EventArgs e)
        {
            string Log = textBox1.Text;
            string Pas = textBox2.Text;
            if (Log == Login && Pas == Password)
            {
                form5.Show();
            }
            else
            {
                MessageBox.Show("Ошибка в логине или пароле. Попробуйте снова!");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
                form2.Show();
        }
    }
}
