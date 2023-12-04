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
    public partial class Размещение_заказа : Form
    {
        public Размещение_заказа()
        {
            InitializeComponent();
        }

        private void Размещение_заказа_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "практикаDataSet4.Размешение_заказов". При необходимости она может быть перемещена или удалена.
            this.размешение_заказовTableAdapter.Fill(this.практикаDataSet4.Размешение_заказов);

        }
    }
}
