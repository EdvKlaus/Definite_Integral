using System;
using System.Windows.Forms;

namespace definite_integral
{
    public partial class Trapezoid_method_Form : Form
    {
        public Trapezoid_method_Form()
        {
            InitializeComponent();
        }

        private void Back_Button_Click(object sender, EventArgs e)
        {
            StartForm startForm = new StartForm();
            startForm.Show();
            this.Close();
        }
        static double Trapezium(Func<double, double> func, double n, double a, double b)
        {
            double x, h, s;
            h = (b - a) / n; //шаг (он же основание трапеции)
            s = (func(a) + func(b)) / 2; //точно не помню, но вроде как тут учитываем граничные значения 
            for (x = a + h; x < b; x += h)
            {
                s += func(x); //складываем значения правых сторон всех трапеций
            }
            return s * h; //домножаем на шаг
        }

        private void CalculationButton_Click(object sender, EventArgs e)
        {
            try
            {
                double f(double x) => 1 / (Math.Log(x));
                double a = Convert.ToDouble(A_textBox.Text);
                double b = Convert.ToDouble(B_textBox.Text);
                int n = Convert.ToInt32(N_textBox.Text);

                if (n > 0)
                {
                    var result = Trapezium(f, n, a, b);
                    result_textBox.Text = result.ToString();
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
    }
}
