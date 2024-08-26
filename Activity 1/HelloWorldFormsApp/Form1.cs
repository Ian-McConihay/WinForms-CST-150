/*
 * Ian McConihay
 * CST-150
 * HelloWorldFormsApp
 * Aug 2024
 * 
 */
namespace HelloWorldFormsApp
{
    public partial class Form1 : Form
    {

        // Boolean flag to track the visibility of the label text
        private bool isTextVisible = false;

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Create an event handler for the click here button
        /// Method name must be PascalCasing
        /// </summary>
        /// <param name="sender">The source of the event, typically the button that was clicked.</param>
        /// <param name="e">An instance of <see cref="EventArgs"/> that contains no event data for this event.</param>
        private void ButtonOnClick(object sender, EventArgs e)
        {
            // Toggle the boolean flag
            isTextVisible = !isTextVisible;

            // Update the label's text based on the flag
            if (isTextVisible)
            {
                lblHelloWoldLabel.Text = "Ian McConihay";
            }
            else
            {
                lblHelloWoldLabel.Text = string.Empty; // Clear the text
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
