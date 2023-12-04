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
    public partial class Контроль_выдачи_заказов : Form
    {
        public Контроль_выдачи_заказов()
        {
            InitializeComponent();
        }

        private void Контроль_выдачи_заказов_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "практикаDataSet1.Выдача_заказов". При необходимости она может быть перемещена или удалена.
            this.выдача_заказовTableAdapter.Fill(this.практикаDataSet1.Выдача_заказов);

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
