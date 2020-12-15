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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.listViewDealings = new System.Windows.Forms.ListView();
            this.columnHeaderEmployerName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderJobSeekerName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderCommission = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.tabPageEmployers.SuspendLayout();
            this.tabPageJobSeekers.SuspendLayout();
            this.tabPageDealings.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.работодателиToolStripMenuItem,
            this.соискателиToolStripMenuItem,
            this.сделкиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
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
            // 
            // columnHeaderName
            // 
            this.columnHeaderName.Text = "Имя";
            this.columnHeaderName.Width = 120;
            // 
            // tabPageDealings
            // 
            this.tabPageDealings.Controls.Add(this.listViewDealings);
            this.tabPageDealings.Location = new System.Drawing.Point(4, 22);
            this.tabPageDealings.Name = "tabPageDealings";
            this.tabPageDealings.Size = new System.Drawing.Size(792, 397);
            this.tabPageDealings.TabIndex = 2;
            this.tabPageDealings.Text = "Сделки";
            this.tabPageDealings.UseVisualStyleBackColor = true;
            // 
            // listViewDealings
            // 
            this.listViewDealings.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderEmployerName,
            this.columnHeaderJobSeekerName,
            this.columnHeaderPost,
            this.columnHeaderCommission});
            this.listViewDealings.HideSelection = false;
            this.listViewDealings.Location = new System.Drawing.Point(51, 47);
            this.listViewDealings.Name = "listViewDealings";
            this.listViewDealings.Size = new System.Drawing.Size(685, 301);
            this.listViewDealings.TabIndex = 0;
            this.listViewDealings.UseCompatibleStateImageBehavior = false;
            this.listViewDealings.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderEmployerName
            // 
            this.columnHeaderEmployerName.Text = "Работодатель";
            // 
            // columnHeaderJobSeekerName
            // 
            this.columnHeaderJobSeekerName.Text = "Соискатель";
            // 
            // columnHeaderPost
            // 
            this.columnHeaderPost.Text = "Должность";
            // 
            // columnHeaderCommission
            // 
            this.columnHeaderCommission.Text = "Комиссионные";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "Бюро по трудоустройству";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControlMain.ResumeLayout(false);
            this.tabPageEmployers.ResumeLayout(false);
            this.tabPageJobSeekers.ResumeLayout(false);
            this.tabPageDealings.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
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
        private System.Windows.Forms.ListView listViewDealings;
        private System.Windows.Forms.ColumnHeader columnHeaderEmployer;
        private System.Windows.Forms.ColumnHeader columnHeaderName;
        private System.Windows.Forms.ColumnHeader columnHeaderEmployerName;
        private System.Windows.Forms.ColumnHeader columnHeaderJobSeekerName;
        private System.Windows.Forms.ColumnHeader columnHeaderPost;
        private System.Windows.Forms.ColumnHeader columnHeaderCommission;
    }
}

