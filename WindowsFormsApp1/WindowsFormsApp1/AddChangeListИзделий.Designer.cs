namespace WindowsFormsApp1
{
    partial class AddChangeListИзделий
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddChangeListИзделий));
            System.Windows.Forms.Label ширинаLabel;
            System.Windows.Forms.Label наименованиеLabel;
            System.Windows.Forms.Label длинаLabel;
            System.Windows.Forms.Label артикулLabel;
            this.изделиеBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.изделиеBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.ширинаTextBox = new System.Windows.Forms.TextBox();
            this.наименованиеTextBox = new System.Windows.Forms.TextBox();
            this.артикулTextBox = new System.Windows.Forms.TextBox();
            this.длинаTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.изделиеBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ширинаLabel = new System.Windows.Forms.Label();
            наименованиеLabel = new System.Windows.Forms.Label();
            длинаLabel = new System.Windows.Forms.Label();
            артикулLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.изделиеBindingNavigator)).BeginInit();
            this.изделиеBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.изделиеBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // изделиеBindingNavigator
            // 
            this.изделиеBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.изделиеBindingNavigator.BindingSource = this.изделиеBindingSource;
            this.изделиеBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.изделиеBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.изделиеBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.изделиеBindingNavigatorSaveItem});
            this.изделиеBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.изделиеBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.изделиеBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.изделиеBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.изделиеBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.изделиеBindingNavigator.Name = "изделиеBindingNavigator";
            this.изделиеBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.изделиеBindingNavigator.Size = new System.Drawing.Size(447, 25);
            this.изделиеBindingNavigator.TabIndex = 0;
            this.изделиеBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // изделиеBindingNavigatorSaveItem
            // 
            this.изделиеBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.изделиеBindingNavigatorSaveItem.Enabled = false;
            this.изделиеBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("изделиеBindingNavigatorSaveItem.Image")));
            this.изделиеBindingNavigatorSaveItem.Name = "изделиеBindingNavigatorSaveItem";
            this.изделиеBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.изделиеBindingNavigatorSaveItem.Text = "Сохранить данные";
            // 
            // ширинаTextBox
            // 
            this.ширинаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.изделиеBindingSource, "Ширина", true));
            this.ширинаTextBox.Location = new System.Drawing.Point(197, 120);
            this.ширинаTextBox.Name = "ширинаTextBox";
            this.ширинаTextBox.Size = new System.Drawing.Size(100, 20);
            this.ширинаTextBox.TabIndex = 10;
            // 
            // ширинаLabel
            // 
            ширинаLabel.AutoSize = true;
            ширинаLabel.Location = new System.Drawing.Point(107, 120);
            ширинаLabel.Name = "ширинаLabel";
            ширинаLabel.Size = new System.Drawing.Size(49, 13);
            ширинаLabel.TabIndex = 9;
            ширинаLabel.Text = "Ширина:";
            // 
            // наименованиеTextBox
            // 
            this.наименованиеTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.изделиеBindingSource, "Наименование", true));
            this.наименованиеTextBox.Location = new System.Drawing.Point(197, 87);
            this.наименованиеTextBox.Name = "наименованиеTextBox";
            this.наименованиеTextBox.Size = new System.Drawing.Size(100, 20);
            this.наименованиеTextBox.TabIndex = 8;
            // 
            // наименованиеLabel
            // 
            наименованиеLabel.AutoSize = true;
            наименованиеLabel.Location = new System.Drawing.Point(105, 87);
            наименованиеLabel.Name = "наименованиеLabel";
            наименованиеLabel.Size = new System.Drawing.Size(86, 13);
            наименованиеLabel.TabIndex = 7;
            наименованиеLabel.Text = "Наименование:";
            // 
            // артикулTextBox
            // 
            this.артикулTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.изделиеBindingSource, "Артикул", true));
            this.артикулTextBox.Location = new System.Drawing.Point(197, 54);
            this.артикулTextBox.Name = "артикулTextBox";
            this.артикулTextBox.Size = new System.Drawing.Size(100, 20);
            this.артикулTextBox.TabIndex = 2;
            // 
            // длинаTextBox
            // 
            this.длинаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.изделиеBindingSource, "Длина", true));
            this.длинаTextBox.Location = new System.Drawing.Point(197, 152);
            this.длинаTextBox.Name = "длинаTextBox";
            this.длинаTextBox.Size = new System.Drawing.Size(100, 20);
            this.длинаTextBox.TabIndex = 4;
            // 
            // длинаLabel
            // 
            длинаLabel.AutoSize = true;
            длинаLabel.Location = new System.Drawing.Point(107, 152);
            длинаLabel.Name = "длинаLabel";
            длинаLabel.Size = new System.Drawing.Size(43, 13);
            длинаLabel.TabIndex = 3;
            длинаLabel.Text = "Длина:";
            // 
            // артикулLabel
            // 
            артикулLabel.AutoSize = true;
            артикулLabel.Location = new System.Drawing.Point(105, 57);
            артикулLabel.Name = "артикулLabel";
            артикулLabel.Size = new System.Drawing.Size(51, 13);
            артикулLabel.TabIndex = 1;
            артикулLabel.Text = "Артикул:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(75, 206);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(257, 206);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Выйти";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // изделиеBindingSource
            // 
            this.изделиеBindingSource.DataSource = typeof(WindowsFormsApp1.Изделие);
            // 
            // AddListИзделий
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 262);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(артикулLabel);
            this.Controls.Add(this.артикулTextBox);
            this.Controls.Add(длинаLabel);
            this.Controls.Add(this.длинаTextBox);
            this.Controls.Add(наименованиеLabel);
            this.Controls.Add(this.наименованиеTextBox);
            this.Controls.Add(ширинаLabel);
            this.Controls.Add(this.ширинаTextBox);
            this.Controls.Add(this.изделиеBindingNavigator);
            this.Name = "AddListИзделий";
            this.Text = "Добавление изделий";
            this.Load += new System.EventHandler(this.AddListИзделий_Load);
            ((System.ComponentModel.ISupportInitialize)(this.изделиеBindingNavigator)).EndInit();
            this.изделиеBindingNavigator.ResumeLayout(false);
            this.изделиеBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.изделиеBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource изделиеBindingSource;
        private System.Windows.Forms.BindingNavigator изделиеBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton изделиеBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox ширинаTextBox;
        private System.Windows.Forms.TextBox наименованиеTextBox;
        private System.Windows.Forms.TextBox артикулTextBox;
        private System.Windows.Forms.TextBox длинаTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}