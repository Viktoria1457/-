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
    public partial class Меню_для_Администратора : Form
    {
        public Меню_для_Администратора()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
                Form1 frm2 = new Form1();
                frm2.Show();
                this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Контроль_Исполнениия_Заказа frm2 = new Контроль_Исполнениия_Заказа();
            frm2.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Контроль_выдачи_заказов frm2 = new Контроль_выдачи_заказов();
            frm2.Show();
            this.Hide();
        }
    }
}
