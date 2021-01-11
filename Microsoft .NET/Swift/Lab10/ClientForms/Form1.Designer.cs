namespace ClientForms
{
    partial class Form1
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
            this.labelAnimal = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonClearAnimal = new System.Windows.Forms.Button();
            this.comboBoxProtectionStatus = new System.Windows.Forms.ComboBox();
            this.textBoxHabitat = new System.Windows.Forms.TextBox();
            this.textBoxLatin_Title = new System.Windows.Forms.TextBox();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.labelProtection_Status = new System.Windows.Forms.Label();
            this.labelHabitat = new System.Windows.Forms.Label();
            this.labelLatin_Title = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonGet = new System.Windows.Forms.Button();
            this.labelResponseStatus = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelAnimal
            // 
            this.labelAnimal.AutoSize = true;
            this.labelAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAnimal.Location = new System.Drawing.Point(3, 9);
            this.labelAnimal.Name = "labelAnimal";
            this.labelAnimal.Size = new System.Drawing.Size(79, 16);
            this.labelAnimal.TabIndex = 0;
            this.labelAnimal.Text = "Животное:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.buttonClearAnimal);
            this.panel1.Controls.Add(this.comboBoxProtectionStatus);
            this.panel1.Controls.Add(this.textBoxHabitat);
            this.panel1.Controls.Add(this.textBoxLatin_Title);
            this.panel1.Controls.Add(this.textBoxTitle);
            this.panel1.Controls.Add(this.labelProtection_Status);
            this.panel1.Controls.Add(this.labelHabitat);
            this.panel1.Controls.Add(this.labelLatin_Title);
            this.panel1.Controls.Add(this.labelTitle);
            this.panel1.Controls.Add(this.labelAnimal);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(388, 161);
            this.panel1.TabIndex = 1;
            // 
            // buttonClearAnimal
            // 
            this.buttonClearAnimal.Location = new System.Drawing.Point(284, 9);
            this.buttonClearAnimal.Name = "buttonClearAnimal";
            this.buttonClearAnimal.Size = new System.Drawing.Size(79, 23);
            this.buttonClearAnimal.TabIndex = 9;
            this.buttonClearAnimal.Text = "Очистить";
            this.buttonClearAnimal.UseVisualStyleBackColor = true;
            this.buttonClearAnimal.Click += new System.EventHandler(this.buttonClearAnimal_Click);
            // 
            // comboBoxProtectionStatus
            // 
            this.comboBoxProtectionStatus.FormattingEnabled = true;
            this.comboBoxProtectionStatus.Location = new System.Drawing.Point(127, 128);
            this.comboBoxProtectionStatus.Name = "comboBoxProtectionStatus";
            this.comboBoxProtectionStatus.Size = new System.Drawing.Size(256, 21);
            this.comboBoxProtectionStatus.TabIndex = 8;
            // 
            // textBoxHabitat
            // 
            this.textBoxHabitat.Location = new System.Drawing.Point(103, 101);
            this.textBoxHabitat.Name = "textBoxHabitat";
            this.textBoxHabitat.Size = new System.Drawing.Size(280, 20);
            this.textBoxHabitat.TabIndex = 7;
            // 
            // textBoxLatin_Title
            // 
            this.textBoxLatin_Title.Location = new System.Drawing.Point(127, 75);
            this.textBoxLatin_Title.Name = "textBoxLatin_Title";
            this.textBoxLatin_Title.Size = new System.Drawing.Size(256, 20);
            this.textBoxLatin_Title.TabIndex = 6;
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(72, 49);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(311, 20);
            this.textBoxTitle.TabIndex = 5;
            // 
            // labelProtection_Status
            // 
            this.labelProtection_Status.AutoSize = true;
            this.labelProtection_Status.Location = new System.Drawing.Point(6, 131);
            this.labelProtection_Status.Name = "labelProtection_Status";
            this.labelProtection_Status.Size = new System.Drawing.Size(84, 13);
            this.labelProtection_Status.TabIndex = 4;
            this.labelProtection_Status.Text = "Статус охраны:";
            // 
            // labelHabitat
            // 
            this.labelHabitat.AutoSize = true;
            this.labelHabitat.Location = new System.Drawing.Point(6, 104);
            this.labelHabitat.Name = "labelHabitat";
            this.labelHabitat.Size = new System.Drawing.Size(91, 13);
            this.labelHabitat.TabIndex = 3;
            this.labelHabitat.Text = "Ареал обитания:";
            // 
            // labelLatin_Title
            // 
            this.labelLatin_Title.AutoSize = true;
            this.labelLatin_Title.Location = new System.Drawing.Point(6, 78);
            this.labelLatin_Title.Name = "labelLatin_Title";
            this.labelLatin_Title.Size = new System.Drawing.Size(115, 13);
            this.labelLatin_Title.TabIndex = 2;
            this.labelLatin_Title.Text = "Название на латыни:";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(6, 52);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(60, 13);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "Название:";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.buttonExit);
            this.panel2.Controls.Add(this.buttonDelete);
            this.panel2.Controls.Add(this.buttonUpdate);
            this.panel2.Controls.Add(this.buttonAdd);
            this.panel2.Controls.Add(this.buttonGet);
            this.panel2.Location = new System.Drawing.Point(406, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(151, 161);
            this.panel2.TabIndex = 9;
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(7, 129);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(131, 23);
            this.buttonExit.TabIndex = 4;
            this.buttonExit.Text = "Выход";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(7, 100);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(131, 23);
            this.buttonDelete.TabIndex = 3;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(7, 71);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(131, 23);
            this.buttonUpdate.TabIndex = 2;
            this.buttonUpdate.Text = "Изменить";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(7, 42);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(131, 23);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonGet
            // 
            this.buttonGet.Location = new System.Drawing.Point(7, 9);
            this.buttonGet.Name = "buttonGet";
            this.buttonGet.Size = new System.Drawing.Size(131, 23);
            this.buttonGet.TabIndex = 0;
            this.buttonGet.Text = "Получить";
            this.buttonGet.UseVisualStyleBackColor = true;
            this.buttonGet.Click += new System.EventHandler(this.buttonGet_Click);
            // 
            // labelResponseStatus
            // 
            this.labelResponseStatus.AutoSize = true;
            this.labelResponseStatus.Location = new System.Drawing.Point(16, 184);
            this.labelResponseStatus.Name = "labelResponseStatus";
            this.labelResponseStatus.Size = new System.Drawing.Size(0, 13);
            this.labelResponseStatus.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 206);
            this.Controls.Add(this.labelResponseStatus);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Клиент";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAnimal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelProtection_Status;
        private System.Windows.Forms.Label labelHabitat;
        private System.Windows.Forms.Label labelLatin_Title;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.ComboBox comboBoxProtectionStatus;
        private System.Windows.Forms.TextBox textBoxHabitat;
        private System.Windows.Forms.TextBox textBoxLatin_Title;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonGet;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label labelResponseStatus;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonClearAnimal;
    }
}

