namespace WindowsFormsControlLibraryBjuro
{
    partial class UserControlDealing
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelEmployer = new System.Windows.Forms.Label();
            this.labelJobSeeker = new System.Windows.Forms.Label();
            this.labelPost = new System.Windows.Forms.Label();
            this.labelCommission = new System.Windows.Forms.Label();
            this.textBoxEmployer = new System.Windows.Forms.TextBox();
            this.textBoxJobSeeker = new System.Windows.Forms.TextBox();
            this.textBoxPost = new System.Windows.Forms.TextBox();
            this.textBoxCommission = new System.Windows.Forms.TextBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelEmployer
            // 
            this.labelEmployer.AutoSize = true;
            this.labelEmployer.Location = new System.Drawing.Point(3, 6);
            this.labelEmployer.Name = "labelEmployer";
            this.labelEmployer.Size = new System.Drawing.Size(81, 13);
            this.labelEmployer.TabIndex = 0;
            this.labelEmployer.Text = "Работодатель:";
            // 
            // labelJobSeeker
            // 
            this.labelJobSeeker.AutoSize = true;
            this.labelJobSeeker.Location = new System.Drawing.Point(3, 27);
            this.labelJobSeeker.Name = "labelJobSeeker";
            this.labelJobSeeker.Size = new System.Drawing.Size(70, 13);
            this.labelJobSeeker.TabIndex = 1;
            this.labelJobSeeker.Text = "Соискатель:";
            // 
            // labelPost
            // 
            this.labelPost.AutoSize = true;
            this.labelPost.Location = new System.Drawing.Point(3, 53);
            this.labelPost.Name = "labelPost";
            this.labelPost.Size = new System.Drawing.Size(68, 13);
            this.labelPost.TabIndex = 2;
            this.labelPost.Text = "Должность:";
            // 
            // labelCommission
            // 
            this.labelCommission.AutoSize = true;
            this.labelCommission.Location = new System.Drawing.Point(283, 53);
            this.labelCommission.Name = "labelCommission";
            this.labelCommission.Size = new System.Drawing.Size(81, 13);
            this.labelCommission.TabIndex = 3;
            this.labelCommission.Text = "Комисионные:";
            // 
            // textBoxEmployer
            // 
            this.textBoxEmployer.Location = new System.Drawing.Point(87, 3);
            this.textBoxEmployer.Name = "textBoxEmployer";
            this.textBoxEmployer.ReadOnly = true;
            this.textBoxEmployer.Size = new System.Drawing.Size(447, 20);
            this.textBoxEmployer.TabIndex = 4;
            // 
            // textBoxJobSeeker
            // 
            this.textBoxJobSeeker.Location = new System.Drawing.Point(87, 24);
            this.textBoxJobSeeker.Name = "textBoxJobSeeker";
            this.textBoxJobSeeker.ReadOnly = true;
            this.textBoxJobSeeker.Size = new System.Drawing.Size(447, 20);
            this.textBoxJobSeeker.TabIndex = 5;
            // 
            // textBoxPost
            // 
            this.textBoxPost.Location = new System.Drawing.Point(87, 50);
            this.textBoxPost.Name = "textBoxPost";
            this.textBoxPost.ReadOnly = true;
            this.textBoxPost.Size = new System.Drawing.Size(190, 20);
            this.textBoxPost.TabIndex = 6;
            // 
            // textBoxCommission
            // 
            this.textBoxCommission.Location = new System.Drawing.Point(370, 50);
            this.textBoxCommission.Name = "textBoxCommission";
            this.textBoxCommission.ReadOnly = true;
            this.textBoxCommission.Size = new System.Drawing.Size(137, 20);
            this.textBoxCommission.TabIndex = 7;
            // 
            // buttonDelete
            // 
            this.buttonDelete.ForeColor = System.Drawing.Color.Red;
            this.buttonDelete.Location = new System.Drawing.Point(513, 50);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(21, 22);
            this.buttonDelete.TabIndex = 8;
            this.buttonDelete.Text = "x";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDeletePost_Click);
            // 
            // UserControlDealing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.textBoxCommission);
            this.Controls.Add(this.textBoxPost);
            this.Controls.Add(this.textBoxJobSeeker);
            this.Controls.Add(this.textBoxEmployer);
            this.Controls.Add(this.labelCommission);
            this.Controls.Add(this.labelPost);
            this.Controls.Add(this.labelJobSeeker);
            this.Controls.Add(this.labelEmployer);
            this.Name = "UserControlDealing";
            this.Size = new System.Drawing.Size(537, 73);
            this.Click += new System.EventHandler(this.UserControlDealing_Click);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.UserControlDealing_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEmployer;
        private System.Windows.Forms.Label labelJobSeeker;
        private System.Windows.Forms.Label labelPost;
        private System.Windows.Forms.Label labelCommission;
        private System.Windows.Forms.TextBox textBoxEmployer;
        private System.Windows.Forms.TextBox textBoxJobSeeker;
        private System.Windows.Forms.TextBox textBoxPost;
        private System.Windows.Forms.TextBox textBoxCommission;
        private System.Windows.Forms.Button buttonDelete;
    }
}
