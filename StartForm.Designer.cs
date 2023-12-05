namespace definite_integral
{
    partial class StartForm
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
            this.Rectangle_method_Start_Button = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.Trapezoid_method_Start_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Rectangle_method_Start_Button
            // 
            this.Rectangle_method_Start_Button.Location = new System.Drawing.Point(351, 132);
            this.Rectangle_method_Start_Button.Name = "Rectangle_method_Start_Button";
            this.Rectangle_method_Start_Button.Size = new System.Drawing.Size(247, 84);
            this.Rectangle_method_Start_Button.TabIndex = 0;
            this.Rectangle_method_Start_Button.Text = "Методом прямоугольников";
            this.Rectangle_method_Start_Button.UseVisualStyleBackColor = true;
            this.Rectangle_method_Start_Button.Click += new System.EventHandler(this.Rectangle_method_Start_Button_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(417, 367);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(122, 51);
            this.ExitButton.TabIndex = 1;
            this.ExitButton.Text = "Выход";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Trapezoid_method_Start_Button
            // 
            this.Trapezoid_method_Start_Button.Location = new System.Drawing.Point(351, 248);
            this.Trapezoid_method_Start_Button.Name = "Trapezoid_method_Start_Button";
            this.Trapezoid_method_Start_Button.Size = new System.Drawing.Size(247, 84);
            this.Trapezoid_method_Start_Button.TabIndex = 2;
            this.Trapezoid_method_Start_Button.Text = "Методом трапеций";
            this.Trapezoid_method_Start_Button.UseVisualStyleBackColor = true;
            this.Trapezoid_method_Start_Button.Click += new System.EventHandler(this.Trapezoid_method_Start_Button_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(272, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(435, 47);
            this.label1.TabIndex = 3;
            this.label1.Text = "Нахождение определённого интеграла ";
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 498);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Trapezoid_method_Start_Button);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.Rectangle_method_Start_Button);
            this.Name = "StartForm";
            this.Text = "StartForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Rectangle_method_Start_Button;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button Trapezoid_method_Start_Button;
        private System.Windows.Forms.Label label1;
    }
}

