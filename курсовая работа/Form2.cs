using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace курсовая_работа
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        int combox_x = 81;
        int combox_y = 56;
        int combox_x2 = 12;
        int combox_y2 = 56;
        int datagridview_1_x = 230;
        int datagridview_1_y = 56;
        
        int a = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            a++;
            combox_y +=28;
            combox_y2 +=28;
            datagridview_1_y += 28;
          
            if (a == 6) { button2.Enabled = false;
                label7.Text = "максимальное число продуктов";
            }
            tabPage1.Controls.Add(new ComboBox { Location = new Point(combox_x, combox_y),Size = new Size(145, 24) });
            tabPage1.Controls.Add(new ComboBox { Location = new Point(combox_x2, combox_y2), Size = new Size(61, 24) });
            tabPage1.Controls.Add(new DataGridView { Location = new Point(datagridview_1_x, datagridview_1_y), Size = new Size(426, 20),BackgroundColor = (Color.White)});
           
        }

        

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked) { label10.Text = "2500*"; };
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked) { label10.Text = "2000*"; };
        }

        

       

       

        private void label18_Click(object sender, EventArgs e)
        {

        }
        int combox_x3 = 8;
        int combox_y3 = 174;
        int combox_x4 = 88;
        int combox_y4 = 174;
        int b = 0;
        private void button3_Click(object sender, EventArgs e)
        {
        
         
            b++;
            combox_y3 +=30;
            combox_y4 +=30;
            if (b == 2)
            {
                button3.Enabled = false;

            }
            tabPage2.Controls.Add(new ComboBox { Location = new Point(combox_x3, combox_y3), Size = new Size(76, 24) });
            tabPage2.Controls.Add(new ComboBox { Location = new Point(combox_x4, combox_y4), Size = new Size(125, 24) });
        }
        int combox_x5 = 231;
        int combox_y5 = 174;
        int combox_x6 = 310;
        int combox_y6 = 174;
        int c = 0;
        private void button5_Click(object sender, EventArgs e)
        {
           
           
            c++;
            
            combox_y5 += 30;
            combox_y6 += 30;
            if (c == 2)
            {
                button5.Enabled = false;

            }
            tabPage2.Controls.Add(new ComboBox { Location = new Point(combox_x5, combox_y5), Size = new Size(76, 24) });
            tabPage2.Controls.Add(new ComboBox { Location = new Point(combox_x6, combox_y6), Size = new Size(125, 24) });
        }
        int combox_x7 = 451;
        int combox_y7 = 174;
        int combox_x8 = 530;
        int combox_y8 = 174;
        int d = 0;
        private void button6_Click(object sender, EventArgs e)
        {
           
            d++;
          
            combox_y7 += 30;
            combox_y8 += 30;
            if (d == 2)
            {
                button6.Enabled = false;

            }
            tabPage2.Controls.Add(new ComboBox { Location = new Point(combox_x7, combox_y7), Size = new Size(76, 24) });
            tabPage2.Controls.Add(new ComboBox { Location = new Point(combox_x8, combox_y8), Size = new Size(125, 24) });
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "racion_pitaniyaDataSet4.grafic". При необходимости она может быть перемещена или удалена.
            this.graficTableAdapter.Fill(this.racion_pitaniyaDataSet4.grafic);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "racion_pitaniyaDataSet1.product". При необходимости она может быть перемещена или удалена.
            this.productTableAdapter.Fill(this.racion_pitaniyaDataSet1.product);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "racion_pitaniyaDataSet.razdel". При необходимости она может быть перемещена или удалена.
            this.razdelTableAdapter.Fill(this.racion_pitaniyaDataSet.razdel);

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
    }