namespace Bjuro
{
    partial class FormDealing
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
            this.comboBoxEmployer = new System.Windows.Forms.ComboBox();
            this.comboBoxJobSeeker = new System.Windows.Forms.ComboBox();
            this.textBoxPost = new System.Windows.Forms.TextBox();
            this.textBoxCommission = new System.Windows.Forms.TextBox();
            this.labelEmployer = new System.Windows.Forms.Label();
            this.labelJobSeeker = new System.Windows.Forms.Label();
            this.labelPost = new System.Windows.Forms.Label();
            this.labelCommission = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxEmployer
            // 
            this.comboBoxEmployer.FormattingEnabled = true;
            this.comboBoxEmployer.Location = new System.Drawing.Point(288, 47);
            this.comboBoxEmployer.Name = "comboBoxEmployer";
            this.comboBoxEmployer.Size = new System.Drawing.Size(121, 21);
            this.comboBoxEmployer.TabIndex = 0;
            // 
            // comboBoxJobSeeker
            // 
            this.comboBoxJobSeeker.FormattingEnabled = true;
            this.comboBoxJobSeeker.Location = new System.Drawing.Point(288, 75);
            this.comboBoxJobSeeker.Name = "comboBoxJobSeeker";
            this.comboBoxJobSeeker.Size = new System.Drawing.Size(121, 21);
            this.comboBoxJobSeeker.TabIndex = 1;
            // 
            // textBoxPost
            // 
            this.textBoxPost.Location = new System.Drawing.Point(288, 120);
            this.textBoxPost.Name = "textBoxPost";
            this.textBoxPost.Size = new System.Drawing.Size(121, 20);
            this.textBoxPost.TabIndex = 2;
            // 
            // textBoxCommission
            // 
            this.textBoxCommission.Location = new System.Drawing.Point(288, 147);
            this.textBoxCommission.Name = "textBoxCommission";
            this.textBoxCommission.Size = new System.Drawing.Size(121, 20);
            this.textBoxCommission.TabIndex = 3;
            // 
            // labelEmployer
            // 
            this.labelEmployer.AutoSize = true;
            this.labelEmployer.Location = new System.Drawing.Point(28, 54);
            this.labelEmployer.Name = "labelEmployer";
            this.labelEmployer.Size = new System.Drawing.Size(78, 13);
            this.labelEmployer.TabIndex = 4;
            this.labelEmployer.Text = "Работодатель";
            // 
            // labelJobSeeker
            // 
            this.labelJobSeeker.AutoSize = true;
            this.labelJobSeeker.Location = new System.Drawing.Point(28, 83);
            this.labelJobSeeker.Name = "labelJobSeeker";
            this.labelJobSeeker.Size = new System.Drawing.Size(67, 13);
            this.labelJobSeeker.TabIndex = 5;
            this.labelJobSeeker.Text = "Соискатель";
            // 
            // labelPost
            // 
            this.labelPost.AutoSize = true;
            this.labelPost.Location = new System.Drawing.Point(28, 127);
            this.labelPost.Name = "labelPost";
            this.labelPost.Size = new System.Drawing.Size(65, 13);
            this.labelPost.TabIndex = 6;
            this.labelPost.Text = "Должность";
            // 
            // labelCommission
            // 
            this.labelCommission.AutoSize = true;
            this.labelCommission.Location = new System.Drawing.Point(28, 154);
            this.labelCommission.Name = "labelCommission";
            this.labelCommission.Size = new System.Drawing.Size(84, 13);
            this.labelCommission.TabIndex = 7;
            this.labelCommission.Text = "Комиссионные";
            // 
            // buttonSave
            // 
            this.buttonSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonSave.Location = new System.Drawing.Point(173, 178);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 8;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // FormDealing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 213);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.labelCommission);
            this.Controls.Add(this.labelPost);
            this.Controls.Add(this.labelJobSeeker);
            this.Controls.Add(this.labelEmployer);
            this.Controls.Add(this.textBoxCommission);
            this.Controls.Add(this.textBoxPost);
            this.Controls.Add(this.comboBoxJobSeeker);
            this.Controls.Add(this.comboBoxEmployer);
            this.Name = "FormDealing";
            this.Text = "Сделки";
            this.Load += new System.EventHandler(this.FormDealings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxEmployer;
        private System.Windows.Forms.ComboBox comboBoxJobSeeker;
        private System.Windows.Forms.TextBox textBoxPost;
        private System.Windows.Forms.TextBox textBoxCommission;
        private System.Windows.Forms.Label labelEmployer;
        private System.Windows.Forms.Label labelJobSeeker;
        private System.Windows.Forms.Label labelPost;
        private System.Windows.Forms.Label labelCommission;
        private System.Windows.Forms.Button buttonSave;
    }
}