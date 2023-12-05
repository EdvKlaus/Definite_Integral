namespace definite_integral
{
    partial class Trapezoid_method_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Trapezoid_method_Form));
            this.Back_Button = new System.Windows.Forms.Button();
            this.result_textBox = new System.Windows.Forms.TextBox();
            this.N_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.B_textBox = new System.Windows.Forms.TextBox();
            this.A_textBox = new System.Windows.Forms.TextBox();
            this.CalculationButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Back_Button
            // 
            this.Back_Button.Location = new System.Drawing.Point(67, 354);
            this.Back_Button.Name = "Back_Button";
            this.Back_Button.Size = new System.Drawing.Size(132, 45);
            this.Back_Button.TabIndex = 1;
            this.Back_Button.Text = "Назад";
            this.Back_Button.UseVisualStyleBackColor = true;
            this.Back_Button.Click += new System.EventHandler(this.Back_Button_Click);
            // 
            // result_textBox
            // 
            this.result_textBox.Location = new System.Drawing.Point(486, 166);
            this.result_textBox.Name = "result_textBox";
            this.result_textBox.Size = new System.Drawing.Size(126, 22);
            this.result_textBox.TabIndex = 19;
            // 
            // N_textBox
            // 
            this.N_textBox.Location = new System.Drawing.Point(221, 265);
            this.N_textBox.Name = "N_textBox";
            this.N_textBox.Size = new System.Drawing.Size(126, 22);
            this.N_textBox.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(221, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "Введите точность";
            // 
            // B_textBox
            // 
            this.B_textBox.Location = new System.Drawing.Point(279, 190);
            this.B_textBox.Name = "B_textBox";
            this.B_textBox.Size = new System.Drawing.Size(25, 22);
            this.B_textBox.TabIndex = 15;
            // 
            // A_textBox
            // 
            this.A_textBox.Location = new System.Drawing.Point(279, 121);
            this.A_textBox.Name = "A_textBox";
            this.A_textBox.Size = new System.Drawing.Size(25, 22);
            this.A_textBox.TabIndex = 14;
            // 
            // CalculationButton
            // 
            this.CalculationButton.Location = new System.Drawing.Point(328, 354);
            this.CalculationButton.Name = "CalculationButton";
            this.CalculationButton.Size = new System.Drawing.Size(166, 45);
            this.CalculationButton.TabIndex = 13;
            this.CalculationButton.Text = "Расчитать";
            this.CalculationButton.UseVisualStyleBackColor = true;
            this.CalculationButton.Click += new System.EventHandler(this.CalculationButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(221, 109);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(223, 114);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(450, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 32);
            this.label2.TabIndex = 20;
            this.label2.Text = "=";
            // 
            // Trapezoid_method_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.result_textBox);
            this.Controls.Add(this.N_textBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.B_textBox);
            this.Controls.Add(this.A_textBox);
            this.Controls.Add(this.CalculationButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Back_Button);
            this.Name = "Trapezoid_method_Form";
            this.Text = "Trapezoid_method_Form";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Back_Button;
        private System.Windows.Forms.TextBox result_textBox;
        private System.Windows.Forms.TextBox N_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox B_textBox;
        private System.Windows.Forms.TextBox A_textBox;
        private System.Windows.Forms.Button CalculationButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
    }
}