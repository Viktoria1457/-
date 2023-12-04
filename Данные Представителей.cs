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
    public partial class Данные_Представителей : Form
    {
        public Данные_Представителей()
        {
            InitializeComponent();
        }

        private void Данные_Представителей_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "практикаDataSet4.Представители_заказчиков". При необходимости она может быть перемещена или удалена.
            this.представители_заказчиковTableAdapter.Fill(this.практикаDataSet4.Представители_заказчиков);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 frm2 = new Form4();
            frm2.Show();
            this.Hide();
        }
    }
}
