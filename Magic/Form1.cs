using System;
using System.Windows.Forms;

namespace Magic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int userNumber))
            {
                // Pass userNumber to Form2
                Form2 form2 = new Form2(userNumber);
                label1.Text = "Think of a number between 1 and 10:"; // Show this label before Form2
                form2.ShowDialog();
            }
            else
            {
                label1.Text = "Invalid input. Please enter a valid number.";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Avoid changing label visibility here
        }
    }
}
