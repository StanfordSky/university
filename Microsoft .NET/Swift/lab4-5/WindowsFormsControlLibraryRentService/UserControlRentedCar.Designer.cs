namespace WindowsFormsControlLibraryRentService
{
    partial class UserControlRentedCar
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
            this.labelClient = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelCar = new System.Windows.Forms.Label();
            this.textBoxClient = new System.Windows.Forms.TextBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.textBoxPeriod = new System.Windows.Forms.TextBox();
            this.textBoxCar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelClient
            // 
            this.labelClient.AutoSize = true;
            this.labelClient.Location = new System.Drawing.Point(3, 6);
            this.labelClient.Name = "labelClient";
            this.labelClient.Size = new System.Drawing.Size(46, 13);
            this.labelClient.TabIndex = 0;
            this.labelClient.Text = "Клиент:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Период проживания:";
            // 
            // labelCar
            // 
            this.labelCar.AutoSize = true;
            this.labelCar.Location = new System.Drawing.Point(323, 6);
            this.labelCar.Name = "labelCar";
            this.labelCar.Size = new System.Drawing.Size(72, 13);
            this.labelCar.TabIndex = 2;
            this.labelCar.Text = "Автомобиль:";
            // 
            // textBoxClient
            // 
            this.textBoxClient.Location = new System.Drawing.Point(54, 3);
            this.textBoxClient.Name = "textBoxClient";
            this.textBoxClient.ReadOnly = true;
            this.textBoxClient.Size = new System.Drawing.Size(263, 20);
            this.textBoxClient.TabIndex = 3;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDelete.ForeColor = System.Drawing.Color.Red;
            this.buttonDelete.Location = new System.Drawing.Point(460, 29);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(0);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(27, 21);
            this.buttonDelete.TabIndex = 8;
            this.buttonDelete.Text = "x";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // textBoxPeriod
            // 
            this.textBoxPeriod.Location = new System.Drawing.Point(122, 29);
            this.textBoxPeriod.Name = "textBoxPeriod";
            this.textBoxPeriod.ReadOnly = true;
            this.textBoxPeriod.Size = new System.Drawing.Size(326, 20);
            this.textBoxPeriod.TabIndex = 7;
            // 
            // textBoxCar
            // 
            this.textBoxCar.Location = new System.Drawing.Point(401, 3);
            this.textBoxCar.Name = "textBoxCar";
            this.textBoxCar.ReadOnly = true;
            this.textBoxCar.Size = new System.Drawing.Size(86, 20);
            this.textBoxCar.TabIndex = 9;
            // 
            // UserControlRentedCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBoxCar);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.textBoxPeriod);
            this.Controls.Add(this.textBoxClient);
            this.Controls.Add(this.labelCar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelClient);
            this.Name = "UserControlRentedCar";
            this.Size = new System.Drawing.Size(495, 55);
            this.Click += new System.EventHandler(this.UserControlRentedCar_Click);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.UserControlRentedCar_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelClient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelCar;
        private System.Windows.Forms.TextBox textBoxClient;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.TextBox textBoxPeriod;
        private System.Windows.Forms.TextBox textBoxCar;
    }
}
