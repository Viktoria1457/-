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
    public partial class Заявка_на_ремон : Form
    {
        public Заявка_на_ремон()
        {
            InitializeComponent();
        }

        private void Заявка_на_ремон_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "практикаDataSet3.Данные_Сотрудников_Организации". При необходимости она может быть перемещена или удалена.
            this.данные_Сотрудников_ОрганизацииTableAdapter.Fill(this.практикаDataSet3.Данные_Сотрудников_Организации);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 frm2 = new Form1();
            frm2.Show();
            this.Hide();
        }
    }
}
