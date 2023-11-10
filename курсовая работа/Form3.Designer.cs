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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.racion_pitaniyaDataSet2 = new курсовая_работа.racion_pitaniyaDataSet2();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productTableAdapter = new курсовая_работа.racion_pitaniyaDataSet2TableAdapters.productTableAdapter();
            this.idproductDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameproductDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fatsproductDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proteinproductDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carbohydratesproductDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caloriesproductDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idrazdelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.racion_pitaniyaDataSet3 = new курсовая_работа.racion_pitaniyaDataSet3();
            this.productBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.productTableAdapter1 = new курсовая_работа.racion_pitaniyaDataSet3TableAdapters.productTableAdapter();
            this.form1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racion_pitaniyaDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racion_pitaniyaDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SpringGreen;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(2, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 38);
            this.button1.TabIndex = 2;
            this.button1.Text = "выход";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idproductDataGridViewTextBoxColumn,
            this.nameproductDataGridViewTextBoxColumn,
            this.fatsproductDataGridViewTextBoxColumn,
            this.proteinproductDataGridViewTextBoxColumn,
            this.carbohydratesproductDataGridViewTextBoxColumn,
            this.caloriesproductDataGridViewTextBoxColumn,
            this.idrazdelDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.productBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(2, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1324, 334);
            this.dataGridView1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(300, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "добавление продуктов";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(2, 416);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1324, 22);
            this.textBox1.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SpringGreen;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(1216, 459);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 38);
            this.button2.TabIndex = 6;
            this.button2.Text = "сохранить";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.SpringGreen;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(2, 459);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 38);
            this.button3.TabIndex = 7;
            this.button3.Text = "обновить";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // racion_pitaniyaDataSet2
            // 
            this.racion_pitaniyaDataSet2.DataSetName = "racion_pitaniyaDataSet2";
            this.racion_pitaniyaDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "product";
            this.productBindingSource.DataSource = this.racion_pitaniyaDataSet2;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // idproductDataGridViewTextBoxColumn
            // 
            this.idproductDataGridViewTextBoxColumn.DataPropertyName = "id_product";
            this.idproductDataGridViewTextBoxColumn.HeaderText = "id_product";
            this.idproductDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idproductDataGridViewTextBoxColumn.Name = "idproductDataGridViewTextBoxColumn";
            this.idproductDataGridViewTextBoxColumn.Width = 125;
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
            // idrazdelDataGridViewTextBoxColumn
            // 
            this.idrazdelDataGridViewTextBoxColumn.DataPropertyName = "id_razdel";
            this.idrazdelDataGridViewTextBoxColumn.HeaderText = "id_razdel";
            this.idrazdelDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idrazdelDataGridViewTextBoxColumn.Name = "idrazdelDataGridViewTextBoxColumn";
            this.idrazdelDataGridViewTextBoxColumn.Width = 125;
            // 
            // racion_pitaniyaDataSet3
            // 
            this.racion_pitaniyaDataSet3.DataSetName = "racion_pitaniyaDataSet3";
            this.racion_pitaniyaDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productBindingSource1
            // 
            this.productBindingSource1.DataMember = "product";
            this.productBindingSource1.DataSource = this.racion_pitaniyaDataSet3;
            // 
            // productTableAdapter1
            // 
            this.productTableAdapter1.ClearBeforeFill = true;
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
            this.ClientSize = new System.Drawing.Size(1488, 525);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.Text = "добавление объектов";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racion_pitaniyaDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racion_pitaniyaDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource form1BindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private racion_pitaniyaDataSet2 racion_pitaniyaDataSet2;
        private System.Windows.Forms.BindingSource productBindingSource;
        private racion_pitaniyaDataSet2TableAdapters.productTableAdapter productTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idproductDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameproductDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fatsproductDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn proteinproductDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carbohydratesproductDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn caloriesproductDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idrazdelDataGridViewTextBoxColumn;
        private racion_pitaniyaDataSet3 racion_pitaniyaDataSet3;
        private System.Windows.Forms.BindingSource productBindingSource1;
        private racion_pitaniyaDataSet3TableAdapters.productTableAdapter productTableAdapter1;
    }
}