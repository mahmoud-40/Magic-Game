using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Magic
{
    public partial class Form3 : Form
    {
        private int userNumber; 

        public Form3(int userNumber)
        {
            InitializeComponent();
            this.userNumber = userNumber;
            label1.Text = $"You are thinking of the number {this.userNumber}!";
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
