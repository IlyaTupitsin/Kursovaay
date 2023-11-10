using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace курсовая_работа
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "racion_pitaniyaDataSet3.product". При необходимости она может быть перемещена или удалена.
            this.productTableAdapter1.Fill(this.racion_pitaniyaDataSet3.product);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "racion_pitaniyaDataSet2.product". При необходимости она может быть перемещена или удалена.
            this.productTableAdapter.Fill(this.racion_pitaniyaDataSet2.product);

        }
    }
}
