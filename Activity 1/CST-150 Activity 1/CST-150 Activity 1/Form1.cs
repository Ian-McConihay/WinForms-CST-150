/*
 * Ian McConihay
 * CST-150
 * HelloWorldFormsApp
 * Aug 2024
 * 
 */

namespace CST_150_Activity_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblMars.Visible = false;
            lblMarsWeight.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Click Event for Convert Button
        /// </summary>
        /// <param name="sender">The source of the event,the button that was clicked.</param>
        /// <param name="e">An instance of <see cref="EventArgs"/> that contains no event data for this event.</param>
        private void ConvertButtonClickEvent(object sender, EventArgs e)
        {
            // Declare and Initialize
            decimal earthWeight = 0.0M;
            decimal finalValue = 0.0M;
            decimal gravAccEarth = 9.81M;
            decimal gravAccMars = 3.711M;

            // Read in the earth weight
            earthWeight = Convert.ToDecimal(txtEarthWeight.Text);

            // Calculate the final value
            finalValue = (earthWeight / gravAccEarth) * gravAccMars;

            // Display the results 
            lblMarsWeight.Text = string.Format("{0:.##} lbs", finalValue);

            // Make sure to show the mars value and label
            lblMars.Visible = true;
            lblMarsWeight.Visible = true;

        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }
    }
}
