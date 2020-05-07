namespace WindowsFormsApp1
{
    partial class AddChangeListFurnitura
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
            System.Windows.Forms.Label артикулLabel;
            System.Windows.Forms.Label весLabel;
            System.Windows.Forms.Label длинаLabel;
            System.Windows.Forms.Label наименованиеLabel;
            System.Windows.Forms.Label типLabel;
            System.Windows.Forms.Label ценаLabel;
            System.Windows.Forms.Label ширинаLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddChangeListFurnitura));
            this.фурнитураBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.фурнитураBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.фурнитураBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.артикулTextBox = new System.Windows.Forms.TextBox();
            this.весTextBox = new System.Windows.Forms.TextBox();
            this.длинаTextBox = new System.Windows.Forms.TextBox();
            this.наименованиеTextBox = new System.Windows.Forms.TextBox();
            this.типTextBox = new System.Windows.Forms.TextBox();
            this.ценаTextBox = new System.Windows.Forms.TextBox();
            this.ширинаTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            артикулLabel = new System.Windows.Forms.Label();
            весLabel = new System.Windows.Forms.Label();
            длинаLabel = new System.Windows.Forms.Label();
            наименованиеLabel = new System.Windows.Forms.Label();
            типLabel = new System.Windows.Forms.Label();
            ценаLabel = new System.Windows.Forms.Label();
            ширинаLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.фурнитураBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.фурнитураBindingNavigator)).BeginInit();
            this.фурнитураBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // артикулLabel
            // 
            артикулLabel.AutoSize = true;
            артикулLabel.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            артикулLabel.Location = new System.Drawing.Point(99, 49);
            артикулLabel.Name = "артикулLabel";
            артикулLabel.Size = new System.Drawing.Size(88, 18);
            артикулLabel.TabIndex = 1;
            артикулLabel.Text = "Артикул:";
            // 
            // весLabel
            // 
            весLabel.AutoSize = true;
            весLabel.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            весLabel.Location = new System.Drawing.Point(99, 161);
            весLabel.Name = "весLabel";
            весLabel.Size = new System.Drawing.Size(42, 18);
            весLabel.TabIndex = 3;
            весLabel.Text = "Вес:";
            // 
            // длинаLabel
            // 
            длинаLabel.AutoSize = true;
            длинаLabel.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            длинаLabel.Location = new System.Drawing.Point(99, 106);
            длинаLabel.Name = "длинаLabel";
            длинаLabel.Size = new System.Drawing.Size(66, 18);
            длинаLabel.TabIndex = 5;
            длинаLabel.Text = "Длина:";
            // 
            // наименованиеLabel
            // 
            наименованиеLabel.AutoSize = true;
            наименованиеLabel.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            наименованиеLabel.Location = new System.Drawing.Point(99, 78);
            наименованиеLabel.Name = "наименованиеLabel";
            наименованиеLabel.Size = new System.Drawing.Size(136, 18);
            наименованиеLabel.TabIndex = 7;
            наименованиеLabel.Text = "Наименование:";
            // 
            // типLabel
            // 
            типLabel.AutoSize = true;
            типLabel.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            типLabel.Location = new System.Drawing.Point(99, 189);
            типLabel.Name = "типLabel";
            типLabel.Size = new System.Drawing.Size(43, 18);
            типLabel.TabIndex = 9;
            типLabel.Text = "Тип:";
            // 
            // ценаLabel
            // 
            ценаLabel.AutoSize = true;
            ценаLabel.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            ценаLabel.Location = new System.Drawing.Point(99, 217);
            ценаLabel.Name = "ценаLabel";
            ценаLabel.Size = new System.Drawing.Size(56, 18);
            ценаLabel.TabIndex = 11;
            ценаLabel.Text = "Цена:";
            // 
            // ширинаLabel
            // 
            ширинаLabel.AutoSize = true;
            ширинаLabel.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            ширинаLabel.Location = new System.Drawing.Point(99, 133);
            ширинаLabel.Name = "ширинаLabel";
            ширинаLabel.Size = new System.Drawing.Size(81, 18);
            ширинаLabel.TabIndex = 13;
            ширинаLabel.Text = "Ширина:";
            // 
            // фурнитураBindingNavigator
            // 
            this.фурнитураBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.фурнитураBindingNavigator.BindingSource = this.фурнитураBindingSource;
            this.фурнитураBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.фурнитураBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.фурнитураBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.фурнитураBindingNavigatorSaveItem});
            this.фурнитураBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.фурнитураBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.фурнитураBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.фурнитураBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.фурнитураBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.фурнитураBindingNavigator.Name = "фурнитураBindingNavigator";
            this.фурнитураBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.фурнитураBindingNavigator.Size = new System.Drawing.Size(475, 25);
            this.фурнитураBindingNavigator.TabIndex = 0;
            this.фурнитураBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
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
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // фурнитураBindingNavigatorSaveItem
            // 
            this.фурнитураBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.фурнитураBindingNavigatorSaveItem.Enabled = false;
            this.фурнитураBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("фурнитураBindingNavigatorSaveItem.Image")));
            this.фурнитураBindingNavigatorSaveItem.Name = "фурнитураBindingNavigatorSaveItem";
            this.фурнитураBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.фурнитураBindingNavigatorSaveItem.Text = "Сохранить данные";
            // 
            // артикулTextBox
            // 
            this.артикулTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.фурнитураBindingSource, "Артикул", true));
            this.артикулTextBox.Location = new System.Drawing.Point(253, 49);
            this.артикулTextBox.Name = "артикулTextBox";
            this.артикулTextBox.Size = new System.Drawing.Size(100, 20);
            this.артикулTextBox.TabIndex = 2;
            // 
            // весTextBox
            // 
            this.весTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.фурнитураBindingSource, "Вес", true));
            this.весTextBox.Location = new System.Drawing.Point(253, 161);
            this.весTextBox.Name = "весTextBox";
            this.весTextBox.Size = new System.Drawing.Size(100, 20);
            this.весTextBox.TabIndex = 4;
            // 
            // длинаTextBox
            // 
            this.длинаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.фурнитураBindingSource, "Длина", true));
            this.длинаTextBox.Location = new System.Drawing.Point(253, 106);
            this.длинаTextBox.Name = "длинаTextBox";
            this.длинаTextBox.Size = new System.Drawing.Size(100, 20);
            this.длинаTextBox.TabIndex = 6;
            // 
            // наименованиеTextBox
            // 
            this.наименованиеTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.фурнитураBindingSource, "Наименование", true));
            this.наименованиеTextBox.Location = new System.Drawing.Point(254, 78);
            this.наименованиеTextBox.Name = "наименованиеTextBox";
            this.наименованиеTextBox.Size = new System.Drawing.Size(100, 20);
            this.наименованиеTextBox.TabIndex = 8;
            // 
            // типTextBox
            // 
            this.типTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.фурнитураBindingSource, "Тип", true));
            this.типTextBox.Location = new System.Drawing.Point(253, 189);
            this.типTextBox.Name = "типTextBox";
            this.типTextBox.Size = new System.Drawing.Size(100, 20);
            this.типTextBox.TabIndex = 10;
            // 
            // ценаTextBox
            // 
            this.ценаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.фурнитураBindingSource, "Цена", true));
            this.ценаTextBox.Location = new System.Drawing.Point(253, 217);
            this.ценаTextBox.Name = "ценаTextBox";
            this.ценаTextBox.Size = new System.Drawing.Size(100, 20);
            this.ценаTextBox.TabIndex = 12;
            // 
            // ширинаTextBox
            // 
            this.ширинаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.фурнитураBindingSource, "Ширина", true));
            this.ширинаTextBox.Location = new System.Drawing.Point(253, 133);
            this.ширинаTextBox.Name = "ширинаTextBox";
            this.ширинаTextBox.Size = new System.Drawing.Size(100, 20);
            this.ширинаTextBox.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(172, 265);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(388, 322);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "Выйти";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // AddChangeListFurnitura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(475, 357);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(артикулLabel);
            this.Controls.Add(this.артикулTextBox);
            this.Controls.Add(весLabel);
            this.Controls.Add(this.весTextBox);
            this.Controls.Add(длинаLabel);
            this.Controls.Add(this.длинаTextBox);
            this.Controls.Add(наименованиеLabel);
            this.Controls.Add(this.наименованиеTextBox);
            this.Controls.Add(типLabel);
            this.Controls.Add(this.типTextBox);
            this.Controls.Add(ценаLabel);
            this.Controls.Add(this.ценаTextBox);
            this.Controls.Add(ширинаLabel);
            this.Controls.Add(this.ширинаTextBox);
            this.Controls.Add(this.фурнитураBindingNavigator);
            this.Name = "AddChangeListFurnitura";
            this.Text = "AddChangeListFurnitura";
            this.Load += new System.EventHandler(this.AddChangeListFurnitura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.фурнитураBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.фурнитураBindingNavigator)).EndInit();
            this.фурнитураBindingNavigator.ResumeLayout(false);
            this.фурнитураBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource фурнитураBindingSource;
        private System.Windows.Forms.BindingNavigator фурнитураBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton фурнитураBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox артикулTextBox;
        private System.Windows.Forms.TextBox весTextBox;
        private System.Windows.Forms.TextBox длинаTextBox;
        private System.Windows.Forms.TextBox наименованиеTextBox;
        private System.Windows.Forms.TextBox типTextBox;
        private System.Windows.Forms.TextBox ценаTextBox;
        private System.Windows.Forms.TextBox ширинаTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}