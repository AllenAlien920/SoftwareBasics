namespace Assignment1_2;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        try
        {
            var a = double.Parse(textBox1.Text);
            var b = double.Parse(textBox2.Text);
            if (comboBox1.SelectedItem == null)
            {
                throw new ArgumentException();
            }

            double ans;
            switch (comboBox1.SelectedItem)
            {
                case "+":
                    ans = a + b;
                    break;
                case "-":
                    ans = a - b;
                    break;
                case "*":
                    ans = a * b;
                    break;
                case "/":
                    if (b == 0)
                    {
                        throw new ArithmeticException();
                    }

                    ans = a / b;
                    break;
                default:
                    throw new FormatException();
            }

            label1.Text = "Result: " + ans;
        }
        catch (FormatException)
        {
            MessageBox.Show("Please enter a valid number");
        }
        catch (ArithmeticException)
        {
            MessageBox.Show("Denominator cannot be 0");
        }
        catch (ArgumentException)
        {
            MessageBox.Show("Please select an operator");
        }
    }
}