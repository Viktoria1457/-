namespace практика
{
    partial class Контроль_выполнения_заказов
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.номерактовDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодзаказчикаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодПредставителязаказчикасдачаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датазаказаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.коднаименованияоборудованияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.завNоборудованияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.имяNоборудованияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодхарактеранеисправностиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодПредставителяОРКОприемDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.комплекстностьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.приемзаказчикаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.размешениезаказовBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.практикаDataSet = new практика.ПрактикаDataSet();
            this.размешение_заказовTableAdapter = new практика.ПрактикаDataSetTableAdapters.Размешение_заказовTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.размешениезаказовBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.практикаDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Thistle;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.номерактовDataGridViewTextBoxColumn,
            this.кодзаказчикаDataGridViewTextBoxColumn,
            this.кодПредставителязаказчикасдачаDataGridViewTextBoxColumn,
            this.датазаказаDataGridViewTextBoxColumn,
            this.коднаименованияоборудованияDataGridViewTextBoxColumn,
            this.завNоборудованияDataGridViewTextBoxColumn,
            this.имяNоборудованияDataGridViewTextBoxColumn,
            this.кодхарактеранеисправностиDataGridViewTextBoxColumn,
            this.кодПредставителяОРКОприемDataGridViewTextBoxColumn,
            this.комплекстностьDataGridViewTextBoxColumn,
            this.приемзаказчикаDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.размешениезаказовBindingSource;
            this.dataGridView1.GridColor = System.Drawing.Color.DarkViolet;
            this.dataGridView1.Location = new System.Drawing.Point(24, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(970, 195);
            this.dataGridView1.TabIndex = 0;
            // 
            // номерактовDataGridViewTextBoxColumn
            // 
            this.номерактовDataGridViewTextBoxColumn.DataPropertyName = "Номер_актов";
            this.номерактовDataGridViewTextBoxColumn.HeaderText = "Номер актов";
            this.номерактовDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.номерактовDataGridViewTextBoxColumn.Name = "номерактовDataGridViewTextBoxColumn";
            this.номерактовDataGridViewTextBoxColumn.ReadOnly = true;
            this.номерактовDataGridViewTextBoxColumn.Width = 125;
            // 
            // кодзаказчикаDataGridViewTextBoxColumn
            // 
            this.кодзаказчикаDataGridViewTextBoxColumn.DataPropertyName = "Код_заказчика";
            this.кодзаказчикаDataGridViewTextBoxColumn.HeaderText = "Код заказчика";
            this.кодзаказчикаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.кодзаказчикаDataGridViewTextBoxColumn.Name = "кодзаказчикаDataGridViewTextBoxColumn";
            this.кодзаказчикаDataGridViewTextBoxColumn.Width = 125;
            // 
            // кодПредставителязаказчикасдачаDataGridViewTextBoxColumn
            // 
            this.кодПредставителязаказчикасдачаDataGridViewTextBoxColumn.DataPropertyName = "Код_Представителя_заказчика_сдача";
            this.кодПредставителязаказчикасдачаDataGridViewTextBoxColumn.HeaderText = "Код Представителя заказчика_сдача";
            this.кодПредставителязаказчикасдачаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.кодПредставителязаказчикасдачаDataGridViewTextBoxColumn.Name = "кодПредставителязаказчикасдачаDataGridViewTextBoxColumn";
            this.кодПредставителязаказчикасдачаDataGridViewTextBoxColumn.Width = 125;
            // 
            // датазаказаDataGridViewTextBoxColumn
            // 
            this.датазаказаDataGridViewTextBoxColumn.DataPropertyName = "Дата_заказа";
            this.датазаказаDataGridViewTextBoxColumn.HeaderText = "Дата заказа";
            this.датазаказаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.датазаказаDataGridViewTextBoxColumn.Name = "датазаказаDataGridViewTextBoxColumn";
            this.датазаказаDataGridViewTextBoxColumn.Width = 125;
            // 
            // коднаименованияоборудованияDataGridViewTextBoxColumn
            // 
            this.коднаименованияоборудованияDataGridViewTextBoxColumn.DataPropertyName = "Код_наименования_оборудования";
            this.коднаименованияоборудованияDataGridViewTextBoxColumn.HeaderText = "Код наименования оборудования";
            this.коднаименованияоборудованияDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.коднаименованияоборудованияDataGridViewTextBoxColumn.Name = "коднаименованияоборудованияDataGridViewTextBoxColumn";
            this.коднаименованияоборудованияDataGridViewTextBoxColumn.Width = 125;
            // 
            // завNоборудованияDataGridViewTextBoxColumn
            // 
            this.завNоборудованияDataGridViewTextBoxColumn.DataPropertyName = "Зав_N_оборудования";
            this.завNоборудованияDataGridViewTextBoxColumn.HeaderText = "Зав N оборудования";
            this.завNоборудованияDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.завNоборудованияDataGridViewTextBoxColumn.Name = "завNоборудованияDataGridViewTextBoxColumn";
            this.завNоборудованияDataGridViewTextBoxColumn.Width = 125;
            // 
            // имяNоборудованияDataGridViewTextBoxColumn
            // 
            this.имяNоборудованияDataGridViewTextBoxColumn.DataPropertyName = "Имя_N_оборудования";
            this.имяNоборудованияDataGridViewTextBoxColumn.HeaderText = "Имя N оборудования";
            this.имяNоборудованияDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.имяNоборудованияDataGridViewTextBoxColumn.Name = "имяNоборудованияDataGridViewTextBoxColumn";
            this.имяNоборудованияDataGridViewTextBoxColumn.Width = 125;
            // 
            // кодхарактеранеисправностиDataGridViewTextBoxColumn
            // 
            this.кодхарактеранеисправностиDataGridViewTextBoxColumn.DataPropertyName = "Код_характера_неисправности";
            this.кодхарактеранеисправностиDataGridViewTextBoxColumn.HeaderText = "Код характера неисправности";
            this.кодхарактеранеисправностиDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.кодхарактеранеисправностиDataGridViewTextBoxColumn.Name = "кодхарактеранеисправностиDataGridViewTextBoxColumn";
            this.кодхарактеранеисправностиDataGridViewTextBoxColumn.Width = 125;
            // 
            // кодПредставителяОРКОприемDataGridViewTextBoxColumn
            // 
            this.кодПредставителяОРКОприемDataGridViewTextBoxColumn.DataPropertyName = "Код_Представителя_ОРКО_прием";
            this.кодПредставителяОРКОприемDataGridViewTextBoxColumn.HeaderText = "Код Представителя ОРКО_прием";
            this.кодПредставителяОРКОприемDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.кодПредставителяОРКОприемDataGridViewTextBoxColumn.Name = "кодПредставителяОРКОприемDataGridViewTextBoxColumn";
            this.кодПредставителяОРКОприемDataGridViewTextBoxColumn.Width = 125;
            // 
            // комплекстностьDataGridViewTextBoxColumn
            // 
            this.комплекстностьDataGridViewTextBoxColumn.DataPropertyName = "Комплекстность";
            this.комплекстностьDataGridViewTextBoxColumn.HeaderText = "Комплекстность";
            this.комплекстностьDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.комплекстностьDataGridViewTextBoxColumn.Name = "комплекстностьDataGridViewTextBoxColumn";
            this.комплекстностьDataGridViewTextBoxColumn.Width = 125;
            // 
            // приемзаказчикаDataGridViewTextBoxColumn
            // 
            this.приемзаказчикаDataGridViewTextBoxColumn.DataPropertyName = "Прием_заказчика";
            this.приемзаказчикаDataGridViewTextBoxColumn.HeaderText = "Прием заказчика";
            this.приемзаказчикаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.приемзаказчикаDataGridViewTextBoxColumn.Name = "приемзаказчикаDataGridViewTextBoxColumn";
            this.приемзаказчикаDataGridViewTextBoxColumn.Width = 125;
            // 
            // размешениезаказовBindingSource
            // 
            this.размешениезаказовBindingSource.DataMember = "Размешение_заказов";
            this.размешениезаказовBindingSource.DataSource = this.практикаDataSet;
            // 
            // практикаDataSet
            // 
            this.практикаDataSet.DataSetName = "ПрактикаDataSet";
            this.практикаDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // размешение_заказовTableAdapter
            // 
            this.размешение_заказовTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MintCream;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(615, 258);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(229, 54);
            this.button1.TabIndex = 1;
            this.button1.Text = "Вернутся обратно ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Lavender;
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(23, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1052, 318);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.MintCream;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.button5.Location = new System.Drawing.Point(860, 258);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(186, 54);
            this.button5.TabIndex = 5;
            this.button5.Text = "Выход";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Контроль_выполнения_заказов
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1101, 353);
            this.Controls.Add(this.groupBox1);
            this.Name = "Контроль_выполнения_заказов";
            this.Text = "Контроль_выполнения_заказов";
            this.Load += new System.EventHandler(this.Контроль_выполнения_заказов_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.размешениезаказовBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.практикаDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private ПрактикаDataSet практикаDataSet;
        private System.Windows.Forms.BindingSource размешениезаказовBindingSource;
        private ПрактикаDataSetTableAdapters.Размешение_заказовTableAdapter размешение_заказовTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерактовDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодзаказчикаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодПредставителязаказчикасдачаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датазаказаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn коднаименованияоборудованияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn завNоборудованияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn имяNоборудованияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодхарактеранеисправностиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодПредставителяОРКОприемDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn комплекстностьDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn приемзаказчикаDataGridViewTextBoxColumn;
    }
}