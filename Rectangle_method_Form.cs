using System;
using System.Windows.Forms;


namespace definite_integral
{
    public partial class Rectangle_method_Form : Form
    {
        public Rectangle_method_Form()
        {
            InitializeComponent();
        }

        int index = 0;

        private void Back_Button_Click(object sender, EventArgs e)
        {
            StartForm startForm = new StartForm();
            startForm.Show();
            this.Close();
        }

        private void Calculation_button_Click(object sender, EventArgs e)
        {
            try
            {
                double f(double x) => 1 / (Math.Log(x));
                double a = Convert.ToDouble(A_textBox.Text);
                double b = Convert.ToDouble(B_textBox.Text);
                int n = Convert.ToInt32(N_textBox.Text);

                if (n > 0)
                {
                    switch (index)
                    {
                        case 0:
                            MessageBox.Show("Выбирите метод для вычисления");
                            break;
                        case 1:
                            var result = LeftRectangle(f, a, b, n);
                            Result_textBox.Text = result.ToString();
                            break;
                        case 2:
                            var result2 = RightRectangle(f, a, b, n);
                            Result_textBox.Text = result2.ToString();
                            break;
                        case 3:
                            var result3 = CentralRectangle(f, a, b, n);
                            Result_textBox.Text = result3.ToString();
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Точность должна быть положительным целым числом");
                }
            }
            catch
            {
                MessageBox.Show("Точность должна быть положительным целым числом");
            }
        }
        static double LeftRectangle(Func<double, double> f, double a, double b, int n)
        {
            var h = (b - a) / n;
            var sum = 0d;
            for (var i = 0; i <= n - 1; i++)
            {
                var x = a + i * h;
                sum += f(x);
            }

            var result = h * sum;
            return result;
        }

        static double RightRectangle(Func<double, double> f, double a, double b, int n)
        {
            var h = (b - a) / n;
            var sum = 0d;
            for (var i = 1; i <= n; i++)
            {
                var x = a + i * h;
                sum += f(x);
            }

            var result = h * sum;
            return result;
        }

        static double CentralRectangle(Func<double, double> f, double a, double b, int n)
        {
            var h = (b - a) / n;
            var sum = (f(a) + f(b)) / 2;
            for (var i = 1; i < n; i++)
            {
                var x = a + h * i;
                sum += f(x);
            }

            var result = h * sum;
            return result;
        }

        private void LeftRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            index = 1;
        }

        private void RightRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            index = 2;
        }

        private void CenterRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            index = 3;
        }
    }
}
