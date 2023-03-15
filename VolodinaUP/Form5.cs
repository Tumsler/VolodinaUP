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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            dataGridView1.Rows.Add();
            dataGridView1[0, 0].Value = "Никита Кентов";
            dataGridView1[1, 0].Value = "295";
            dataGridView1[2, 0].Value = "13.03.2023";
            dataGridView1[3, 0].Value = "6";
            dataGridView1[4, 0].Value = "Отлично!";
            dataGridView1.Rows.Add();
            dataGridView1[0, 1].Value = "Вася Пупкин";
            dataGridView1[1, 1].Value = "395";
            dataGridView1[2, 1].Value = "13.03.2023";
            dataGridView1[3, 1].Value = "2";
            dataGridView1[4, 1].Value = "Плохо!";
            dataGridView1.Rows.Add();
            dataGridView1[0, 2].Value = "Вася Лобов";
            dataGridView1[1, 2].Value = "295";
            dataGridView1[2, 2].Value = "13.03.2023";
            dataGridView1[3, 2].Value = "4";
            dataGridView1[4, 2].Value = "Хорошо!";
            dataGridView1.Rows.Add();
            dataGridView1[0, 3].Value = "Вася Кентов";
            dataGridView1[1, 3].Value = "495";
            dataGridView1[2, 3].Value = "13.03.2023";
            dataGridView1[3, 3].Value = "6";
            dataGridView1[4, 3].Value = "Отлично!";
            dataGridView1.Rows.Add();
            dataGridView1[0, 4].Value = "Валерия Володина";
            dataGridView1[1, 4].Value = "495";
            dataGridView1[2, 4].Value = "13.03.2023";
            dataGridView1[3, 4].Value = "4";
            dataGridView1[4, 4].Value = "Хорошо!";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
