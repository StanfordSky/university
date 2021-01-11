namespace Lab11
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageFilms = new System.Windows.Forms.TabPage();
            this.pictureBoxCover = new System.Windows.Forms.PictureBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonLoad = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonUpdate = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDelete = new System.Windows.Forms.ToolStripButton();
            this.listViewFilms = new System.Windows.Forms.ListView();
            this.columnHeaderFilmID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderProdusser = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderYear = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPageProducers = new System.Windows.Forms.TabPage();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonLoadProducer = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonAddProducer = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonUpdateProducer = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDeleteProducer = new System.Windows.Forms.ToolStripButton();
            this.listViewProducers = new System.Windows.Forms.ListView();
            this.columnHeaderID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderFirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderSecondName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControlMain.SuspendLayout();
            this.tabPageFilms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCover)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.tabPageProducers.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageFilms);
            this.tabControlMain.Controls.Add(this.tabPageProducers);
            this.tabControlMain.Location = new System.Drawing.Point(12, 12);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(693, 274);
            this.tabControlMain.TabIndex = 0;
            // 
            // tabPageFilms
            // 
            this.tabPageFilms.Controls.Add(this.pictureBoxCover);
            this.tabPageFilms.Controls.Add(this.toolStrip1);
            this.tabPageFilms.Controls.Add(this.listViewFilms);
            this.tabPageFilms.Location = new System.Drawing.Point(4, 22);
            this.tabPageFilms.Name = "tabPageFilms";
            this.tabPageFilms.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFilms.Size = new System.Drawing.Size(685, 248);
            this.tabPageFilms.TabIndex = 0;
            this.tabPageFilms.Text = "Фильмы";
            this.tabPageFilms.UseVisualStyleBackColor = true;
            // 
            // pictureBoxCover
            // 
            this.pictureBoxCover.Location = new System.Drawing.Point(530, 32);
            this.pictureBoxCover.Name = "pictureBoxCover";
            this.pictureBoxCover.Size = new System.Drawing.Size(149, 153);
            this.pictureBoxCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCover.TabIndex = 2;
            this.pictureBoxCover.TabStop = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonLoad,
            this.toolStripButtonAdd,
            this.toolStripButtonUpdate,
            this.toolStripButtonDelete});
            this.toolStrip1.Location = new System.Drawing.Point(3, 3);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(679, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStripFilms";
            // 
            // toolStripButtonLoad
            // 
            this.toolStripButtonLoad.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonLoad.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonLoad.Image")));
            this.toolStripButtonLoad.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonLoad.Name = "toolStripButtonLoad";
            this.toolStripButtonLoad.Size = new System.Drawing.Size(65, 22);
            this.toolStripButtonLoad.Text = "Загрузить";
            this.toolStripButtonLoad.Click += new System.EventHandler(this.toolStripButtonLoad_Click);
            // 
            // toolStripButtonAdd
            // 
            this.toolStripButtonAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonAdd.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAdd.Image")));
            this.toolStripButtonAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAdd.Name = "toolStripButtonAdd";
            this.toolStripButtonAdd.Size = new System.Drawing.Size(63, 22);
            this.toolStripButtonAdd.Text = "Добавить";
            this.toolStripButtonAdd.Click += new System.EventHandler(this.toolStripButtonAdd_Click);
            // 
            // toolStripButtonUpdate
            // 
            this.toolStripButtonUpdate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonUpdate.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonUpdate.Image")));
            this.toolStripButtonUpdate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonUpdate.Name = "toolStripButtonUpdate";
            this.toolStripButtonUpdate.Size = new System.Drawing.Size(65, 22);
            this.toolStripButtonUpdate.Text = "Обновить";
            this.toolStripButtonUpdate.Click += new System.EventHandler(this.toolStripButtonUpdate_Click);
            // 
            // toolStripButtonDelete
            // 
            this.toolStripButtonDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonDelete.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonDelete.Image")));
            this.toolStripButtonDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDelete.Name = "toolStripButtonDelete";
            this.toolStripButtonDelete.Size = new System.Drawing.Size(55, 22);
            this.toolStripButtonDelete.Text = "Удалить";
            this.toolStripButtonDelete.Click += new System.EventHandler(this.toolStripButtonDelete_Click);
            // 
            // listViewFilms
            // 
            this.listViewFilms.AutoArrange = false;
            this.listViewFilms.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderFilmID,
            this.columnHeaderTitle,
            this.columnHeaderProdusser,
            this.columnHeaderYear});
            this.listViewFilms.FullRowSelect = true;
            this.listViewFilms.GridLines = true;
            this.listViewFilms.HideSelection = false;
            this.listViewFilms.Location = new System.Drawing.Point(0, 26);
            this.listViewFilms.Name = "listViewFilms";
            this.listViewFilms.Size = new System.Drawing.Size(523, 219);
            this.listViewFilms.TabIndex = 0;
            this.listViewFilms.UseCompatibleStateImageBehavior = false;
            this.listViewFilms.View = System.Windows.Forms.View.Details;
            this.listViewFilms.SelectedIndexChanged += new System.EventHandler(this.listViewFilms_SelectedIndexChanged);
            // 
            // columnHeaderFilmID
            // 
            this.columnHeaderFilmID.DisplayIndex = 3;
            this.columnHeaderFilmID.Text = "ID";
            this.columnHeaderFilmID.Width = 91;
            // 
            // columnHeaderTitle
            // 
            this.columnHeaderTitle.DisplayIndex = 0;
            this.columnHeaderTitle.Text = "Название";
            this.columnHeaderTitle.Width = 174;
            // 
            // columnHeaderProdusser
            // 
            this.columnHeaderProdusser.DisplayIndex = 1;
            this.columnHeaderProdusser.Text = "Режисер";
            this.columnHeaderProdusser.Width = 126;
            // 
            // columnHeaderYear
            // 
            this.columnHeaderYear.DisplayIndex = 2;
            this.columnHeaderYear.Text = "Год выхода";
            this.columnHeaderYear.Width = 134;
            // 
            // tabPageProducers
            // 
            this.tabPageProducers.Controls.Add(this.toolStrip2);
            this.tabPageProducers.Controls.Add(this.listViewProducers);
            this.tabPageProducers.Location = new System.Drawing.Point(4, 22);
            this.tabPageProducers.Name = "tabPageProducers";
            this.tabPageProducers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProducers.Size = new System.Drawing.Size(685, 248);
            this.tabPageProducers.TabIndex = 1;
            this.tabPageProducers.Text = "Режисеры";
            this.tabPageProducers.UseVisualStyleBackColor = true;
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonLoadProducer,
            this.toolStripButtonAddProducer,
            this.toolStripButtonUpdateProducer,
            this.toolStripButtonDeleteProducer});
            this.toolStrip2.Location = new System.Drawing.Point(3, 3);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(679, 25);
            this.toolStrip2.TabIndex = 2;
            this.toolStrip2.Text = "toolStripProducers";
            // 
            // toolStripButtonLoadProducer
            // 
            this.toolStripButtonLoadProducer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonLoadProducer.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonLoadProducer.Image")));
            this.toolStripButtonLoadProducer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonLoadProducer.Name = "toolStripButtonLoadProducer";
            this.toolStripButtonLoadProducer.Size = new System.Drawing.Size(65, 22);
            this.toolStripButtonLoadProducer.Text = "Загрузить";
            this.toolStripButtonLoadProducer.Click += new System.EventHandler(this.toolStripButtonLoadProducer_Click);
            // 
            // toolStripButtonAddProducer
            // 
            this.toolStripButtonAddProducer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonAddProducer.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAddProducer.Image")));
            this.toolStripButtonAddProducer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAddProducer.Name = "toolStripButtonAddProducer";
            this.toolStripButtonAddProducer.Size = new System.Drawing.Size(63, 22);
            this.toolStripButtonAddProducer.Text = "Добавить";
            this.toolStripButtonAddProducer.Click += new System.EventHandler(this.toolStripButtonAddProducer_Click);
            // 
            // toolStripButtonUpdateProducer
            // 
            this.toolStripButtonUpdateProducer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonUpdateProducer.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonUpdateProducer.Image")));
            this.toolStripButtonUpdateProducer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonUpdateProducer.Name = "toolStripButtonUpdateProducer";
            this.toolStripButtonUpdateProducer.Size = new System.Drawing.Size(65, 22);
            this.toolStripButtonUpdateProducer.Text = "Обновить";
            this.toolStripButtonUpdateProducer.Click += new System.EventHandler(this.toolStripButtonUpdateProducer_Click);
            // 
            // toolStripButtonDeleteProducer
            // 
            this.toolStripButtonDeleteProducer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonDeleteProducer.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonDeleteProducer.Image")));
            this.toolStripButtonDeleteProducer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDeleteProducer.Name = "toolStripButtonDeleteProducer";
            this.toolStripButtonDeleteProducer.Size = new System.Drawing.Size(55, 22);
            this.toolStripButtonDeleteProducer.Text = "Удалить";
            this.toolStripButtonDeleteProducer.Click += new System.EventHandler(this.toolStripButtonDeleteProducer_Click);
            // 
            // listViewProducers
            // 
            this.listViewProducers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderID,
            this.columnHeaderFirstName,
            this.columnHeaderSecondName});
            this.listViewProducers.FullRowSelect = true;
            this.listViewProducers.GridLines = true;
            this.listViewProducers.HideSelection = false;
            this.listViewProducers.Location = new System.Drawing.Point(12, 40);
            this.listViewProducers.Name = "listViewProducers";
            this.listViewProducers.Size = new System.Drawing.Size(673, 202);
            this.listViewProducers.TabIndex = 1;
            this.listViewProducers.UseCompatibleStateImageBehavior = false;
            this.listViewProducers.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderID
            // 
            this.columnHeaderID.DisplayIndex = 2;
            this.columnHeaderID.Text = "ID";
            // 
            // columnHeaderFirstName
            // 
            this.columnHeaderFirstName.DisplayIndex = 0;
            this.columnHeaderFirstName.Text = "Имя";
            this.columnHeaderFirstName.Width = 134;
            // 
            // columnHeaderSecondName
            // 
            this.columnHeaderSecondName.DisplayIndex = 1;
            this.columnHeaderSecondName.Text = "Фамилия";
            this.columnHeaderSecondName.Width = 127;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 297);
            this.Controls.Add(this.tabControlMain);
            this.Name = "FormMain";
            this.Text = "Фильмотека";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.tabControlMain.ResumeLayout(false);
            this.tabPageFilms.ResumeLayout(false);
            this.tabPageFilms.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCover)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabPageProducers.ResumeLayout(false);
            this.tabPageProducers.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabPageFilms;
        private System.Windows.Forms.ColumnHeader columnHeaderTitle;
        private System.Windows.Forms.ColumnHeader columnHeaderProdusser;
        private System.Windows.Forms.ColumnHeader columnHeaderYear;
        private System.Windows.Forms.TabPage tabPageProducers;
        private System.Windows.Forms.ColumnHeader columnHeaderFirstName;
        private System.Windows.Forms.ColumnHeader columnHeaderSecondName;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonLoad;
        private System.Windows.Forms.ToolStripButton toolStripButtonAdd;
        private System.Windows.Forms.ToolStripButton toolStripButtonDelete;
        private System.Windows.Forms.ToolStripButton toolStripButtonUpdate;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton toolStripButtonLoadProducer;
        private System.Windows.Forms.ToolStripButton toolStripButtonAddProducer;
        private System.Windows.Forms.ToolStripButton toolStripButtonUpdateProducer;
        private System.Windows.Forms.ToolStripButton toolStripButtonDeleteProducer;
        private System.Windows.Forms.ColumnHeader columnHeaderID;
        private System.Windows.Forms.ColumnHeader columnHeaderFilmID;
        internal System.Windows.Forms.TabControl tabControlMain;
        internal System.Windows.Forms.ListView listViewFilms;
        public System.Windows.Forms.ListView listViewProducers;
        private System.Windows.Forms.PictureBox pictureBoxCover;
    }
}

