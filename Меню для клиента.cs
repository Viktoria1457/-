using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace практика
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
            private void button2_Click(object sender, EventArgs e)
            {
                Application.Exit(); // Выход из приложения
            }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Form1 frm2 = new Form1();
            frm2.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Заявка_на_ремон frm2 = new Заявка_на_ремон();
            frm2.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Контроль_выполнения_заказов frm2 = new Контроль_выполнения_заказов();
            frm2.Show();
            this.Hide();
        }
    }
}
