using System.DirectoryServices;

namespace calculator
{
    public partial class Form1 : Form
    {
        double resultValue = 0;
        string operatorClicked = "";
        bool isOperatorClicked = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void click_button(object sender, EventArgs e)
        {
            Button button = (sender as Button);

            // Si es 0 o se acaba de clickear un operador, limpiar
            if (resultB.Text == "0" || isOperatorClicked)
            {
                resultB.Clear(); // Era: resultB.Clear = ();
            }

            isOperatorClicked = false;

            // Manejar el punto decimal
            if (button.Text == ".")
            {
                // Solo agregar punto si no existe ya
                if (!resultB.Text.Contains("."))
                {
                    resultB.Text = resultB.Text + button.Text;
                }
            }
            else
            {
                // Agregar número normal
                resultB.Text = resultB.Text + button.Text;
            }
        }

        private void btD_Click(object sender, EventArgs e)
        {
            if (resultB.Text.Length > 0)
            {
                resultB.Text = resultB.Text.Remove(resultB.Text.Length - 1);
            }

            // Si el texto queda vacío, mostrar 0
            if (resultB.Text == "" || resultB.Text == "-")
            {
                resultB.Text = "0";
            }
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button button = (sender as Button);

            // Si ya hay un valor previo, calcular primero
            if (resultValue != 0)
            {
                btI.PerformClick();
                operatorClicked = button.Text;
                resultValue = double.Parse(resultB.Text);
                isOperatorClicked = true;
            }
            else
            {
                operatorClicked = button.Text;
                resultValue = double.Parse(resultB.Text);
                isOperatorClicked = true;
            }
        }

        private void btC_Click(object sender, EventArgs e)
        {
            resultB.Text = "0";
            resultValue = 0;
            operatorClicked = "";
        }

        private void btI_Click(object sender, EventArgs e)
        {
            // Validar división por cero
            if (operatorClicked == "÷" && double.Parse(resultB.Text) == 0)
            {
                MessageBox.Show("No se puede dividir por cero", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                resultB.Text = "0";
                resultValue = 0;
                return;
            }
            switch (operatorClicked)
            {
                case "+":
                    resultB.Text = (resultValue + double.Parse(resultB.Text)).ToString();
                    break;
                case "-":
                    resultB.Text = (resultValue - double.Parse(resultB.Text)).ToString();
                    break;
                case "x":
                    resultB.Text = (resultValue * double.Parse(resultB.Text)).ToString();
                    break;
                case "÷":
                    resultB.Text = (resultValue / double.Parse(resultB.Text)).ToString();
                    break;
                case "%":
                    resultB.Text = (resultValue % double.Parse(resultB.Text)).ToString();
                    break;
                default:
                    break;
            }
            resultValue = double.Parse(resultB.Text);
            operatorClicked = "";
        }

        private void btCE_Click(object sender, EventArgs e)
        {
            resultB.Text = "0";
        }
    }
}
