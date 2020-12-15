namespace Bjuro
{
    partial class FormJobSeeker
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
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelMiddleName = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelQualification = new System.Windows.Forms.Label();
            this.labelKindOfActivity = new System.Windows.Forms.Label();
            this.labelPassport = new System.Windows.Forms.Label();
            this.labelSalary = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxMiddleName = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxQualification = new System.Windows.Forms.TextBox();
            this.textBoxKindOfActivity = new System.Windows.Forms.TextBox();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.textBoxSeria = new System.Windows.Forms.TextBox();
            this.textBoxDate = new System.Windows.Forms.TextBox();
            this.textBoxIssuer = new System.Windows.Forms.TextBox();
            this.textBoxSalary = new System.Windows.Forms.TextBox();
            this.labelNumber = new System.Windows.Forms.Label();
            this.labelSeria = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelIssuer = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(73, 50);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(29, 13);
            this.labelFirstName.TabIndex = 0;
            this.labelFirstName.Text = "Имя";
            // 
            // labelMiddleName
            // 
            this.labelMiddleName.AutoSize = true;
            this.labelMiddleName.Location = new System.Drawing.Point(73, 82);
            this.labelMiddleName.Name = "labelMiddleName";
            this.labelMiddleName.Size = new System.Drawing.Size(54, 13);
            this.labelMiddleName.TabIndex = 1;
            this.labelMiddleName.Text = "Отчество";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(73, 119);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(56, 13);
            this.labelLastName.TabIndex = 2;
            this.labelLastName.Text = "Фамилия";
            // 
            // labelQualification
            // 
            this.labelQualification.AutoSize = true;
            this.labelQualification.Location = new System.Drawing.Point(73, 150);
            this.labelQualification.Name = "labelQualification";
            this.labelQualification.Size = new System.Drawing.Size(82, 13);
            this.labelQualification.TabIndex = 3;
            this.labelQualification.Text = "Квалификация";
            // 
            // labelKindOfActivity
            // 
            this.labelKindOfActivity.AutoSize = true;
            this.labelKindOfActivity.Location = new System.Drawing.Point(73, 184);
            this.labelKindOfActivity.Name = "labelKindOfActivity";
            this.labelKindOfActivity.Size = new System.Drawing.Size(99, 13);
            this.labelKindOfActivity.TabIndex = 4;
            this.labelKindOfActivity.Text = "Вид деятельности";
            // 
            // labelPassport
            // 
            this.labelPassport.AutoSize = true;
            this.labelPassport.Location = new System.Drawing.Point(73, 255);
            this.labelPassport.Name = "labelPassport";
            this.labelPassport.Size = new System.Drawing.Size(111, 13);
            this.labelPassport.TabIndex = 5;
            this.labelPassport.Text = "Паспортные данные";
            // 
            // labelSalary
            // 
            this.labelSalary.AutoSize = true;
            this.labelSalary.Location = new System.Drawing.Point(73, 298);
            this.labelSalary.Name = "labelSalary";
            this.labelSalary.Size = new System.Drawing.Size(233, 13);
            this.labelSalary.TabIndex = 6;
            this.labelSalary.Text = "Предполагаемый размер заработной платы";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(349, 42);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(100, 20);
            this.textBoxFirstName.TabIndex = 7;
            // 
            // textBoxMiddleName
            // 
            this.textBoxMiddleName.Location = new System.Drawing.Point(349, 79);
            this.textBoxMiddleName.Name = "textBoxMiddleName";
            this.textBoxMiddleName.Size = new System.Drawing.Size(100, 20);
            this.textBoxMiddleName.TabIndex = 8;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(349, 116);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(100, 20);
            this.textBoxLastName.TabIndex = 9;
            // 
            // textBoxQualification
            // 
            this.textBoxQualification.Location = new System.Drawing.Point(349, 147);
            this.textBoxQualification.Name = "textBoxQualification";
            this.textBoxQualification.Size = new System.Drawing.Size(100, 20);
            this.textBoxQualification.TabIndex = 10;
            // 
            // textBoxKindOfActivity
            // 
            this.textBoxKindOfActivity.Location = new System.Drawing.Point(349, 177);
            this.textBoxKindOfActivity.Name = "textBoxKindOfActivity";
            this.textBoxKindOfActivity.Size = new System.Drawing.Size(100, 20);
            this.textBoxKindOfActivity.TabIndex = 11;
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.Location = new System.Drawing.Point(350, 246);
            this.textBoxNumber.MaxLength = 4;
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(100, 20);
            this.textBoxNumber.TabIndex = 12;
            // 
            // textBoxSeria
            // 
            this.textBoxSeria.Location = new System.Drawing.Point(456, 246);
            this.textBoxSeria.MaxLength = 6;
            this.textBoxSeria.Name = "textBoxSeria";
            this.textBoxSeria.Size = new System.Drawing.Size(100, 20);
            this.textBoxSeria.TabIndex = 13;
            // 
            // textBoxDate
            // 
            this.textBoxDate.Location = new System.Drawing.Point(668, 418);
            this.textBoxDate.Name = "textBoxDate";
            this.textBoxDate.Size = new System.Drawing.Size(100, 20);
            this.textBoxDate.TabIndex = 14;
            this.textBoxDate.Visible = false;
            // 
            // textBoxIssuer
            // 
            this.textBoxIssuer.Location = new System.Drawing.Point(709, 246);
            this.textBoxIssuer.Name = "textBoxIssuer";
            this.textBoxIssuer.Size = new System.Drawing.Size(100, 20);
            this.textBoxIssuer.TabIndex = 15;
            // 
            // textBoxSalary
            // 
            this.textBoxSalary.Location = new System.Drawing.Point(349, 291);
            this.textBoxSalary.Name = "textBoxSalary";
            this.textBoxSalary.Size = new System.Drawing.Size(100, 20);
            this.textBoxSalary.TabIndex = 16;
            // 
            // labelNumber
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.Location = new System.Drawing.Point(347, 230);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(91, 13);
            this.labelNumber.TabIndex = 17;
            this.labelNumber.Text = "Номер паспорта";
            // 
            // labelSeria
            // 
            this.labelSeria.AutoSize = true;
            this.labelSeria.Location = new System.Drawing.Point(453, 230);
            this.labelSeria.Name = "labelSeria";
            this.labelSeria.Size = new System.Drawing.Size(88, 13);
            this.labelSeria.TabIndex = 18;
            this.labelSeria.Text = "Серия паспорта";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(559, 230);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(123, 13);
            this.labelDate.TabIndex = 19;
            this.labelDate.Text = "Дата выдачи паспорта";
            // 
            // labelIssuer
            // 
            this.labelIssuer.AutoSize = true;
            this.labelIssuer.Location = new System.Drawing.Point(706, 230);
            this.labelIssuer.Name = "labelIssuer";
            this.labelIssuer.Size = new System.Drawing.Size(107, 13);
            this.labelIssuer.TabIndex = 20;
            this.labelIssuer.Text = "Кем выдан паспорт";
            // 
            // buttonSave
            // 
            this.buttonSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonSave.Location = new System.Drawing.Point(361, 382);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 21;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.Location = new System.Drawing.Point(562, 246);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(138, 20);
            this.dateTimePickerDate.TabIndex = 22;
            // 
            // FormJobSeeker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 450);
            this.Controls.Add(this.dateTimePickerDate);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.labelIssuer);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelSeria);
            this.Controls.Add(this.labelNumber);
            this.Controls.Add(this.textBoxSalary);
            this.Controls.Add(this.textBoxIssuer);
            this.Controls.Add(this.textBoxDate);
            this.Controls.Add(this.textBoxSeria);
            this.Controls.Add(this.textBoxNumber);
            this.Controls.Add(this.textBoxKindOfActivity);
            this.Controls.Add(this.textBoxQualification);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxMiddleName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.labelSalary);
            this.Controls.Add(this.labelPassport);
            this.Controls.Add(this.labelKindOfActivity);
            this.Controls.Add(this.labelQualification);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.labelMiddleName);
            this.Controls.Add(this.labelFirstName);
            this.Name = "FormJobSeeker";
            this.Text = "Соискатель";
            this.Load += new System.EventHandler(this.JobSeeker_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelMiddleName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelQualification;
        private System.Windows.Forms.Label labelKindOfActivity;
        private System.Windows.Forms.Label labelPassport;
        private System.Windows.Forms.Label labelSalary;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxMiddleName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxQualification;
        private System.Windows.Forms.TextBox textBoxKindOfActivity;
        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.TextBox textBoxSeria;
        private System.Windows.Forms.TextBox textBoxDate;
        private System.Windows.Forms.TextBox textBoxIssuer;
        private System.Windows.Forms.TextBox textBoxSalary;
        private System.Windows.Forms.Label labelNumber;
        private System.Windows.Forms.Label labelSeria;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelIssuer;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
    }
}