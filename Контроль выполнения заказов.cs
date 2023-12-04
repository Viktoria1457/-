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
    public partial class Контроль_выполнения_заказов : Form
    {
        public string Role;
        public Контроль_выполнения_заказов()
        {
            InitializeComponent();
        }

        public Контроль_выполнения_заказов(string text)
        {
            Role = text;
        }

        private void Контроль_выполнения_заказов_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "практикаDataSet.Размешение_заказов". При необходимости она может быть перемещена или удалена.
            this.размешение_заказовTableAdapter.Fill(this.практикаDataSet.Размешение_заказов);
            MessageBox.Show(Role);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Меню_для_Администратора frm2 = new Меню_для_Администратора();
            frm2.Show();
            this.Hide();
        }
    }
}
