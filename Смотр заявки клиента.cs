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
    public partial class Смотр_заявки_клиента : Form
    {
        public Смотр_заявки_клиента()
        {
            InitializeComponent();
        }

        private void Смотр_заявки_клиента_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "практикаDataSet2.Исполнения_заказов". При необходимости она может быть перемещена или удалена.
            this.исполнения_заказовTableAdapter.Fill(this.практикаDataSet2.Исполнения_заказов);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
