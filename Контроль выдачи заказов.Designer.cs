namespace практика
{
    partial class Контроль_выдачи_заказов
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.кодактаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодПредставителяОРКОвыдачаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датавыдачиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодпредставителязаказчикавыдачаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодвыдачиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.выдачазаказовBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.практикаDataSet1 = new практика.ПрактикаDataSet1();
            this.выдача_заказовTableAdapter = new практика.ПрактикаDataSet1TableAdapters.Выдача_заказовTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.выдачазаказовBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.практикаDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Lavender;
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(31, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(954, 333);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.MintCream;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Location = new System.Drawing.Point(18, 204);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(363, 54);
            this.button3.TabIndex = 12;
            this.button3.Text = "Редактировать таблицу";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MintCream;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(195, 273);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(316, 54);
            this.button2.TabIndex = 11;
            this.button2.Text = "Обновить таблицу";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.MintCream;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.button5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button5.Location = new System.Drawing.Point(745, 273);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(186, 54);
            this.button5.TabIndex = 7;
            this.button5.Text = "Выход";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MintCream;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(540, 204);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(259, 54);
            this.button1.TabIndex = 6;
            this.button1.Text = "Вернутся обратно ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Thistle;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодактаDataGridViewTextBoxColumn,
            this.кодПредставителяОРКОвыдачаDataGridViewTextBoxColumn,
            this.датавыдачиDataGridViewTextBoxColumn,
            this.кодпредставителязаказчикавыдачаDataGridViewTextBoxColumn,
            this.кодвыдачиDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.выдачазаказовBindingSource;
            this.dataGridView1.GridColor = System.Drawing.Color.PaleVioletRed;
            this.dataGridView1.Location = new System.Drawing.Point(18, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(699, 146);
            this.dataGridView1.TabIndex = 0;
            // 
            // кодактаDataGridViewTextBoxColumn
            // 
            this.кодактаDataGridViewTextBoxColumn.DataPropertyName = "Код_акта";
            this.кодактаDataGridViewTextBoxColumn.HeaderText = "Код акта";
            this.кодактаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.кодактаDataGridViewTextBoxColumn.Name = "кодактаDataGridViewTextBoxColumn";
            this.кодактаDataGridViewTextBoxColumn.ReadOnly = true;
            this.кодактаDataGridViewTextBoxColumn.Width = 125;
            // 
            // кодПредставителяОРКОвыдачаDataGridViewTextBoxColumn
            // 
            this.кодПредставителяОРКОвыдачаDataGridViewTextBoxColumn.DataPropertyName = "Код_Представителя_ОРКО_выдача";
            this.кодПредставителяОРКОвыдачаDataGridViewTextBoxColumn.HeaderText = "Код Представителя ОРКО выдача";
            this.кодПредставителяОРКОвыдачаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.кодПредставителяОРКОвыдачаDataGridViewTextBoxColumn.Name = "кодПредставителяОРКОвыдачаDataGridViewTextBoxColumn";
            this.кодПредставителяОРКОвыдачаDataGridViewTextBoxColumn.Width = 125;
            // 
            // датавыдачиDataGridViewTextBoxColumn
            // 
            this.датавыдачиDataGridViewTextBoxColumn.DataPropertyName = "Дата_выдачи";
            this.датавыдачиDataGridViewTextBoxColumn.HeaderText = "Дата выдачи";
            this.датавыдачиDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.датавыдачиDataGridViewTextBoxColumn.Name = "датавыдачиDataGridViewTextBoxColumn";
            this.датавыдачиDataGridViewTextBoxColumn.Width = 125;
            // 
            // кодпредставителязаказчикавыдачаDataGridViewTextBoxColumn
            // 
            this.кодпредставителязаказчикавыдачаDataGridViewTextBoxColumn.DataPropertyName = "Код_представителя_заказчика_выдача";
            this.кодпредставителязаказчикавыдачаDataGridViewTextBoxColumn.HeaderText = "Код представителя заказчика выдача";
            this.кодпредставителязаказчикавыдачаDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.кодпредставителязаказчикавыдачаDataGridViewTextBoxColumn.Name = "кодпредставителязаказчикавыдачаDataGridViewTextBoxColumn";
            this.кодпредставителязаказчикавыдачаDataGridViewTextBoxColumn.Width = 125;
            // 
            // кодвыдачиDataGridViewTextBoxColumn
            // 
            this.кодвыдачиDataGridViewTextBoxColumn.DataPropertyName = "Код_выдачи";
            this.кодвыдачиDataGridViewTextBoxColumn.HeaderText = "Код выдачи";
            this.кодвыдачиDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.кодвыдачиDataGridViewTextBoxColumn.Name = "кодвыдачиDataGridViewTextBoxColumn";
            this.кодвыдачиDataGridViewTextBoxColumn.Width = 125;
            // 
            // выдачазаказовBindingSource
            // 
            this.выдачазаказовBindingSource.DataMember = "Выдача_заказов";
            this.выдачазаказовBindingSource.DataSource = this.практикаDataSet1;
            // 
            // практикаDataSet1
            // 
            this.практикаDataSet1.DataSetName = "ПрактикаDataSet1";
            this.практикаDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // выдача_заказовTableAdapter
            // 
            this.выдача_заказовTableAdapter.ClearBeforeFill = true;
            // 
            // Контроль_выдачи_заказов
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(997, 371);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.OliveDrab;
            this.Name = "Контроль_выдачи_заказов";
            this.Text = "Контроль_выдачи_заказов";
            this.Load += new System.EventHandler(this.Контроль_выдачи_заказов_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.выдачазаказовBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.практикаDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ПрактикаDataSet1 практикаDataSet1;
        private System.Windows.Forms.BindingSource выдачазаказовBindingSource;
        private ПрактикаDataSet1TableAdapters.Выдача_заказовTableAdapter выдача_заказовTableAdapter;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодактаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодПредставителяОРКОвыдачаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датавыдачиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодпредставителязаказчикавыдачаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодвыдачиDataGridViewTextBoxColumn;
    }
}