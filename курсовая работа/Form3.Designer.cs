namespace курсовая_работа
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.buttonNazat = new System.Windows.Forms.Button();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.racion_pitaniyaDataSet2 = new курсовая_работа.racion_pitaniyaDataSet2();
            this.productBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.racion_pitaniyaDataSet3 = new курсовая_работа.racion_pitaniyaDataSet3();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonupdate = new System.Windows.Forms.Button();
            this.productTableAdapter = new курсовая_работа.racion_pitaniyaDataSet2TableAdapters.productTableAdapter();
            this.productTableAdapter1 = new курсовая_работа.racion_pitaniyaDataSet3TableAdapters.productTableAdapter();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxFast = new System.Windows.Forms.TextBox();
            this.textBoxProtein = new System.Windows.Forms.TextBox();
            this.textBoxCarbo = new System.Windows.Forms.TextBox();
            this.textBoxCalories = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nameproductDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fatsproductDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proteinproductDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carbohydratesproductDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caloriesproductDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.racion_pitaniyaDataSet12 = new курсовая_работа.racion_pitaniyaDataSet12();
            this.productTableAdapter2 = new курсовая_работа.racion_pitaniyaDataSet12TableAdapters.productTableAdapter();
            this.form1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racion_pitaniyaDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racion_pitaniyaDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racion_pitaniyaDataSet12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.buttonNazat.BackColor = System.Drawing.Color.SpringGreen;
            this.buttonNazat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonNazat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonNazat.Location = new System.Drawing.Point(0, 0);
            this.buttonNazat.Name = "button1";
            this.buttonNazat.Size = new System.Drawing.Size(110, 38);
            this.buttonNazat.TabIndex = 2;
            this.buttonNazat.Text = "выход";
            this.buttonNazat.UseVisualStyleBackColor = false;
            this.buttonNazat.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "product";
            this.productBindingSource.DataSource = this.racion_pitaniyaDataSet2;
            // 
            // racion_pitaniyaDataSet2
            // 
            this.racion_pitaniyaDataSet2.DataSetName = "racion_pitaniyaDataSet2";
            this.racion_pitaniyaDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productBindingSource1
            // 
            this.productBindingSource1.DataMember = "product";
            this.productBindingSource1.DataSource = this.racion_pitaniyaDataSet3;
            // 
            // racion_pitaniyaDataSet3
            // 
            this.racion_pitaniyaDataSet3.DataSetName = "racion_pitaniyaDataSet3";
            this.racion_pitaniyaDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(472, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "добавление продуктов";
            // 
            // button2
            // 
            this.buttonSave.BackColor = System.Drawing.Color.SpringGreen;
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSave.Location = new System.Drawing.Point(1112, 346);
            this.buttonSave.Name = "button2";
            this.buttonSave.Size = new System.Drawing.Size(110, 38);
            this.buttonSave.TabIndex = 6;
            this.buttonSave.Text = "сохранить";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.buttonupdate.BackColor = System.Drawing.Color.SpringGreen;
            this.buttonupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonupdate.Location = new System.Drawing.Point(0, 346);
            this.buttonupdate.Name = "button3";
            this.buttonupdate.Size = new System.Drawing.Size(110, 38);
            this.buttonupdate.TabIndex = 7;
            this.buttonupdate.Text = "обновить";
            this.buttonupdate.UseVisualStyleBackColor = false;
            this.buttonupdate.Click += new System.EventHandler(this.button3_Click);
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // productTableAdapter1
            // 
            this.productTableAdapter1.ClearBeforeFill = true;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(321, 321);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 22);
            this.textBoxName.TabIndex = 9;
            // 
            // textBoxFast
            // 
            this.textBoxFast.Location = new System.Drawing.Point(457, 321);
            this.textBoxFast.Name = "textBoxFast";
            this.textBoxFast.Size = new System.Drawing.Size(100, 22);
            this.textBoxFast.TabIndex = 10;
            // 
            // textBoxProtein
            // 
            this.textBoxProtein.Location = new System.Drawing.Point(584, 321);
            this.textBoxProtein.Name = "textBoxProtein";
            this.textBoxProtein.Size = new System.Drawing.Size(100, 22);
            this.textBoxProtein.TabIndex = 11;
            // 
            // textBoxCarbo
            // 
            this.textBoxCarbo.Location = new System.Drawing.Point(714, 321);
            this.textBoxCarbo.Name = "textBoxCarbo";
            this.textBoxCarbo.Size = new System.Drawing.Size(100, 22);
            this.textBoxCarbo.TabIndex = 12;
            // 
            // textBoxCalories
            // 
            this.textBoxCalories.Location = new System.Drawing.Point(845, 321);
            this.textBoxCalories.Name = "textBoxCalories";
            this.textBoxCalories.Size = new System.Drawing.Size(100, 22);
            this.textBoxCalories.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(333, 346);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "название";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(467, 346);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "жиры";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(596, 346);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "белки";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(730, 346);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "углеводы";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(846, 346);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 16);
            this.label6.TabIndex = 19;
            this.label6.Text = "калорийность";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameproductDataGridViewTextBoxColumn,
            this.fatsproductDataGridViewTextBoxColumn,
            this.proteinproductDataGridViewTextBoxColumn,
            this.carbohydratesproductDataGridViewTextBoxColumn,
            this.caloriesproductDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.productBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(190, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(860, 268);
            this.dataGridView1.TabIndex = 21;
            // 
            // nameproductDataGridViewTextBoxColumn
            // 
            this.nameproductDataGridViewTextBoxColumn.DataPropertyName = "name_product";
            this.nameproductDataGridViewTextBoxColumn.HeaderText = "name_product";
            this.nameproductDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameproductDataGridViewTextBoxColumn.Name = "nameproductDataGridViewTextBoxColumn";
            this.nameproductDataGridViewTextBoxColumn.Width = 125;
            // 
            // fatsproductDataGridViewTextBoxColumn
            // 
            this.fatsproductDataGridViewTextBoxColumn.DataPropertyName = "Fats_product";
            this.fatsproductDataGridViewTextBoxColumn.HeaderText = "Fats_product";
            this.fatsproductDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fatsproductDataGridViewTextBoxColumn.Name = "fatsproductDataGridViewTextBoxColumn";
            this.fatsproductDataGridViewTextBoxColumn.Width = 125;
            // 
            // proteinproductDataGridViewTextBoxColumn
            // 
            this.proteinproductDataGridViewTextBoxColumn.DataPropertyName = "protein_product";
            this.proteinproductDataGridViewTextBoxColumn.HeaderText = "protein_product";
            this.proteinproductDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.proteinproductDataGridViewTextBoxColumn.Name = "proteinproductDataGridViewTextBoxColumn";
            this.proteinproductDataGridViewTextBoxColumn.Width = 125;
            // 
            // carbohydratesproductDataGridViewTextBoxColumn
            // 
            this.carbohydratesproductDataGridViewTextBoxColumn.DataPropertyName = "carbohydrates_product";
            this.carbohydratesproductDataGridViewTextBoxColumn.HeaderText = "carbohydrates_product";
            this.carbohydratesproductDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.carbohydratesproductDataGridViewTextBoxColumn.Name = "carbohydratesproductDataGridViewTextBoxColumn";
            this.carbohydratesproductDataGridViewTextBoxColumn.Width = 125;
            // 
            // caloriesproductDataGridViewTextBoxColumn
            // 
            this.caloriesproductDataGridViewTextBoxColumn.DataPropertyName = "calories_product";
            this.caloriesproductDataGridViewTextBoxColumn.HeaderText = "calories_product";
            this.caloriesproductDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.caloriesproductDataGridViewTextBoxColumn.Name = "caloriesproductDataGridViewTextBoxColumn";
            this.caloriesproductDataGridViewTextBoxColumn.Width = 125;
            // 
            // productBindingSource2
            // 
            this.productBindingSource2.DataMember = "product";
            this.productBindingSource2.DataSource = this.racion_pitaniyaDataSet12;
            // 
            // racion_pitaniyaDataSet12
            // 
            this.racion_pitaniyaDataSet12.DataSetName = "racion_pitaniyaDataSet12";
            this.racion_pitaniyaDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productTableAdapter2
            // 
            this.productTableAdapter2.ClearBeforeFill = true;
            // 
            // form1BindingSource
            // 
            this.form1BindingSource.DataSource = typeof(курсовая_работа.Form1);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(1221, 442);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxCalories);
            this.Controls.Add(this.textBoxCarbo);
            this.Controls.Add(this.textBoxProtein);
            this.Controls.Add(this.textBoxFast);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.buttonupdate);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonNazat);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.Text = "добавление объектов";
            this.Load += new System.EventHandler(this.Form3_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racion_pitaniyaDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racion_pitaniyaDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racion_pitaniyaDataSet12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonNazat;
        private System.Windows.Forms.BindingSource form1BindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonupdate;
        private racion_pitaniyaDataSet2 racion_pitaniyaDataSet2;
        private System.Windows.Forms.BindingSource productBindingSource;
        private racion_pitaniyaDataSet2TableAdapters.productTableAdapter productTableAdapter;
        private racion_pitaniyaDataSet3 racion_pitaniyaDataSet3;
        private System.Windows.Forms.BindingSource productBindingSource1;
        private racion_pitaniyaDataSet3TableAdapters.productTableAdapter productTableAdapter1;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxFast;
        private System.Windows.Forms.TextBox textBoxProtein;
        private System.Windows.Forms.TextBox textBoxCarbo;
        private System.Windows.Forms.TextBox textBoxCalories;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private racion_pitaniyaDataSet12 racion_pitaniyaDataSet12;
        private System.Windows.Forms.BindingSource productBindingSource2;
        private racion_pitaniyaDataSet12TableAdapters.productTableAdapter productTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameproductDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fatsproductDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn proteinproductDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carbohydratesproductDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn caloriesproductDataGridViewTextBoxColumn;
    }
}