using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace definite_integral
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void Rectangle_method_Start_Button_Click(object sender, EventArgs e)
        {
            Rectangle_method_Form rectangle_Method_Form = new Rectangle_method_Form();
            rectangle_Method_Form.Show();
            this.Hide();
        }

        private void Trapezoid_method_Start_Button_Click(object sender, EventArgs e)
        {
            Trapezoid_method_Form trapezoid_Method_Form = new Trapezoid_method_Form();
            trapezoid_Method_Form.Show();
            this.Hide();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
