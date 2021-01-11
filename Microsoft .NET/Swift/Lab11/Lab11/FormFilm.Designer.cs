namespace Lab11
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.comboBoxProducer = new System.Windows.Forms.ComboBox();
            this.numericUpDownYear = new System.Windows.Forms.NumericUpDown();
            this.buttonSave = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.buttonCoverSelect = new System.Windows.Forms.Button();
            this.labelCoverFilename = new System.Windows.Forms.Label();
            this.labelCover = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYear)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(12, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(60, 13);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Название:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Режисер:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Год выхода:";
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(87, 6);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(227, 20);
            this.textBoxTitle.TabIndex = 3;
            // 
            // comboBoxProducer
            // 
            this.comboBoxProducer.FormattingEnabled = true;
            this.comboBoxProducer.Location = new System.Drawing.Point(87, 36);
            this.comboBoxProducer.Name = "comboBoxProducer";
            this.comboBoxProducer.Size = new System.Drawing.Size(227, 21);
            this.comboBoxProducer.TabIndex = 4;
            // 
            // numericUpDownYear
            // 
            this.numericUpDownYear.Location = new System.Drawing.Point(87, 65);
            this.numericUpDownYear.Maximum = new decimal(new int[] {
            2020,
            0,
            0,
            0});
            this.numericUpDownYear.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.numericUpDownYear.Name = "numericUpDownYear";
            this.numericUpDownYear.Size = new System.Drawing.Size(227, 20);
            this.numericUpDownYear.TabIndex = 5;
            this.numericUpDownYear.Value = new decimal(new int[] {
            2020,
            0,
            0,
            0});
            // 
            // buttonSave
            // 
            this.buttonSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonSave.Location = new System.Drawing.Point(239, 126);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 6;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // buttonCoverSelect
            // 
            this.buttonCoverSelect.Location = new System.Drawing.Point(83, 99);
            this.buttonCoverSelect.Name = "buttonCoverSelect";
            this.buttonCoverSelect.Size = new System.Drawing.Size(55, 23);
            this.buttonCoverSelect.TabIndex = 7;
            this.buttonCoverSelect.Text = "Обзор...";
            this.buttonCoverSelect.UseVisualStyleBackColor = true;
            this.buttonCoverSelect.Click += new System.EventHandler(this.buttonCoverSelect_Click);
            // 
            // labelCoverFilename
            // 
            this.labelCoverFilename.AutoSize = true;
            this.labelCoverFilename.Location = new System.Drawing.Point(144, 104);
            this.labelCoverFilename.Name = "labelCoverFilename";
            this.labelCoverFilename.Size = new System.Drawing.Size(92, 13);
            this.labelCoverFilename.TabIndex = 8;
            this.labelCoverFilename.Text = "Файл не выбран";
            // 
            // labelCover
            // 
            this.labelCover.AutoSize = true;
            this.labelCover.Location = new System.Drawing.Point(12, 104);
            this.labelCover.Name = "labelCover";
            this.labelCover.Size = new System.Drawing.Size(56, 13);
            this.labelCover.TabIndex = 9;
            this.labelCover.Text = "Обложка:";
            // 
            // FormFilm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 161);
            this.Controls.Add(this.labelCover);
            this.Controls.Add(this.labelCoverFilename);
            this.Controls.Add(this.buttonCoverSelect);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.numericUpDownYear);
            this.Controls.Add(this.comboBoxProducer);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelTitle);
            this.Name = "FormFilm";
            this.Text = "Фильм";
            this.Load += new System.EventHandler(this.FormFilm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYear)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.ComboBox comboBoxProducer;
        private System.Windows.Forms.NumericUpDown numericUpDownYear;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button buttonCoverSelect;
        private System.Windows.Forms.Label labelCoverFilename;
        private System.Windows.Forms.Label labelCover;
    }
}