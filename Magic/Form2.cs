using System;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Magic
{
    public partial class Form2 : Form
    {
        private int userNumber; 

        public Form2(int userNumber)
        {
            InitializeComponent();
            this.userNumber = userNumber; 
            StartProcessing(userNumber);
        }

        private async void StartProcessing(int userNumber)
        {
            progressBar1.Style = ProgressBarStyle.Marquee; 
            progressBar1.MarqueeAnimationSpeed = 30; 

            string[] processingSteps = new string[]
            {
                "Analyzing brainwaves...",
                "Scanning memories...",
                "Calculating probabilities...",
                "Decoding thoughts..."
            };

            for (int i = 0; i < processingSteps.Length; i++)
            {
                label1.Text = processingSteps[i];
                await Task.Delay(1000); 
            }

            await Task.Delay(1000);

            progressBar1.Visible = false;

            Form3 form3 = new Form3(this.userNumber); 
            form3.ShowDialog();

            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // This is the label used for displaying processing steps.
        }
    }
}
