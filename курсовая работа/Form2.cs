using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Markup;

namespace курсовая_работа
{
    enum RowState
    {
        ModifiedNew,
    }
    public partial class Form2 : Form
    {
        bdClass dataBase = new bdClass();
       
        public Form2()
        {
            InitializeComponent();
        }
        private void buttonNazat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }
          

        private void radioButtonMan_CheckedChanged(object sender, EventArgs e)
        {
          
            if (label13.Text == "")
            {
                label2.Text = "ввыберите продукты на день";
            }
            else
            {
                int colori = int.Parse(label13.Text);
                if (radioButtonMan.Checked)
                {

                    int man = 2000;
                    if (colori > man)
                    {
                        label2.Text = " Рекомендация по питанию:\n Формирование повседневного рациона на основе полезных компонентов;\n максимальное ограничение потребления жирных и жареных блюд, фастфуда,\n сладостей, полуфабрикатов, колбасных изделий и алкоголя.\n Разумную осторожность следует проявлять в отношении копченых и острых блюд,\n а также — продуктов, препятствующих полноценной выработке тестостерона\n (бобовые культуры, кукурузное и соевое масла, растворимый кофе, пиво и т. д.)";
                    }
                    if (colori < man)
                    {
          
                        label2.Text = " Рекомендация по питанию:\n Важно строго соблюдать режим питания.\n Помните главное правило: количество потребляемых калорий в рационе должно\n соответствовать энергетическим затратам. Питаться нужно не реже трёх раз в день.\n При этом стоит всегда знать меру – не переедать и не есть перед сном.\n Помните, что перекусы не менее важны, чем основные приёмы пищи.\n Это не должны быть фастфуд или сладости, которые содержат много быстрых углеводов.\n Лучше выбирайте фрукты, овощи или орехи.";
                    }
                }
            }
        }

        private void radioButtonWoman_CheckedChanged(object sender, EventArgs e)
        {
            if (label13.Text == "")
            {
                label2.Text = "ввыберите продукты на день";
            }
            else
            {
                int colori = int.Parse(label13.Text);
                if (radioButtonWoman.Checked)
                {

                    int woman = 1700;
                    if (colori > woman)
                    {
                        label2.Text = " Рекомендация по питанию:\n Суточное меню должно состоять из 50% строительного материала – протеинов (белков), \n 30% сложных углеводов и 20% растительных липидов (жиров).\n Все эти необходимые элементы присутствуют в овощах и фруктах, мясе и рыбке, кашах и цельнозерновом хлебе.";
                    }
                    if (colori < woman)
                    {
                        label2.Text = " Рекомендация по питанию:\n Своевременно замечайте недостаток энергетических веществ. Организм должен получать достаточно энергии,\n но при избытке углеводов (особенно простых) вещества откладываются в жировые прослойки.\n Если вы ушли в отпуск и снизили активность – сократите потребление углеводов.\n Если вы пошли на спорт – увеличьте потребление белков.\n Если ухудшилось состояние волос, ногтей и кожи – в организме недостаточно жиров.";
                    }
                }
            }
        }     
       
      

        private void buttonSave_Click(object sender, EventArgs e)
        {
            dataBase.opemConnection();
            var caloriesDay = labelcalories.Text;
            radioButtonMan.Checked = false;
            radioButtonWoman.Checked = false;
            label2.Text = " Рекомендация по питанию:";
            label13.Text = labelcalories.Text ;

            string querysstring = $"insert into grafic(calories) values('{caloriesDay}')";
            SqlCommand command = new SqlCommand(querysstring, dataBase.getConnection());

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Вы успешно добавили калорийность рациона за день!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("рацион не добавлен!");
            }
            dataBase.CloseConnection();
        }
        public void CreateColumns()
        {
            dataGridView3.Columns.Add("nomer", "день");
            dataGridView3.Columns.Add("calories", "калории");

        }
        private void ReadSingRow(DataGridView dgw,IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1),RowState.ModifiedNew);

        }
        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string querryString = $"select * from grafic";

            SqlCommand command = new SqlCommand(querryString, dataBase.getConnection());

            dataBase.opemConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingRow(dgw, reader);
            }
            reader.Close();
        }
     
       
      

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int product1 = int.Parse(comboBox1.SelectedValue.ToString());
            int product2 = int.Parse(comboBox2.SelectedValue.ToString());
            int product3 = int.Parse(comboBox3.SelectedValue.ToString());
            int product4 = int.Parse(comboBox4.SelectedValue.ToString());
            int product5 = int.Parse(comboBox5.SelectedValue.ToString());
            comboBox1.BindingContext = new BindingContext();
            comboBox1.DataSource = productBindingSource.List;
            textBox1.Text = (product1 + product2 + product3 + product4 + product5).ToString();

        }

       

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            int product6 = int.Parse(comboBox6.SelectedValue.ToString());
            int product7 = int.Parse(comboBox7.SelectedValue.ToString());
            int product8 = int.Parse(comboBox8.SelectedValue.ToString());
            int product9 = int.Parse(comboBox9.SelectedValue.ToString());
            int product10 = int.Parse(comboBox10.SelectedValue.ToString());
            int product11 = int.Parse(comboBox11.SelectedValue.ToString());
            int product12 = int.Parse(comboBox12.SelectedValue.ToString());
            int product13 = int.Parse(comboBox13.SelectedValue.ToString());
            int product14 = int.Parse(comboBox14.SelectedValue.ToString());
            int product15 = int.Parse(comboBox15.SelectedValue.ToString());
            int product16 = int.Parse(comboBox16.SelectedValue.ToString());
            int product17 = int.Parse(comboBox17.SelectedValue.ToString());
            int product18 = int.Parse(comboBox18.SelectedValue.ToString());
            int product19 = int.Parse(comboBox19.SelectedValue.ToString());
            int product20 = int.Parse(comboBox20.SelectedIndex.ToString());
            comboBox6.BindingContext = new BindingContext();
            comboBox6.DataSource =productBindingSource.List;

            labelcalories.Text = (product6 + product7 + product8 + product9 + product10 + product11 + product12 + product13 + product14 + product15 + product16 + product17 + product18 + product19 + product20).ToString();
        }

        

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            int product1 = int.Parse(comboBox1.SelectedValue.ToString());
            int product2 = int.Parse(comboBox2.SelectedValue.ToString());
            int product3 = int.Parse(comboBox3.SelectedValue.ToString());
            int product4 = int.Parse(comboBox4.SelectedValue.ToString());
            int product5 = int.Parse(comboBox5.SelectedValue.ToString());
            comboBox2.BindingContext = new BindingContext();
            comboBox2.DataSource = productBindingSource.List;
            textBox1.Text = (product1 + product2 + product3 + product4 + product5).ToString();
        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            int product1 = int.Parse(comboBox1.SelectedValue.ToString());
            int product2 = int.Parse(comboBox2.SelectedValue.ToString());
            int product3 = int.Parse(comboBox3.SelectedValue.ToString());
            int product4 = int.Parse(comboBox4.SelectedValue.ToString());
            int product5 = int.Parse(comboBox5.SelectedValue.ToString());
            comboBox3.BindingContext = new BindingContext();
            comboBox3.DataSource = productBindingSource.List;
            textBox1.Text = (product1 + product2 + product3 + product4 + product5).ToString();
        }

        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {
            int product1 = int.Parse(comboBox1.SelectedValue.ToString());
            int product2 = int.Parse(comboBox2.SelectedValue.ToString());
            int product3 = int.Parse(comboBox3.SelectedValue.ToString());
            int product4 = int.Parse(comboBox4.SelectedValue.ToString());
            int product5 = int.Parse(comboBox5.SelectedValue.ToString());
            comboBox4.BindingContext = new BindingContext();
            comboBox4.DataSource = productBindingSource.List;
            textBox1.Text = (product1 + product2 + product3 + product4 + product5).ToString();
        }

        private void comboBox14_SelectedIndexChanged(object sender, EventArgs e)
        {
            int product1 = int.Parse(comboBox1.SelectedValue.ToString());
            int product2 = int.Parse(comboBox2.SelectedValue.ToString());
            int product3 = int.Parse(comboBox3.SelectedValue.ToString());
            int product4 = int.Parse(comboBox4.SelectedValue.ToString());
            int product5 = int.Parse(comboBox5.SelectedValue.ToString());
            comboBox5.BindingContext = new BindingContext();
            comboBox5.DataSource = productBindingSource.List;
            textBox1.Text = (product1 + product2 + product3 + product4 + product5).ToString();
        }

        private void comboBox10_SelectedIndexChanged(object sender, EventArgs e)
        {
            int product6 = int.Parse(comboBox6.SelectedValue.ToString());
            int product7 = int.Parse(comboBox7.SelectedValue.ToString());
            int product8 = int.Parse(comboBox8.SelectedValue.ToString());
            int product9 = int.Parse(comboBox9.SelectedValue.ToString());
            int product10 = int.Parse(comboBox10.SelectedValue.ToString());
            int product11 = int.Parse(comboBox11.SelectedValue.ToString());
            int product12 = int.Parse(comboBox12.SelectedValue.ToString());
            int product13 = int.Parse(comboBox13.SelectedValue.ToString());
            int product14 = int.Parse(comboBox14.SelectedValue.ToString());
            int product15 = int.Parse(comboBox15.SelectedValue.ToString());
            int product16 = int.Parse(comboBox16.SelectedValue.ToString());
            int product17 = int.Parse(comboBox17.SelectedValue.ToString());
            int product18 = int.Parse(comboBox18.SelectedValue.ToString());
            int product19 = int.Parse(comboBox19.SelectedValue.ToString());
            int product20 = int.Parse(comboBox20.SelectedValue.ToString());
            comboBox11.BindingContext = new BindingContext();
            comboBox11.DataSource = productBindingSource.List;
            labelcalories.Text = (product6 + product7 + product8 + product9 + product10 + product11 + product12 + product13 + product14 + product15 + product16 + product17 + product18 + product19 + product20).ToString() ;
        }

        private void comboBox12_SelectedIndexChanged(object sender, EventArgs e)
        {
            int product6 = int.Parse(comboBox6.SelectedValue.ToString());
            int product7 = int.Parse(comboBox7.SelectedValue.ToString());
            int product8 = int.Parse(comboBox8.SelectedValue.ToString());
            int product9 = int.Parse(comboBox9.SelectedValue.ToString());
            int product10 = int.Parse(comboBox10.SelectedValue.ToString());
            int product11 = int.Parse(comboBox11.SelectedValue.ToString());
            int product12 = int.Parse(comboBox12.SelectedValue.ToString());
            int product13 = int.Parse(comboBox13.SelectedValue.ToString());
            int product14 = int.Parse(comboBox14.SelectedValue.ToString());
            int product15 = int.Parse(comboBox15.SelectedValue.ToString());
            int product16 = int.Parse(comboBox16.SelectedValue.ToString());
            int product17 = int.Parse(comboBox17.SelectedValue.ToString());
            int product18 = int.Parse(comboBox18.SelectedValue.ToString());
            int product19 = int.Parse(comboBox19.SelectedValue.ToString());
            int product20 = int.Parse(comboBox20.SelectedValue.ToString());
            comboBox16.BindingContext = new BindingContext();
            comboBox16.DataSource = productBindingSource.List;
            labelcalories.Text = (product6 + product7 + product8 + product9 + product10 + product11 + product12 + product13 + product14 + product15 + product16 + product17 + product18 + product19 + product20).ToString();
        }

        private void comboBox15_SelectedIndexChanged(object sender, EventArgs e)
        {
            int product6 = int.Parse(comboBox6.SelectedValue.ToString());
            int product7 = int.Parse(comboBox7.SelectedValue.ToString());
            int product8 = int.Parse(comboBox8.SelectedValue.ToString());
            int product9 = int.Parse(comboBox9.SelectedValue.ToString());
            int product10 = int.Parse(comboBox10.SelectedValue.ToString());
            int product11 = int.Parse(comboBox11.SelectedValue.ToString());
            int product12 = int.Parse(comboBox12.SelectedValue.ToString());
            int product13 = int.Parse(comboBox13.SelectedValue.ToString());
            int product14 = int.Parse(comboBox14.SelectedValue.ToString());
            int product15 = int.Parse(comboBox15.SelectedValue.ToString());
            int product16 = int.Parse(comboBox16.SelectedValue.ToString());
            int product17 = int.Parse(comboBox17.SelectedValue.ToString());
            int product18 = int.Parse(comboBox18.SelectedValue.ToString());
            int product19 = int.Parse(comboBox19.SelectedValue.ToString());
            int product20 = int.Parse(comboBox20.SelectedValue.ToString());
            comboBox7.BindingContext = new BindingContext();
            comboBox7.DataSource = productBindingSource.List;
            labelcalories.Text = (product6 + product7 + product8 + product9 + product10 + product11 + product12 + product13 + product14 + product15 + product16 + product17 + product18 + product19 + product20).ToString();
        }

        private void comboBox16_SelectedIndexChanged(object sender, EventArgs e)
        {
            int product6 = int.Parse(comboBox6.SelectedValue.ToString());
            int product7 = int.Parse(comboBox7.SelectedValue.ToString());
            int product8 = int.Parse(comboBox8.SelectedValue.ToString());
            int product9 = int.Parse(comboBox9.SelectedValue.ToString());
            int product10 = int.Parse(comboBox10.SelectedValue.ToString());
            int product11 = int.Parse(comboBox11.SelectedValue.ToString());
            int product12 = int.Parse(comboBox12.SelectedValue.ToString());
            int product13 = int.Parse(comboBox13.SelectedValue.ToString());
            int product14 = int.Parse(comboBox14.SelectedValue.ToString());
            int product15 = int.Parse(comboBox15.SelectedValue.ToString());
            int product16 = int.Parse(comboBox16.SelectedValue.ToString());
            int product17 = int.Parse(comboBox17.SelectedValue.ToString());
            int product18 = int.Parse(comboBox18.SelectedValue.ToString());
            int product19 = int.Parse(comboBox19.SelectedValue.ToString());
            int product20 = int.Parse(comboBox20.SelectedValue.ToString());
            comboBox8.BindingContext = new BindingContext();
            comboBox8.DataSource = productBindingSource.List;
            labelcalories.Text = (product6 + product7 + product8 + product9 + product10 + product11 + product12 + product13 + product14 + product15 + product16 + product17 + product18 + product19 + product20).ToString();
        }

        private void comboBox17_SelectedIndexChanged(object sender, EventArgs e)
        {
            int product6 = int.Parse(comboBox6.SelectedValue.ToString());
            int product7 = int.Parse(comboBox7.SelectedValue.ToString());
            int product8 = int.Parse(comboBox8.SelectedValue.ToString());
            int product9 = int.Parse(comboBox9.SelectedValue.ToString());
            int product10 = int.Parse(comboBox10.SelectedValue.ToString());
            int product11 = int.Parse(comboBox11.SelectedValue.ToString());
            int product12 = int.Parse(comboBox12.SelectedValue.ToString());
            int product13 = int.Parse(comboBox13.SelectedValue.ToString());
            int product14 = int.Parse(comboBox14.SelectedValue.ToString());
            int product15 = int.Parse(comboBox15.SelectedValue.ToString());
            int product16 = int.Parse(comboBox16.SelectedValue.ToString());
            int product17 = int.Parse(comboBox17.SelectedValue.ToString());
            int product18 = int.Parse(comboBox18.SelectedValue.ToString());
            int product19 = int.Parse(comboBox19.SelectedValue.ToString());
            int product20 = int.Parse(comboBox20.SelectedValue.ToString());
            comboBox9.BindingContext = new BindingContext();
            comboBox9.DataSource = productBindingSource.List;
            labelcalories.Text = (product6 + product7 + product8 + product9 + product10 + product11 + product12 + product13 + product14 + product15 + product16 + product17 + product18 + product19 + product20).ToString();
        }

        private void comboBox25_SelectedIndexChanged(object sender, EventArgs e)
        {
            int product6 = int.Parse(comboBox6.SelectedValue.ToString());
            int product7 = int.Parse(comboBox7.SelectedValue.ToString());
            int product8 = int.Parse(comboBox8.SelectedValue.ToString());
            int product9 = int.Parse(comboBox9.SelectedValue.ToString());
            int product10 = int.Parse(comboBox10.SelectedValue.ToString());
            int product11 = int.Parse(comboBox11.SelectedValue.ToString());
            int product12 = int.Parse(comboBox12.SelectedValue.ToString());
            int product13 = int.Parse(comboBox13.SelectedValue.ToString());
            int product14 = int.Parse(comboBox14.SelectedValue.ToString());
            int product15 = int.Parse(comboBox15.SelectedValue.ToString());
            int product16 = int.Parse(comboBox16.SelectedValue.ToString());
            int product17 = int.Parse(comboBox17.SelectedValue.ToString());
            int product18 = int.Parse(comboBox18.SelectedValue.ToString());
            int product19 = int.Parse(comboBox19.SelectedValue.ToString());
            int product20 = int.Parse(comboBox20.SelectedValue.ToString());
            comboBox10.BindingContext = new BindingContext();
            comboBox10.DataSource = productBindingSource.List;
            labelcalories.Text = (product6 + product7 + product8 + product9 + product10 + product11 + product12 + product13 + product14 + product15 + product16 + product17 + product18 + product19 + product20).ToString();
        }
        private void comboBox18_SelectedIndexChanged(object sender, EventArgs e)
        {
            int product6 = int.Parse(comboBox6.SelectedValue.ToString());
            int product7 = int.Parse(comboBox7.SelectedValue.ToString());
            int product8 = int.Parse(comboBox8.SelectedValue.ToString());
            int product9 = int.Parse(comboBox9.SelectedValue.ToString());
            int product10 = int.Parse(comboBox10.SelectedValue.ToString());
            int product11 = int.Parse(comboBox11.SelectedValue.ToString());
            int product12 = int.Parse(comboBox12.SelectedValue.ToString());
            int product13 = int.Parse(comboBox13.SelectedValue.ToString());
            int product14 = int.Parse(comboBox14.SelectedValue.ToString());
            int product15 = int.Parse(comboBox15.SelectedValue.ToString());
            int product16 = int.Parse(comboBox16.SelectedValue.ToString());
            int product17 = int.Parse(comboBox17.SelectedValue.ToString());
            int product18 = int.Parse(comboBox18.SelectedValue.ToString());
            int product19 = int.Parse(comboBox19.SelectedValue.ToString());
            int product20 = int.Parse(comboBox20.SelectedValue.ToString());
            comboBox12.BindingContext = new BindingContext();
            comboBox12.DataSource = productBindingSource.List;
            labelcalories.Text = (product6 + product7 + product8 + product9 + product10 + product11 + product12 + product13 + product14 + product15 + product16 + product17 + product18 + product19 + product20).ToString();
        }
        private void comboBox19_SelectedIndexChanged(object sender, EventArgs e)
        {
            int product6 = int.Parse(comboBox6.SelectedValue.ToString());
            int product7 = int.Parse(comboBox7.SelectedValue.ToString());
            int product8 = int.Parse(comboBox8.SelectedValue.ToString());
            int product9 = int.Parse(comboBox9.SelectedValue.ToString());
            int product10 = int.Parse(comboBox10.SelectedValue.ToString());
            int product11 = int.Parse(comboBox11.SelectedValue.ToString());
            int product12 = int.Parse(comboBox12.SelectedValue.ToString());
            int product13 = int.Parse(comboBox13.SelectedValue.ToString());
            int product14 = int.Parse(comboBox14.SelectedValue.ToString());
            int product15 = int.Parse(comboBox15.SelectedValue.ToString());
            int product16 = int.Parse(comboBox16.SelectedValue.ToString());
            int product17 = int.Parse(comboBox17.SelectedValue.ToString());
            int product18 = int.Parse(comboBox18.SelectedValue.ToString());
            int product19 = int.Parse(comboBox19.SelectedValue.ToString());
            int product20 = int.Parse(comboBox20.SelectedValue.ToString());
            comboBox13.BindingContext = new BindingContext();
            comboBox13.DataSource = productBindingSource.List;
            labelcalories.Text = (product6 + product7 + product8 + product9 + product10 + product11 + product12 + product13 + product14 + product15 + product16 + product17 + product18 + product19 + product20).ToString();
        }

        private void comboBox21_SelectedIndexChanged(object sender, EventArgs e)
        {
            int product6 = int.Parse(comboBox6.SelectedValue.ToString());
            int product7 = int.Parse(comboBox7.SelectedValue.ToString());
            int product8 = int.Parse(comboBox8.SelectedValue.ToString());
            int product9 = int.Parse(comboBox9.SelectedValue.ToString());
            int product10 = int.Parse(comboBox10.SelectedValue.ToString());
            int product11 = int.Parse(comboBox11.SelectedValue.ToString());
            int product12 = int.Parse(comboBox12.SelectedValue.ToString());
            int product13 = int.Parse(comboBox13.SelectedValue.ToString());
            int product14 = int.Parse(comboBox14.SelectedValue.ToString());
            int product15 = int.Parse(comboBox15.SelectedValue.ToString());
            int product16 = int.Parse(comboBox16.SelectedValue.ToString());
            int product17 = int.Parse(comboBox17.SelectedValue.ToString());
            int product18 = int.Parse(comboBox18.SelectedValue.ToString());
            int product19 = int.Parse(comboBox19.SelectedValue.ToString());
            int product20 = int.Parse(comboBox20.SelectedValue.ToString());
            comboBox14.BindingContext = new BindingContext();
            comboBox14.DataSource = productBindingSource.List;
            labelcalories.Text = (product6 + product7 + product8 + product9 + product10 + product11 + product12 + product13 + product14 + product15 + product16 + product17 + product18 + product19 + product20).ToString();
        }

        private void comboBox13_SelectedIndexChanged(object sender, EventArgs e)
        {
            int product6 = int.Parse(comboBox6.SelectedValue.ToString());
            int product7 = int.Parse(comboBox7.SelectedValue.ToString());
            int product8 = int.Parse(comboBox8.SelectedValue.ToString());
            int product9 = int.Parse(comboBox9.SelectedValue.ToString());
            int product10 = int.Parse(comboBox10.SelectedValue.ToString());
            int product11 = int.Parse(comboBox11.SelectedValue.ToString());
            int product12 = int.Parse(comboBox12.SelectedValue.ToString());
            int product13 = int.Parse(comboBox13.SelectedValue.ToString());
            int product14 = int.Parse(comboBox14.SelectedValue.ToString());
            int product15 = int.Parse(comboBox15.SelectedValue.ToString());
            int product16 = int.Parse(comboBox16.SelectedValue.ToString());
            int product17 = int.Parse(comboBox17.SelectedValue.ToString());
            int product18 = int.Parse(comboBox18.SelectedValue.ToString());
            int product19 = int.Parse(comboBox19.SelectedValue.ToString());
            int product20 = int.Parse(comboBox20.SelectedValue.ToString());
            comboBox15.BindingContext = new BindingContext();
            comboBox15.DataSource = productBindingSource.List;
            labelcalories.Text = (product6 + product7 + product8 + product9 + product10 + product11 + product12 + product13 + product14 + product15 + product16 + product17 + product18 + product19 + product20).ToString();
        }

        private void comboBox22_SelectedIndexChanged(object sender, EventArgs e)
        {
            int product6 = int.Parse(comboBox6.SelectedValue.ToString());
            int product7 = int.Parse(comboBox7.SelectedValue.ToString());
            int product8 = int.Parse(comboBox8.SelectedValue.ToString());
            int product9 = int.Parse(comboBox9.SelectedValue.ToString());
            int product10 = int.Parse(comboBox10.SelectedValue.ToString());
            int product11 = int.Parse(comboBox11.SelectedValue.ToString());
            int product12 = int.Parse(comboBox12.SelectedValue.ToString());
            int product13 = int.Parse(comboBox13.SelectedValue.ToString());
            int product14 = int.Parse(comboBox14.SelectedValue.ToString());
            int product15 = int.Parse(comboBox15.SelectedValue.ToString());
            int product16 = int.Parse(comboBox16.SelectedValue.ToString());
            int product17 = int.Parse(comboBox17.SelectedValue.ToString());
            int product18 = int.Parse(comboBox18.SelectedValue.ToString());
            int product19 = int.Parse(comboBox19.SelectedValue.ToString());
            int product20 = int.Parse(comboBox20.SelectedValue.ToString());
            comboBox17.BindingContext = new BindingContext();
            comboBox17.DataSource = productBindingSource.List;
            labelcalories.Text = (product6 + product7 + product8 + product9 + product10 + product11 + product12 + product13 + product14 + product15 + product16 + product17 + product18 + product19 + product20).ToString();
        }

        private void comboBox23_SelectedIndexChanged(object sender, EventArgs e)
        {
            int product6 = int.Parse(comboBox6.SelectedValue.ToString());
            int product7 = int.Parse(comboBox7.SelectedValue.ToString());
            int product8 = int.Parse(comboBox8.SelectedValue.ToString());
            int product9 = int.Parse(comboBox9.SelectedValue.ToString());
            int product10 = int.Parse(comboBox10.SelectedValue.ToString());
            int product11 = int.Parse(comboBox11.SelectedValue.ToString());
            int product12 = int.Parse(comboBox12.SelectedValue.ToString());
            int product13 = int.Parse(comboBox13.SelectedValue.ToString());
            int product14 = int.Parse(comboBox14.SelectedValue.ToString());
            int product15 = int.Parse(comboBox15.SelectedValue.ToString());
            int product16 = int.Parse(comboBox16.SelectedValue.ToString());
            int product17 = int.Parse(comboBox17.SelectedValue.ToString());
            int product18 = int.Parse(comboBox18.SelectedValue.ToString());
            int product19 = int.Parse(comboBox19.SelectedValue.ToString());
            int product20 = int.Parse(comboBox20.SelectedValue.ToString());
            comboBox18.BindingContext = new BindingContext();
            comboBox18.DataSource = productBindingSource.List;
            labelcalories.Text = (product6 + product7 + product8 + product9 + product10 + product11 + product12 + product13 + product14 + product15 + product16 + product17 + product18 + product19 + product20).ToString();
        }

        private void comboBox24_SelectedIndexChanged(object sender, EventArgs e)
        {
            int product6 = int.Parse(comboBox6.SelectedValue.ToString());
            int product7 = int.Parse(comboBox7.SelectedValue.ToString());
            int product8 = int.Parse(comboBox8.SelectedValue.ToString());
            int product9 = int.Parse(comboBox9.SelectedValue.ToString());
            int product10 = int.Parse(comboBox10.SelectedValue.ToString());
            int product11 = int.Parse(comboBox11.SelectedValue.ToString());
            int product12 = int.Parse(comboBox12.SelectedValue.ToString());
            int product13 = int.Parse(comboBox13.SelectedValue.ToString());
            int product14 = int.Parse(comboBox14.SelectedValue.ToString());
            int product15 = int.Parse(comboBox15.SelectedValue.ToString());
            int product16 = int.Parse(comboBox16.SelectedValue.ToString());
            int product17 = int.Parse(comboBox17.SelectedValue.ToString());
            int product18 = int.Parse(comboBox18.SelectedValue.ToString());
            int product19 = int.Parse(comboBox19.SelectedValue.ToString());
            int product20 = int.Parse(comboBox20.SelectedValue.ToString());
            comboBox19.BindingContext = new BindingContext();
            comboBox19.DataSource = productBindingSource.List;
            labelcalories.Text = (product6 + product7 + product8 + product9 + product10 + product11 + product12 + product13 + product14 + product15 + product16 + product17 + product18 + product19 + product20).ToString();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int product6 = int.Parse(comboBox6.SelectedValue.ToString());
            int product7 = int.Parse(comboBox7.SelectedValue.ToString());
            int product8 = int.Parse(comboBox8.SelectedValue.ToString());
            int product9 = int.Parse(comboBox9.SelectedValue.ToString());
            int product10 = int.Parse(comboBox10.SelectedValue.ToString());
            int product11 = int.Parse(comboBox11.SelectedValue.ToString());
            int product12 = int.Parse(comboBox12.SelectedValue.ToString());
            int product13 = int.Parse(comboBox13.SelectedValue.ToString());
            int product14 = int.Parse(comboBox14.SelectedValue.ToString());
            int product15 = int.Parse(comboBox15.SelectedValue.ToString());
            int product16 = int.Parse(comboBox16.SelectedValue.ToString());
            int product17 = int.Parse(comboBox17.SelectedValue.ToString());
            int product18 = int.Parse(comboBox18.SelectedValue.ToString());
            int product19 = int.Parse(comboBox19.SelectedValue.ToString());
            int product20 = int.Parse(comboBox20.SelectedValue.ToString());
            comboBox20.BindingContext = new BindingContext();
            comboBox20.DataSource = productBindingSource.List;
            labelcalories.Text = (product6 + product7 + product8 + product9 + product10 + product11 + product12 + product13 + product14 + product15 + product16 + product17 + product18 + product19 + product20).ToString();
        }

        private void Form2_Load_1(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "racion_pitaniyaDataSet11.product". При необходимости она может быть перемещена или удалена.
            this.productTableAdapter4.Fill(this.racion_pitaniyaDataSet11.product);

            CreateColumns();
            RefreshDataGrid(dataGridView3);

        }


    }
    }
    