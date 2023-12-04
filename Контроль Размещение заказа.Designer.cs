namespace практика
{
    partial class Размещение_заказа
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
            this.практикаDataSet4 = new практика.ПрактикаDataSet4();
            this.размешениезаказовBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.размешение_заказовTableAdapter = new практика.ПрактикаDataSet4TableAdapters.Размешение_заказовTableAdapter();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.практикаDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.размешениезаказовBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
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
            this.dataGridView1.Location = new System.Drawing.Point(34, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(932, 166);
            this.dataGridView1.TabIndex = 0;
            // 
            // практикаDataSet4
            // 
            this.практикаDataSet4.DataSetName = "ПрактикаDataSet4";
            this.практикаDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // размешениезаказовBindingSource
            // 
            this.размешениезаказовBindingSource.DataMember = "Размешение_заказов";
            this.размешениезаказовBindingSource.DataSource = this.практикаDataSet4;
            // 
            // размешение_заказовTableAdapter
            // 
            this.размешение_заказовTableAdapter.ClearBeforeFill = true;
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
            this.кодПредставителязаказчикасдачаDataGridViewTextBoxColumn.HeaderText = "Код Представителя заказчика сдача";
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
            this.кодПредставителяОРКОприемDataGridViewTextBoxColumn.HeaderText = "Код Представителя ОРКО прием";
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
            // Размещение_заказа
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 602);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Размещение_заказа";
            this.Text = "Размещение_заказа";
            this.Load += new System.EventHandler(this.Размещение_заказа_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.практикаDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.размешениезаказовBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private ПрактикаDataSet4 практикаDataSet4;
        private System.Windows.Forms.BindingSource размешениезаказовBindingSource;
        private ПрактикаDataSet4TableAdapters.Размешение_заказовTableAdapter размешение_заказовTableAdapter;
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