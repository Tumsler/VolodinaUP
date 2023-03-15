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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        Form5 form5;
        private void button1_Click(object sender, EventArgs e)
        {
            int x = 0;

            if (textBox1.Text == "3")
            { label4.ForeColor = Color.Green; 
            x++; }

            if (textBox2.Text == "2")
            {
                label8.ForeColor = Color.Green;
                x++;
            }

            if (textBox3.Text == "1")
            {
                label14.ForeColor = Color.Green;
                x++;
            }

            if (textBox4.Text == "1")
            {
                label19.ForeColor = Color.Green;
                x++;
            }

            if (textBox5.Text == "3")
            {
                label24.ForeColor = Color.Green;
                x++;
            }

            if (textBox6.Text == "2")
            {
                label29.ForeColor = Color.Green;
                x++;
            }

            MessageBox.Show("Поздравляю!\nВы набрали " + x + " Баллов! ");


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
        }
    }
}
