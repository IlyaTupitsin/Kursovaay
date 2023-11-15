using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace курсовая_работа
{
    enum RowState1
    {
        ModifiedNew,
    }
    public partial class Form3 : Form
    {
        bdClass dataBase = new bdClass();
        public Form3()
        {
            InitializeComponent();

            StartPosition = FormStartPosition.CenterScreen;
        }
     /*   public void CreateColumns()
        {
            dataGridView1.Columns.Add("id_product", "ID");
            dataGridView1.Columns.Add("name_product", "название");
            dataGridView1.Columns.Add("Fats_product", "жиры");
            dataGridView1.Columns.Add("protein_product", "белки");
            dataGridView1.Columns.Add("carbohydrates_product", "углеводы");
            dataGridView1.Columns.Add("calories_product", "калории");
            dataGridView1.Columns.Add("id_razdel", "номер раздела");

        }
        private void ReadSingRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetDouble(2), record.GetDouble(3), record.GetDouble(4), record.GetInt32(5), record.GetInt32(6), RowState1.ModifiedNew);

        }
        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string querryString = $"select * from product";

            SqlCommand command = new SqlCommand(querryString, dataBase.getConnection());

            dataBase.opemConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingRow(dgw, reader);
            }
            reader.Close();
        }*/

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }

       

        private void button3_Click(object sender, EventArgs e)
        {
            Process.Start(Application.ExecutablePath);
            Application.Exit();
        }

       

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            dataBase.opemConnection();

            var name = textBoxName.Text;
            var fast = textBoxFast.Text;
            var protein = textBoxProtein.Text;
            var carbo = textBoxCarbo.Text;
            var calories = textBoxCalories.Text;
            int razdel = 1;

         //   if(int.TryParse(textBoxRazdel.Text, out razdel) )
          //  {
                var addQuery = $"insert into product (name_product,Fats_product,protein_product,carbohydrates_product,calories_product,id_razdel) values ('{name}', '{fast}', '{protein}', '{carbo}', '{calories}', '{razdel}') ";
                var command = new SqlCommand(addQuery, dataBase.getConnection());
                command.ExecuteNonQuery();

                MessageBox.Show("Вы успешно добавили продукт!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
         //   }
           // else
           // {
           //     MessageBox.Show("Продукт не добавлен!");
          //  }

            dataBase.CloseConnection();
        }

        private void Form3_Load_1(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "racion_pitaniyaDataSet12.product". При необходимости она может быть перемещена или удалена.
            this.productTableAdapter2.Fill(this.racion_pitaniyaDataSet12.product);
           // CreateColumns();
           // RefreshDataGrid(dataGridView1);
        }

        
    }
}
