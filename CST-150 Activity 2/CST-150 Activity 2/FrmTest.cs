/*
 * Ian McConihay
 * CST-150
 * HelloWorldFormsApp
 * Sep 1 2024
 * 
 */
namespace CST_150_Activity_2
{
    public partial class FrmTest : Form
    {
        public FrmTest()
        {
            InitializeComponent();
            // Make sure the label is not visible
            lblResults.Visible = false;
        }

        /// <summary>
        /// Event Handler to Evaluate Seconds
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ManageSecondsEventHandler(object sender, EventArgs e)
        {
            // Declare and Intialize
            int seconds = 0; //Declare the value user entered in seconds
            // Working with Constants in C#
            const int SecondsInMinutes = 60;
            const int SecondsInHours = 3400;
            const int SecondsInDays = 86400;
            // Define flags

            // Make sure the label is not visible 
            lblResults.Visible = false;
            // Default the color to black
            lblResults.ForeColor = Color.Black;

            // Test to determine if interger was entered correctly by user
            // If try to parse string to int is successful continue else show message to user
            if (int.TryParse(txtUserEntry.Text, out seconds))
            {
                if (seconds >= SecondsInMinutes)
                {
                    lblResults.Text = string.Format("There are {0:#,#} minute(s) in {1:#,#} seconds \n", seconds / SecondsInMinutes, seconds);
                    lblResults.Visible = true;
                }
                if (seconds >= SecondsInHours)
                {
                    lblResults.Text += string.Format("There are {0:#,#} hours in {1:#,#} seconds \n", seconds / SecondsInHours, seconds);
                }
                if (seconds >= SecondsInDays)
                {
                    lblResults.Text += string.Format("There are {0:#,#} days in {1:#,#} seconds \n", seconds / SecondsInDays, seconds);
                }
                else
                {
                    lblResults.Text = "Please enter an interger larger than 59.";
                    lblResults.ForeColor = Color.Red;
                    lblResults.Visible = true;
                }



            }

        }
    }
}
