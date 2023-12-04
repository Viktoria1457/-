namespace практика
{
    partial class Смотр_заявки_клиента
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
            this.номерактаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодПредставителяОРКОдиагностикаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датадиагностикиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.характернеисправностипослеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.примечаниеподиагностикеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодПредставителяОРКОремонтDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаремонтаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.содержаниеремонтаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.примечаниепоремонтуDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодоборудованиядлязаменыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.завNоборудованиядлязаменыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодстатусазаказаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.исполнениязаказовBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.практикаDataSet2 = new практика.ПрактикаDataSet2();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.исполнения_заказовTableAdapter = new практика.ПрактикаDataSet2TableAdapters.Исполнения_заказовTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.исполнениязаказовBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.практикаDataSet2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Plum;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.номерактаDataGridViewTextBoxColumn,
            this.кодПредставителяОРКОдиагностикаDataGridViewTextBoxColumn,
            this.датадиагностикиDataGridViewTextBoxColumn,
            this.характернеисправностипослеDataGridViewTextBoxColumn,
            this.примечаниеподиагностикеDataGridViewTextBoxColumn,
            this.кодПредставителяОРКОремонтDataGridViewTextBoxColumn,
            this.датаремонтаDataGridViewTextBoxColumn,
            this.содержаниеремонтаDataGridViewTextBoxColumn,
            this.примечаниепоремонтуDataGridViewTextBoxColumn,
            this.кодоборудованиядлязаменыDataGridViewTextBoxColumn,
            this.завNоборудованиядлязаменыDataGridViewTextBoxColumn,
            this.кодстатусазаказаDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.исполнениязаказовBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(73, 11);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(801, 144);
            this.dataGridView1.TabIndex = 0;
            // 
            // номерактаDataGridViewTextBoxColumn
            // 
            this.номерактаDataGridViewTextBoxColumn.DataPropertyName = "Номер_акта";
            this.номерактаDataGridViewTextBoxColumn.HeaderText = "Номер акта";
            this.номерактаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.номерактаDataGridViewTextBoxColumn.Name = "номерактаDataGridViewTextBoxColumn";
            this.номерактаDataGridViewTextBoxColumn.ReadOnly = true;
            this.номерактаDataGridViewTextBoxColumn.Width = 125;
            // 
            // кодПредставителяОРКОдиагностикаDataGridViewTextBoxColumn
            // 
            this.кодПредставителяОРКОдиагностикаDataGridViewTextBoxColumn.DataPropertyName = "Код_Представителя_ОРКО_диагностика";
            this.кодПредставителяОРКОдиагностикаDataGridViewTextBoxColumn.HeaderText = "Код Представителя ОРКО_диагностика";
            this.кодПредставителяОРКОдиагностикаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.кодПредставителяОРКОдиагностикаDataGridViewTextBoxColumn.Name = "кодПредставителяОРКОдиагностикаDataGridViewTextBoxColumn";
            this.кодПредставителяОРКОдиагностикаDataGridViewTextBoxColumn.Width = 125;
            // 
            // датадиагностикиDataGridViewTextBoxColumn
            // 
            this.датадиагностикиDataGridViewTextBoxColumn.DataPropertyName = "Дата_диагностики";
            this.датадиагностикиDataGridViewTextBoxColumn.HeaderText = "Дата диагностики";
            this.датадиагностикиDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.датадиагностикиDataGridViewTextBoxColumn.Name = "датадиагностикиDataGridViewTextBoxColumn";
            this.датадиагностикиDataGridViewTextBoxColumn.Width = 125;
            // 
            // характернеисправностипослеDataGridViewTextBoxColumn
            // 
            this.характернеисправностипослеDataGridViewTextBoxColumn.DataPropertyName = "Характер_неисправности_после";
            this.характернеисправностипослеDataGridViewTextBoxColumn.HeaderText = "Характер неисправности_после";
            this.характернеисправностипослеDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.характернеисправностипослеDataGridViewTextBoxColumn.Name = "характернеисправностипослеDataGridViewTextBoxColumn";
            this.характернеисправностипослеDataGridViewTextBoxColumn.Width = 125;
            // 
            // примечаниеподиагностикеDataGridViewTextBoxColumn
            // 
            this.примечаниеподиагностикеDataGridViewTextBoxColumn.DataPropertyName = "Примечание_по_диагностике";
            this.примечаниеподиагностикеDataGridViewTextBoxColumn.HeaderText = "Примечание по диагностике";
            this.примечаниеподиагностикеDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.примечаниеподиагностикеDataGridViewTextBoxColumn.Name = "примечаниеподиагностикеDataGridViewTextBoxColumn";
            this.примечаниеподиагностикеDataGridViewTextBoxColumn.Width = 125;
            // 
            // кодПредставителяОРКОремонтDataGridViewTextBoxColumn
            // 
            this.кодПредставителяОРКОремонтDataGridViewTextBoxColumn.DataPropertyName = "Код_Представителя_ОРКО_ремонт";
            this.кодПредставителяОРКОремонтDataGridViewTextBoxColumn.HeaderText = "Код Представителя ОРКО_ремонт";
            this.кодПредставителяОРКОремонтDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.кодПредставителяОРКОремонтDataGridViewTextBoxColumn.Name = "кодПредставителяОРКОремонтDataGridViewTextBoxColumn";
            this.кодПредставителяОРКОремонтDataGridViewTextBoxColumn.Width = 125;
            // 
            // датаремонтаDataGridViewTextBoxColumn
            // 
            this.датаремонтаDataGridViewTextBoxColumn.DataPropertyName = "Дата_ремонта";
            this.датаремонтаDataGridViewTextBoxColumn.HeaderText = "Дата ремонта";
            this.датаремонтаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.датаремонтаDataGridViewTextBoxColumn.Name = "датаремонтаDataGridViewTextBoxColumn";
            this.датаремонтаDataGridViewTextBoxColumn.Width = 125;
            // 
            // содержаниеремонтаDataGridViewTextBoxColumn
            // 
            this.содержаниеремонтаDataGridViewTextBoxColumn.DataPropertyName = "Содержание_ремонта";
            this.содержаниеремонтаDataGridViewTextBoxColumn.HeaderText = "Содержание ремонта";
            this.содержаниеремонтаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.содержаниеремонтаDataGridViewTextBoxColumn.Name = "содержаниеремонтаDataGridViewTextBoxColumn";
            this.содержаниеремонтаDataGridViewTextBoxColumn.Width = 125;
            // 
            // примечаниепоремонтуDataGridViewTextBoxColumn
            // 
            this.примечаниепоремонтуDataGridViewTextBoxColumn.DataPropertyName = "Примечание_по_ремонту";
            this.примечаниепоремонтуDataGridViewTextBoxColumn.HeaderText = "Примечание по ремонту";
            this.примечаниепоремонтуDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.примечаниепоремонтуDataGridViewTextBoxColumn.Name = "примечаниепоремонтуDataGridViewTextBoxColumn";
            this.примечаниепоремонтуDataGridViewTextBoxColumn.Width = 125;
            // 
            // кодоборудованиядлязаменыDataGridViewTextBoxColumn
            // 
            this.кодоборудованиядлязаменыDataGridViewTextBoxColumn.DataPropertyName = "Код_оборудования_для_замены";
            this.кодоборудованиядлязаменыDataGridViewTextBoxColumn.HeaderText = "Код оборудования для замены";
            this.кодоборудованиядлязаменыDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.кодоборудованиядлязаменыDataGridViewTextBoxColumn.Name = "кодоборудованиядлязаменыDataGridViewTextBoxColumn";
            this.кодоборудованиядлязаменыDataGridViewTextBoxColumn.Width = 125;
            // 
            // завNоборудованиядлязаменыDataGridViewTextBoxColumn
            // 
            this.завNоборудованиядлязаменыDataGridViewTextBoxColumn.DataPropertyName = "Зав_N_оборудования_для_замены";
            this.завNоборудованиядлязаменыDataGridViewTextBoxColumn.HeaderText = "Зав N оборудования для замены";
            this.завNоборудованиядлязаменыDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.завNоборудованиядлязаменыDataGridViewTextBoxColumn.Name = "завNоборудованиядлязаменыDataGridViewTextBoxColumn";
            this.завNоборудованиядлязаменыDataGridViewTextBoxColumn.Width = 125;
            // 
            // кодстатусазаказаDataGridViewTextBoxColumn
            // 
            this.кодстатусазаказаDataGridViewTextBoxColumn.DataPropertyName = "Код_статуса_заказа";
            this.кодстатусазаказаDataGridViewTextBoxColumn.HeaderText = "Код статуса заказа";
            this.кодстатусазаказаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.кодстатусазаказаDataGridViewTextBoxColumn.Name = "кодстатусазаказаDataGridViewTextBoxColumn";
            this.кодстатусазаказаDataGridViewTextBoxColumn.Width = 125;
            // 
            // исполнениязаказовBindingSource
            // 
            this.исполнениязаказовBindingSource.DataMember = "Исполнения_заказов";
            this.исполнениязаказовBindingSource.DataSource = this.практикаDataSet2;
            // 
            // практикаDataSet2
            // 
            this.практикаDataSet2.DataSetName = "ПрактикаDataSet2";
            this.практикаDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.AliceBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(498, 186);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(205, 51);
            this.button1.TabIndex = 1;
            this.button1.Text = "Вернутся в меню";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.AliceBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(724, 186);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 51);
            this.button2.TabIndex = 2;
            this.button2.Text = "Выход ";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Lavender;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(24, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(890, 252);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 3;
            // 
            // исполнения_заказовTableAdapter
            // 
            this.исполнения_заказовTableAdapter.ClearBeforeFill = true;
            // 
            // Смотр_заявки_клиента
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(938, 291);
            this.Controls.Add(this.groupBox1);
            this.Name = "Смотр_заявки_клиента";
            this.Text = "Смотр_заявки_клиента";
            this.Load += new System.EventHandler(this.Смотр_заявки_клиента_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.исполнениязаказовBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.практикаDataSet2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private ПрактикаDataSet2 практикаDataSet2;
        private System.Windows.Forms.BindingSource исполнениязаказовBindingSource;
        private ПрактикаDataSet2TableAdapters.Исполнения_заказовTableAdapter исполнения_заказовTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерактаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодПредставителяОРКОдиагностикаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датадиагностикиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn характернеисправностипослеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn примечаниеподиагностикеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодПредставителяОРКОремонтDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаремонтаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn содержаниеремонтаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn примечаниепоремонтуDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодоборудованиядлязаменыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn завNоборудованиядлязаменыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодстатусазаказаDataGridViewTextBoxColumn;
    }
}