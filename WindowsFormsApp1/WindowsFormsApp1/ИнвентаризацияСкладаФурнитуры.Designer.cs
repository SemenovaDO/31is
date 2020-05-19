namespace WindowsFormsApp1
{
    partial class ИнвентаризацияСкладаФурнитуры
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.складФурнитурыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.партияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.артикулФурнитурыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фурнитураDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.складФурнитурыBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(303, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Инвентаризация склада фурнитуры";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(713, 344);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Выйти";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.партияDataGridViewTextBoxColumn,
            this.артикулФурнитурыDataGridViewTextBoxColumn,
            this.количествоDataGridViewTextBoxColumn,
            this.фурнитураDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.складФурнитурыBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(33, 96);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(755, 150);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // складФурнитурыBindingSource
            // 
            this.складФурнитурыBindingSource.DataSource = typeof(WindowsFormsApp1.СкладФурнитуры);
            // 
            // партияDataGridViewTextBoxColumn
            // 
            this.партияDataGridViewTextBoxColumn.DataPropertyName = "Партия";
            this.партияDataGridViewTextBoxColumn.HeaderText = "Партия";
            this.партияDataGridViewTextBoxColumn.Name = "партияDataGridViewTextBoxColumn";
            // 
            // артикулФурнитурыDataGridViewTextBoxColumn
            // 
            this.артикулФурнитурыDataGridViewTextBoxColumn.DataPropertyName = "АртикулФурнитуры";
            this.артикулФурнитурыDataGridViewTextBoxColumn.HeaderText = "АртикулФурнитуры";
            this.артикулФурнитурыDataGridViewTextBoxColumn.Name = "артикулФурнитурыDataGridViewTextBoxColumn";
            // 
            // количествоDataGridViewTextBoxColumn
            // 
            this.количествоDataGridViewTextBoxColumn.DataPropertyName = "Количество";
            this.количествоDataGridViewTextBoxColumn.HeaderText = "Количество";
            this.количествоDataGridViewTextBoxColumn.Name = "количествоDataGridViewTextBoxColumn";
            // 
            // фурнитураDataGridViewTextBoxColumn
            // 
            this.фурнитураDataGridViewTextBoxColumn.DataPropertyName = "Фурнитура";
            this.фурнитураDataGridViewTextBoxColumn.HeaderText = "Фурнитура";
            this.фурнитураDataGridViewTextBoxColumn.Name = "фурнитураDataGridViewTextBoxColumn";
            // 
            // ИнвентаризацияСкладаФурнитуры
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 387);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "ИнвентаризацияСкладаФурнитуры";
            this.Text = "ИнвентаризацияСкладаФурнитуры";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.складФурнитурыBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn партияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn артикулФурнитурыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фурнитураDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource складФурнитурыBindingSource;
    }
}