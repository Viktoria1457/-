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
    public partial class Контроль_Исполнениия_Заказа : Form
    {
        public Контроль_Исполнениия_Заказа()
        {
            InitializeComponent();
        }

        private void Контроль_Исполнениия_Заказа_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "практикаDataSet4.Исполнения_заказов". При необходимости она может быть перемещена или удалена.
            this.исполнения_заказовTableAdapter.Fill(this.практикаDataSet4.Исполнения_заказов);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        string pravoo = "";
        public void pravo(string a)
        {
            pravoo = a;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (pravoo == "Администратор")
            {
                Меню_для_Администратора frm2 = new Меню_для_Администратора();
                frm2.Show();
                this.Hide();
            }
            if (pravoo == "Директор")
            {
                Form4 frm2 = new Form4();
                frm2.Show();
                this.Hide();
            }
            
        }
    }
}
