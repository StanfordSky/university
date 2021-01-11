namespace lab12
{
    partial class FormFilm
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
            System.Windows.Forms.Label titleLabel;
            System.Windows.Forms.Label producerLabel;
            System.Windows.Forms.Label coverLabel;
            System.Windows.Forms.Label yearLabel1;
            this.panel1 = new System.Windows.Forms.Panel();
            this.yearNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.filmBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBdotNetDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_dotNetDataSet = new lab12.DB_dotNetDataSet();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.producerComboBox = new System.Windows.Forms.ComboBox();
            this.coverPictureBox = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemLoad = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSave = new System.Windows.Forms.ToolStripMenuItem();
            this.producerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.producerTableAdapter = new lab12.DB_dotNetDataSetTableAdapters.ProducerTableAdapter();
            this.filmTableAdapter = new lab12.DB_dotNetDataSetTableAdapters.FilmTableAdapter();
            this.tableAdapterManager = new lab12.DB_dotNetDataSetTableAdapters.TableAdapterManager();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            titleLabel = new System.Windows.Forms.Label();
            producerLabel = new System.Windows.Forms.Label();
            coverLabel = new System.Windows.Forms.Label();
            yearLabel1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yearNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBdotNetDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_dotNetDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coverPictureBox)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.producerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new System.Drawing.Point(9, 6);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(30, 13);
            titleLabel.TabIndex = 7;
            titleLabel.Text = "Title:";
            // 
            // producerLabel
            // 
            producerLabel.AutoSize = true;
            producerLabel.Location = new System.Drawing.Point(9, 32);
            producerLabel.Name = "producerLabel";
            producerLabel.Size = new System.Drawing.Size(52, 13);
            producerLabel.TabIndex = 2;
            producerLabel.Text = "producer:";
            // 
            // coverLabel
            // 
            coverLabel.AutoSize = true;
            coverLabel.Location = new System.Drawing.Point(9, 82);
            coverLabel.Name = "coverLabel";
            coverLabel.Size = new System.Drawing.Size(37, 13);
            coverLabel.TabIndex = 4;
            coverLabel.Text = "cover:";
            // 
            // yearLabel1
            // 
            yearLabel1.AutoSize = true;
            yearLabel1.Location = new System.Drawing.Point(9, 56);
            yearLabel1.Name = "yearLabel1";
            yearLabel1.Size = new System.Drawing.Size(30, 13);
            yearLabel1.TabIndex = 10;
            yearLabel1.Text = "year:";
            yearLabel1.Click += new System.EventHandler(this.yearLabel1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(yearLabel1);
            this.panel1.Controls.Add(this.yearNumericUpDown);
            this.panel1.Controls.Add(this.buttonOpen);
            this.panel1.Controls.Add(this.buttonSave);
            this.panel1.Controls.Add(this.titleTextBox);
            this.panel1.Controls.Add(titleLabel);
            this.panel1.Controls.Add(this.producerComboBox);
            this.panel1.Controls.Add(producerLabel);
            this.panel1.Controls.Add(this.coverPictureBox);
            this.panel1.Controls.Add(coverLabel);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(297, 273);
            this.panel1.TabIndex = 10;
            // 
            // yearNumericUpDown
            // 
            this.yearNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.filmBindingSource, "year", true));
            this.yearNumericUpDown.Location = new System.Drawing.Point(70, 56);
            this.yearNumericUpDown.Maximum = new decimal(new int[] {
            2020,
            0,
            0,
            0});
            this.yearNumericUpDown.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.yearNumericUpDown.Name = "yearNumericUpDown";
            this.yearNumericUpDown.Size = new System.Drawing.Size(121, 20);
            this.yearNumericUpDown.TabIndex = 11;
            this.yearNumericUpDown.Value = new decimal(new int[] {
            2020,
            0,
            0,
            0});
            this.yearNumericUpDown.ValueChanged += new System.EventHandler(this.yearNumericUpDown_ValueChanged);
            // 
            // filmBindingSource
            // 
            this.filmBindingSource.DataMember = "Film";
            this.filmBindingSource.DataSource = this.dBdotNetDataSetBindingSource;
            // 
            // dBdotNetDataSetBindingSource
            // 
            this.dBdotNetDataSetBindingSource.DataSource = this.dB_dotNetDataSet;
            this.dBdotNetDataSetBindingSource.Position = 0;
            // 
            // dB_dotNetDataSet
            // 
            this.dB_dotNetDataSet.DataSetName = "DB_dotNetDataSet";
            this.dB_dotNetDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buttonOpen
            // 
            this.buttonOpen.Location = new System.Drawing.Point(12, 229);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(75, 23);
            this.buttonOpen.TabIndex = 10;
            this.buttonOpen.Text = "Open";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonSave.Location = new System.Drawing.Point(116, 230);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 9;
            this.buttonSave.Text = "save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // titleTextBox
            // 
            this.titleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.filmBindingSource, "Title", true));
            this.titleTextBox.Location = new System.Drawing.Point(48, 3);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(143, 20);
            this.titleTextBox.TabIndex = 8;
            // 
            // producerComboBox
            // 
            this.producerComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.filmBindingSource, "producer", true));
            this.producerComboBox.FormattingEnabled = true;
            this.producerComboBox.Location = new System.Drawing.Point(70, 29);
            this.producerComboBox.Name = "producerComboBox";
            this.producerComboBox.Size = new System.Drawing.Size(121, 21);
            this.producerComboBox.TabIndex = 3;
            // 
            // coverPictureBox
            // 
            this.coverPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.coverPictureBox.ContextMenuStrip = this.contextMenuStrip1;
            this.coverPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.filmBindingSource, "cover", true));
            this.coverPictureBox.Location = new System.Drawing.Point(52, 82);
            this.coverPictureBox.Name = "coverPictureBox";
            this.coverPictureBox.Size = new System.Drawing.Size(139, 142);
            this.coverPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.coverPictureBox.TabIndex = 5;
            this.coverPictureBox.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemLoad,
            this.toolStripMenuItemSave});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(146, 48);
            // 
            // toolStripMenuItemLoad
            // 
            this.toolStripMenuItemLoad.Name = "toolStripMenuItemLoad";
            this.toolStripMenuItemLoad.Size = new System.Drawing.Size(145, 22);
            this.toolStripMenuItemLoad.Text = "load from file";
            this.toolStripMenuItemLoad.Click += new System.EventHandler(this.toolStripMenuItemLoad_Click);
            // 
            // toolStripMenuItemSave
            // 
            this.toolStripMenuItemSave.Name = "toolStripMenuItemSave";
            this.toolStripMenuItemSave.Size = new System.Drawing.Size(145, 22);
            this.toolStripMenuItemSave.Text = "save to file";
            this.toolStripMenuItemSave.Click += new System.EventHandler(this.toolStripMenuItemSave_Click);
            // 
            // producerBindingSource
            // 
            this.producerBindingSource.DataMember = "Producer";
            this.producerBindingSource.DataSource = this.dBdotNetDataSetBindingSource;
            // 
            // producerTableAdapter
            // 
            this.producerTableAdapter.ClearBeforeFill = true;
            // 
            // filmTableAdapter
            // 
            this.filmTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.FilmTableAdapter = this.filmTableAdapter;
            this.tableAdapterManager.ProducerTableAdapter = this.producerTableAdapter;
            this.tableAdapterManager.UpdateOrder = lab12.DB_dotNetDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // FormFilm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(217, 285);
            this.Controls.Add(this.panel1);
            this.Name = "FormFilm";
            this.Text = "FormFilm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yearNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBdotNetDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_dotNetDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coverPictureBox)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.producerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.ComboBox producerComboBox;
        private System.Windows.Forms.PictureBox coverPictureBox;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemLoad;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSave;
        private DB_dotNetDataSet dB_dotNetDataSet;
        private System.Windows.Forms.BindingSource dBdotNetDataSetBindingSource;
        private System.Windows.Forms.BindingSource producerBindingSource;
        private DB_dotNetDataSetTableAdapters.ProducerTableAdapter producerTableAdapter;
        private System.Windows.Forms.BindingSource filmBindingSource;
        private DB_dotNetDataSetTableAdapters.FilmTableAdapter filmTableAdapter;
        private DB_dotNetDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.NumericUpDown yearNumericUpDown;
    }
}