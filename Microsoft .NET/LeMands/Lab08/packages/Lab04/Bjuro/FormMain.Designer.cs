namespace Bjuro
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
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveJSONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveBinaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadJSONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadBinaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.работодателиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItemEmployer = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьToolStripMenuItemEmployer = new System.Windows.Forms.ToolStripMenuItem();
            this.соискателиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItemJobSeeker = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьToolStripMenuJobSeeker = new System.Windows.Forms.ToolStripMenuItem();
            this.сделкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItemDealings = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьToolStripMenuItemDealings = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageEmployers = new System.Windows.Forms.TabPage();
            this.listViewEmployers = new System.Windows.Forms.ListView();
            this.columnHeaderEmployer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPageJobSeekers = new System.Windows.Forms.TabPage();
            this.listViewJobSeekers = new System.Windows.Forms.ListView();
            this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPageDealings = new System.Windows.Forms.TabPage();
            this.saveFileDialogMain = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialogMain = new System.Windows.Forms.OpenFileDialog();
            this.menuStripMain.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.tabPageEmployers.SuspendLayout();
            this.tabPageJobSeekers.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.работодателиToolStripMenuItem,
            this.соискателиToolStripMenuItem,
            this.сделкиToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(800, 24);
            this.menuStripMain.TabIndex = 0;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.toolStripSeparator1,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveXMLToolStripMenuItem,
            this.saveJSONToolStripMenuItem,
            this.saveBinaryToolStripMenuItem});
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.saveToolStripMenuItem.Text = "Сохранить";
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
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.loadToolStripMenuItem.Text = "Загрузить";
            // 
            // loadXMLToolStripMenuItem
            // 
            this.loadXMLToolStripMenuItem.Name = "loadXMLToolStripMenuItem";
            this.loadXMLToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.loadXMLToolStripMenuItem.Text = "XML";
            this.loadXMLToolStripMenuItem.Click += new System.EventHandler(this.loadXMLToolStripMenuItem_Click);
            // 
            // loadJSONToolStripMenuItem
            // 
            this.loadJSONToolStripMenuItem.Name = "loadJSONToolStripMenuItem";
            this.loadJSONToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.loadJSONToolStripMenuItem.Text = "JSON";
            this.loadJSONToolStripMenuItem.Click += new System.EventHandler(this.loadJSONToolStripMenuItem_Click);
            // 
            // loadBinaryToolStripMenuItem
            // 
            this.loadBinaryToolStripMenuItem.Name = "loadBinaryToolStripMenuItem";
            this.loadBinaryToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.loadBinaryToolStripMenuItem.Text = "Двоичный";
            this.loadBinaryToolStripMenuItem.Click += new System.EventHandler(this.loadBinaryToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(130, 6);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // работодателиToolStripMenuItem
            // 
            this.работодателиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItemEmployer,
            this.редактироватьToolStripMenuItemEmployer});
            this.работодателиToolStripMenuItem.Name = "работодателиToolStripMenuItem";
            this.работодателиToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.работодателиToolStripMenuItem.Text = "Работодатели";
            // 
            // добавитьToolStripMenuItemEmployer
            // 
            this.добавитьToolStripMenuItemEmployer.Name = "добавитьToolStripMenuItemEmployer";
            this.добавитьToolStripMenuItemEmployer.Size = new System.Drawing.Size(154, 22);
            this.добавитьToolStripMenuItemEmployer.Text = "Добавить";
            this.добавитьToolStripMenuItemEmployer.Click += new System.EventHandler(this.добавитьToolStripMenuItem_Click);
            // 
            // редактироватьToolStripMenuItemEmployer
            // 
            this.редактироватьToolStripMenuItemEmployer.Name = "редактироватьToolStripMenuItemEmployer";
            this.редактироватьToolStripMenuItemEmployer.Size = new System.Drawing.Size(154, 22);
            this.редактироватьToolStripMenuItemEmployer.Text = "Редактировать";
            this.редактироватьToolStripMenuItemEmployer.Click += new System.EventHandler(this.редактироватьToolStripMenuItem_Click);
            // 
            // соискателиToolStripMenuItem
            // 
            this.соискателиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItemJobSeeker,
            this.редактироватьToolStripMenuJobSeeker});
            this.соискателиToolStripMenuItem.Name = "соискателиToolStripMenuItem";
            this.соискателиToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.соискателиToolStripMenuItem.Text = "Соискатели";
            // 
            // добавитьToolStripMenuItemJobSeeker
            // 
            this.добавитьToolStripMenuItemJobSeeker.Name = "добавитьToolStripMenuItemJobSeeker";
            this.добавитьToolStripMenuItemJobSeeker.Size = new System.Drawing.Size(154, 22);
            this.добавитьToolStripMenuItemJobSeeker.Text = "Добавить";
            this.добавитьToolStripMenuItemJobSeeker.Click += new System.EventHandler(this.добавитьToolStripMenuItem1_Click);
            // 
            // редактироватьToolStripMenuJobSeeker
            // 
            this.редактироватьToolStripMenuJobSeeker.Name = "редактироватьToolStripMenuJobSeeker";
            this.редактироватьToolStripMenuJobSeeker.Size = new System.Drawing.Size(154, 22);
            this.редактироватьToolStripMenuJobSeeker.Text = "Редактировать";
            this.редактироватьToolStripMenuJobSeeker.Click += new System.EventHandler(this.редактироватьToolStripMenuItem1_Click);
            // 
            // сделкиToolStripMenuItem
            // 
            this.сделкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItemDealings,
            this.редактироватьToolStripMenuItemDealings});
            this.сделкиToolStripMenuItem.Name = "сделкиToolStripMenuItem";
            this.сделкиToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.сделкиToolStripMenuItem.Text = "Сделки";
            // 
            // добавитьToolStripMenuItemDealings
            // 
            this.добавитьToolStripMenuItemDealings.Name = "добавитьToolStripMenuItemDealings";
            this.добавитьToolStripMenuItemDealings.Size = new System.Drawing.Size(154, 22);
            this.добавитьToolStripMenuItemDealings.Text = "Добавить";
            this.добавитьToolStripMenuItemDealings.Click += new System.EventHandler(this.добавитьToolStripMenuItemDealings_Click);
            // 
            // редактироватьToolStripMenuItemDealings
            // 
            this.редактироватьToolStripMenuItemDealings.Name = "редактироватьToolStripMenuItemDealings";
            this.редактироватьToolStripMenuItemDealings.Size = new System.Drawing.Size(154, 22);
            this.редактироватьToolStripMenuItemDealings.Text = "Редактировать";
            this.редактироватьToolStripMenuItemDealings.Click += new System.EventHandler(this.редактироватьToolStripMenuItemDealings_Click);
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageEmployers);
            this.tabControlMain.Controls.Add(this.tabPageJobSeekers);
            this.tabControlMain.Controls.Add(this.tabPageDealings);
            this.tabControlMain.Location = new System.Drawing.Point(0, 27);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(800, 423);
            this.tabControlMain.TabIndex = 1;
            // 
            // tabPageEmployers
            // 
            this.tabPageEmployers.Controls.Add(this.listViewEmployers);
            this.tabPageEmployers.Location = new System.Drawing.Point(4, 22);
            this.tabPageEmployers.Name = "tabPageEmployers";
            this.tabPageEmployers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEmployers.Size = new System.Drawing.Size(792, 397);
            this.tabPageEmployers.TabIndex = 0;
            this.tabPageEmployers.Text = "Работодатели";
            this.tabPageEmployers.UseVisualStyleBackColor = true;
            // 
            // listViewEmployers
            // 
            this.listViewEmployers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderEmployer});
            this.listViewEmployers.FullRowSelect = true;
            this.listViewEmployers.GridLines = true;
            this.listViewEmployers.HideSelection = false;
            this.listViewEmployers.Location = new System.Drawing.Point(65, 40);
            this.listViewEmployers.Name = "listViewEmployers";
            this.listViewEmployers.Size = new System.Drawing.Size(662, 318);
            this.listViewEmployers.TabIndex = 0;
            this.listViewEmployers.UseCompatibleStateImageBehavior = false;
            this.listViewEmployers.View = System.Windows.Forms.View.Details;
            this.listViewEmployers.KeyUp += new System.Windows.Forms.KeyEventHandler(this.listViewEmployers_KeyUp);
            // 
            // columnHeaderEmployer
            // 
            this.columnHeaderEmployer.Text = "Название";
            this.columnHeaderEmployer.Width = 103;
            // 
            // tabPageJobSeekers
            // 
            this.tabPageJobSeekers.Controls.Add(this.listViewJobSeekers);
            this.tabPageJobSeekers.Location = new System.Drawing.Point(4, 22);
            this.tabPageJobSeekers.Name = "tabPageJobSeekers";
            this.tabPageJobSeekers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageJobSeekers.Size = new System.Drawing.Size(792, 397);
            this.tabPageJobSeekers.TabIndex = 1;
            this.tabPageJobSeekers.Text = "Соискатели";
            this.tabPageJobSeekers.UseVisualStyleBackColor = true;
            // 
            // listViewJobSeekers
            // 
            this.listViewJobSeekers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderName});
            this.listViewJobSeekers.FullRowSelect = true;
            this.listViewJobSeekers.GridLines = true;
            this.listViewJobSeekers.HideSelection = false;
            this.listViewJobSeekers.Location = new System.Drawing.Point(55, 39);
            this.listViewJobSeekers.Name = "listViewJobSeekers";
            this.listViewJobSeekers.Size = new System.Drawing.Size(684, 307);
            this.listViewJobSeekers.TabIndex = 0;
            this.listViewJobSeekers.UseCompatibleStateImageBehavior = false;
            this.listViewJobSeekers.View = System.Windows.Forms.View.Details;
            this.listViewJobSeekers.KeyUp += new System.Windows.Forms.KeyEventHandler(this.listViewJobSeekers_KeyUp);
            // 
            // columnHeaderName
            // 
            this.columnHeaderName.Text = "Имя";
            this.columnHeaderName.Width = 120;
            // 
            // tabPageDealings
            // 
            this.tabPageDealings.Location = new System.Drawing.Point(4, 22);
            this.tabPageDealings.Name = "tabPageDealings";
            this.tabPageDealings.Size = new System.Drawing.Size(792, 397);
            this.tabPageDealings.TabIndex = 2;
            this.tabPageDealings.Text = "Сделки";
            this.tabPageDealings.UseVisualStyleBackColor = true;
            // 
            // openFileDialogMain
            // 
            this.openFileDialogMain.FileName = "employmentAgency";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.menuStripMain);
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "FormMain";
            this.Text = "Бюро по трудоустройству";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.listViewEmployers_KeyUp);
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.tabControlMain.ResumeLayout(false);
            this.tabPageEmployers.ResumeLayout(false);
            this.tabPageJobSeekers.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem работодателиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItemEmployer;
        private System.Windows.Forms.ToolStripMenuItem редактироватьToolStripMenuItemEmployer;
        private System.Windows.Forms.ToolStripMenuItem соискателиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItemJobSeeker;
        private System.Windows.Forms.ToolStripMenuItem редактироватьToolStripMenuJobSeeker;
        private System.Windows.Forms.ToolStripMenuItem сделкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItemDealings;
        private System.Windows.Forms.ToolStripMenuItem редактироватьToolStripMenuItemDealings;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageEmployers;
        private System.Windows.Forms.TabPage tabPageJobSeekers;
        private System.Windows.Forms.TabPage tabPageDealings;
        private System.Windows.Forms.ListView listViewEmployers;
        private System.Windows.Forms.ListView listViewJobSeekers;
        private System.Windows.Forms.ColumnHeader columnHeaderEmployer;
        private System.Windows.Forms.ColumnHeader columnHeaderName;
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
    }
}

