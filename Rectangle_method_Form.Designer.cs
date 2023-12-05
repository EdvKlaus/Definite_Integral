namespace definite_integral
{
    partial class Rectangle_method_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rectangle_method_Form));
            this.Back_Button = new System.Windows.Forms.Button();
            this.Caalculation_button = new System.Windows.Forms.Button();
            this.A_textBox = new System.Windows.Forms.TextBox();
            this.B_textBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.N_textBox = new System.Windows.Forms.TextBox();
            this.Result_textBox = new System.Windows.Forms.TextBox();
            this.LeftRadioButton = new System.Windows.Forms.RadioButton();
            this.RightRadioButton = new System.Windows.Forms.RadioButton();
            this.CenterRadioButton = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Back_Button
            // 
            this.Back_Button.Location = new System.Drawing.Point(63, 356);
            this.Back_Button.Name = "Back_Button";
            this.Back_Button.Size = new System.Drawing.Size(132, 45);
            this.Back_Button.TabIndex = 0;
            this.Back_Button.Text = "Назад";
            this.Back_Button.UseVisualStyleBackColor = true;
            this.Back_Button.Click += new System.EventHandler(this.Back_Button_Click);
            // 
            // Caalculation_button
            // 
            this.Caalculation_button.Location = new System.Drawing.Point(325, 356);
            this.Caalculation_button.Name = "Caalculation_button";
            this.Caalculation_button.Size = new System.Drawing.Size(166, 45);
            this.Caalculation_button.TabIndex = 1;
            this.Caalculation_button.Text = "Расчитать";
            this.Caalculation_button.UseVisualStyleBackColor = true;
            this.Caalculation_button.Click += new System.EventHandler(this.Calculation_button_Click);
            // 
            // A_textBox
            // 
            this.A_textBox.Location = new System.Drawing.Point(221, 65);
            this.A_textBox.Name = "A_textBox";
            this.A_textBox.Size = new System.Drawing.Size(25, 22);
            this.A_textBox.TabIndex = 3;
            // 
            // B_textBox
            // 
            this.B_textBox.Location = new System.Drawing.Point(221, 134);
            this.B_textBox.Name = "B_textBox";
            this.B_textBox.Size = new System.Drawing.Size(25, 22);
            this.B_textBox.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(163, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(223, 114);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(163, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Введите точность";
            // 
            // N_textBox
            // 
            this.N_textBox.Location = new System.Drawing.Point(163, 209);
            this.N_textBox.Name = "N_textBox";
            this.N_textBox.Size = new System.Drawing.Size(126, 22);
            this.N_textBox.TabIndex = 7;
            // 
            // Result_textBox
            // 
            this.Result_textBox.Location = new System.Drawing.Point(431, 99);
            this.Result_textBox.Name = "Result_textBox";
            this.Result_textBox.Size = new System.Drawing.Size(126, 22);
            this.Result_textBox.TabIndex = 8;
            // 
            // LeftRadioButton
            // 
            this.LeftRadioButton.AutoSize = true;
            this.LeftRadioButton.Location = new System.Drawing.Point(163, 249);
            this.LeftRadioButton.Name = "LeftRadioButton";
            this.LeftRadioButton.Size = new System.Drawing.Size(187, 20);
            this.LeftRadioButton.TabIndex = 9;
            this.LeftRadioButton.TabStop = true;
            this.LeftRadioButton.Text = "Левых прямоугольников";
            this.LeftRadioButton.UseVisualStyleBackColor = true;
            this.LeftRadioButton.CheckedChanged += new System.EventHandler(this.LeftRadioButton_CheckedChanged);
            // 
            // RightRadioButton
            // 
            this.RightRadioButton.AutoSize = true;
            this.RightRadioButton.Location = new System.Drawing.Point(163, 275);
            this.RightRadioButton.Name = "RightRadioButton";
            this.RightRadioButton.Size = new System.Drawing.Size(196, 20);
            this.RightRadioButton.TabIndex = 10;
            this.RightRadioButton.TabStop = true;
            this.RightRadioButton.Text = "Правых прямоугольников";
            this.RightRadioButton.UseVisualStyleBackColor = true;
            this.RightRadioButton.CheckedChanged += new System.EventHandler(this.RightRadioButton_CheckedChanged);
            // 
            // CenterRadioButton
            // 
            this.CenterRadioButton.AutoSize = true;
            this.CenterRadioButton.Location = new System.Drawing.Point(163, 301);
            this.CenterRadioButton.Name = "CenterRadioButton";
            this.CenterRadioButton.Size = new System.Drawing.Size(233, 20);
            this.CenterRadioButton.TabIndex = 11;
            this.CenterRadioButton.TabStop = true;
            this.CenterRadioButton.Text = "Центральных прямоугольников";
            this.CenterRadioButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(392, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 32);
            this.label2.TabIndex = 21;
            this.label2.Text = "=";
            // 
            // Rectangle_method_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CenterRadioButton);
            this.Controls.Add(this.RightRadioButton);
            this.Controls.Add(this.LeftRadioButton);
            this.Controls.Add(this.Result_textBox);
            this.Controls.Add(this.N_textBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.B_textBox);
            this.Controls.Add(this.A_textBox);
            this.Controls.Add(this.Caalculation_button);
            this.Controls.Add(this.Back_Button);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Rectangle_method_Form";
            this.Text = "Rectangle_method_Form";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Back_Button;
        private System.Windows.Forms.Button Caalculation_button;
        private System.Windows.Forms.TextBox A_textBox;
        private System.Windows.Forms.TextBox B_textBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox N_textBox;
        private System.Windows.Forms.TextBox Result_textBox;
        private System.Windows.Forms.RadioButton LeftRadioButton;
        private System.Windows.Forms.RadioButton RightRadioButton;
        private System.Windows.Forms.RadioButton CenterRadioButton;
        private System.Windows.Forms.Label label2;
    }
}