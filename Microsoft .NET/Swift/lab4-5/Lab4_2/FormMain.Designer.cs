namespace Lab4_2
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveJSONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveBinaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadJSONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadBinaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.add = new System.Windows.Forms.ToolStripMenuItem();
            this.edit = new System.Windows.Forms.ToolStripMenuItem();
            this.carsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.rentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageClients = new System.Windows.Forms.TabPage();
            this.listViewClients = new System.Windows.Forms.ListView();
            this.columnHeaderFIO = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPageCars = new System.Windows.Forms.TabPage();
            this.listViewCars = new System.Windows.Forms.ListView();
            this.columnHeaderNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPageRentedCars = new System.Windows.Forms.TabPage();
            this.saveFileDialogMain = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialogMain = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.tabPageClients.SuspendLayout();
            this.tabPageCars.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.ClientsToolStripMenuItem,
            this.carsToolStripMenuItem,
            this.rentToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(543, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.toolStripSeparator1,
            this.ExitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.fileToolStripMenuItem.Text = "Файл";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveXMLToolStripMenuItem,
            this.saveJSONToolStripMenuItem,
            this.saveBinaryToolStripMenuItem});
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.saveToolStripMenuItem.Text = "Сохранить ";
            // 
            // saveXMLToolStripMenuItem
            // 
            this.saveXMLToolStripMenuItem.Name = "saveXMLToolStripMenuItem";
            this.saveXMLToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.saveXMLToolStripMenuItem.Text = "XML";
            this.saveXMLToolStripMenuItem.Click += new System.EventHandler(this.saveXMLToolStripMenuItem_Click);
            // 
            // saveJSONToolStripMenuItem
            // 
            this.saveJSONToolStripMenuItem.Name = "saveJSONToolStripMenuItem";
            this.saveJSONToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.saveJSONToolStripMenuItem.Text = "JSON";
            this.saveJSONToolStripMenuItem.Click += new System.EventHandler(this.saveJSONToolStripMenuItem_Click);
            // 
            // saveBinaryToolStripMenuItem
            // 
            this.saveBinaryToolStripMenuItem.Name = "saveBinaryToolStripMenuItem";
            this.saveBinaryToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.saveBinaryToolStripMenuItem.Text = "Двоичный";
            this.saveBinaryToolStripMenuItem.Click += new System.EventHandler(this.saveBinaryToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadXMLToolStripMenuItem,
            this.loadJSONToolStripMenuItem,
            this.loadBinaryToolStripMenuItem});
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.loadToolStripMenuItem.Text = "Загрузить";
            // 
            // loadXMLToolStripMenuItem
            // 
            this.loadXMLToolStripMenuItem.Name = "loadXMLToolStripMenuItem";
            this.loadXMLToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.loadXMLToolStripMenuItem.Text = "XML";
            this.loadXMLToolStripMenuItem.Click += new System.EventHandler(this.loadXMLToolStripMenuItem_Click);
            // 
            // loadJSONToolStripMenuItem
            // 
            this.loadJSONToolStripMenuItem.Name = "loadJSONToolStripMenuItem";
            this.loadJSONToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.loadJSONToolStripMenuItem.Text = "JSON";
            this.loadJSONToolStripMenuItem.Click += new System.EventHandler(this.loadJSONToolStripMenuItem_Click);
            // 
            // loadBinaryToolStripMenuItem
            // 
            this.loadBinaryToolStripMenuItem.Name = "loadBinaryToolStripMenuItem";
            this.loadBinaryToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.loadBinaryToolStripMenuItem.Text = "Доичный";
            this.loadBinaryToolStripMenuItem.Click += new System.EventHandler(this.loadBinaryToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(133, 6);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.ExitToolStripMenuItem.Text = "Выход";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // ClientsToolStripMenuItem
            // 
            this.ClientsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.add,
            this.edit});
            this.ClientsToolStripMenuItem.Name = "ClientsToolStripMenuItem";
            this.ClientsToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.ClientsToolStripMenuItem.Text = "Клиенты";
            // 
            // add
            // 
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(154, 22);
            this.add.Text = "Добавить";
            this.add.Click += new System.EventHandler(this.addClientToolStripMenuItem_Click);
            // 
            // edit
            // 
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(154, 22);
            this.edit.Text = "Редактировать";
            this.edit.Click += new System.EventHandler(this.editClientToolStripMenuItem_Click);
            // 
            // carsToolStripMenuItem
            // 
            this.carsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem1,
            this.editToolStripMenuItem1});
            this.carsToolStripMenuItem.Name = "carsToolStripMenuItem";
            this.carsToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.carsToolStripMenuItem.Text = "Автомобили";
            // 
            // addToolStripMenuItem1
            // 
            this.addToolStripMenuItem1.Name = "addToolStripMenuItem1";
            this.addToolStripMenuItem1.Size = new System.Drawing.Size(154, 22);
            this.addToolStripMenuItem1.Text = "Добавить";
            this.addToolStripMenuItem1.Click += new System.EventHandler(this.addCarToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem1
            // 
            this.editToolStripMenuItem1.Name = "editToolStripMenuItem1";
            this.editToolStripMenuItem1.Size = new System.Drawing.Size(154, 22);
            this.editToolStripMenuItem1.Text = "Редактировать";
            this.editToolStripMenuItem1.Click += new System.EventHandler(this.editCarToolStripMenuItem_Click);
            // 
            // rentToolStripMenuItem
            // 
            this.rentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem2,
            this.editToolStripMenuItem2});
            this.rentToolStripMenuItem.Name = "rentToolStripMenuItem";
            this.rentToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.rentToolStripMenuItem.Text = "Прокат";
            // 
            // addToolStripMenuItem2
            // 
            this.addToolStripMenuItem2.Name = "addToolStripMenuItem2";
            this.addToolStripMenuItem2.Size = new System.Drawing.Size(154, 22);
            this.addToolStripMenuItem2.Text = "Добавить";
            this.addToolStripMenuItem2.Click += new System.EventHandler(this.addRentToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem2
            // 
            this.editToolStripMenuItem2.Name = "editToolStripMenuItem2";
            this.editToolStripMenuItem2.Size = new System.Drawing.Size(154, 22);
            this.editToolStripMenuItem2.Text = "Редактировать";
            this.editToolStripMenuItem2.Click += new System.EventHandler(this.editRentedCarToolStripMenuItem_Click);
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageClients);
            this.tabControlMain.Controls.Add(this.tabPageCars);
            this.tabControlMain.Controls.Add(this.tabPageRentedCars);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(0, 24);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(543, 303);
            this.tabControlMain.TabIndex = 1;
            // 
            // tabPageClients
            // 
            this.tabPageClients.Controls.Add(this.listViewClients);
            this.tabPageClients.Location = new System.Drawing.Point(4, 22);
            this.tabPageClients.Name = "tabPageClients";
            this.tabPageClients.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageClients.Size = new System.Drawing.Size(535, 277);
            this.tabPageClients.TabIndex = 0;
            this.tabPageClients.Text = "Клиенты";
            this.tabPageClients.UseVisualStyleBackColor = true;
            // 
            // listViewClients
            // 
            this.listViewClients.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderFIO,
            this.columnHeader1,
            this.columnHeader2});
            this.listViewClients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewClients.FullRowSelect = true;
            this.listViewClients.GridLines = true;
            this.listViewClients.HideSelection = false;
            this.listViewClients.Location = new System.Drawing.Point(3, 3);
            this.listViewClients.Name = "listViewClients";
            this.listViewClients.Size = new System.Drawing.Size(529, 271);
            this.listViewClients.TabIndex = 0;
            this.listViewClients.UseCompatibleStateImageBehavior = false;
            this.listViewClients.View = System.Windows.Forms.View.Details;
            this.listViewClients.SelectedIndexChanged += new System.EventHandler(this.listViewClients_SelectedIndexChanged);
            this.listViewClients.KeyUp += new System.Windows.Forms.KeyEventHandler(this.listViewClients_KeyUp);
            // 
            // columnHeaderFIO
            // 
            this.columnHeaderFIO.Text = "ФИО клиента";
            this.columnHeaderFIO.Width = 97;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Адрес";
            this.columnHeader1.Width = 149;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Номер телефона";
            this.columnHeader2.Width = 234;
            // 
            // tabPageCars
            // 
            this.tabPageCars.Controls.Add(this.listViewCars);
            this.tabPageCars.Location = new System.Drawing.Point(4, 22);
            this.tabPageCars.Name = "tabPageCars";
            this.tabPageCars.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCars.Size = new System.Drawing.Size(535, 277);
            this.tabPageCars.TabIndex = 1;
            this.tabPageCars.Text = "Автомобили";
            this.tabPageCars.UseVisualStyleBackColor = true;
            // 
            // listViewCars
            // 
            this.listViewCars.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderNumber,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listViewCars.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewCars.FullRowSelect = true;
            this.listViewCars.GridLines = true;
            this.listViewCars.HideSelection = false;
            this.listViewCars.Location = new System.Drawing.Point(3, 3);
            this.listViewCars.Name = "listViewCars";
            this.listViewCars.Size = new System.Drawing.Size(529, 271);
            this.listViewCars.TabIndex = 1;
            this.listViewCars.UseCompatibleStateImageBehavior = false;
            this.listViewCars.View = System.Windows.Forms.View.Details;
            this.listViewCars.KeyUp += new System.Windows.Forms.KeyEventHandler(this.listViewCars_KeyUp);
            // 
            // columnHeaderNumber
            // 
            this.columnHeaderNumber.Text = "Номер";
            this.columnHeaderNumber.Width = 460;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Марка";
            this.columnHeader3.Width = 92;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Стоимость";
            this.columnHeader4.Width = 110;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Стоимость аренды";
            this.columnHeader5.Width = 143;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Тип";
            this.columnHeader6.Width = 107;
            // 
            // tabPageRentedCars
            // 
            this.tabPageRentedCars.Location = new System.Drawing.Point(4, 22);
            this.tabPageRentedCars.Name = "tabPageRentedCars";
            this.tabPageRentedCars.Size = new System.Drawing.Size(535, 277);
            this.tabPageRentedCars.TabIndex = 2;
            this.tabPageRentedCars.Text = "Прокат";
            this.tabPageRentedCars.UseVisualStyleBackColor = true;
            // 
            // openFileDialogMain
            // 
            this.openFileDialogMain.FileName = "hotel";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 327);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "Аренда автомобилей";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControlMain.ResumeLayout(false);
            this.tabPageClients.ResumeLayout(false);
            this.tabPageCars.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ClientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem add;
        private System.Windows.Forms.ToolStripMenuItem edit;
        private System.Windows.Forms.ToolStripMenuItem carsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem1;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageClients;
        private System.Windows.Forms.ListView listViewClients;
        private System.Windows.Forms.ColumnHeader columnHeaderFIO;
        private System.Windows.Forms.TabPage tabPageCars;
        private System.Windows.Forms.ListView listViewCars;
        private System.Windows.Forms.ColumnHeader columnHeaderNumber;
        private System.Windows.Forms.TabPage tabPageRentedCars;
        private System.Windows.Forms.ToolStripMenuItem rentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveXMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveJSONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveBinaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadXMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadJSONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadBinaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.SaveFileDialog saveFileDialogMain;
        private System.Windows.Forms.OpenFileDialog openFileDialogMain;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }

 
   // private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
   // private System.Windows.Forms.OpenFileDialog openFileDialogMain;
   // private System.Windows.Forms.SaveFileDialog saveFileDialogMain;
}

