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
    

        private void buttonNazat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }

       

        private void buttonupdate_Click(object sender, EventArgs e)
        {
            Process.Start(Application.ExecutablePath);
            Application.Exit();
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            dataBase.opemConnection();

            var name = textBoxName.Text;
            var fast = textBoxFast.Text;
            var protein = textBoxProtein.Text;
            var carbo = textBoxCarbo.Text;
            var calories = textBoxCalories.Text;
            int razdel = 1;                              
            var addQuery = $"insert into product (name_product,Fats_product,protein_product,carbohydrates_product,calories_product,id_razdel) values ('{name}', '{fast}', '{protein}', '{carbo}', '{calories}', '{razdel}') ";
            var command = new SqlCommand(addQuery, dataBase.getConnection());
            command.ExecuteNonQuery();
            MessageBox.Show("Вы успешно добавили продукт!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        
            dataBase.CloseConnection();
        }

        private void Form3_Load_1(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "racion_pitaniyaDataSet12.product". При необходимости она может быть перемещена или удалена.
            this.productTableAdapter2.Fill(this.racion_pitaniyaDataSet12.product);
          
        }

        
    }
}
