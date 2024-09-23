/*
 * Ian McConihay
 * CST-150
 * Activity 5 Dice
 * Sep 22 2024
 * 
 */
using CST_150_Activity_5_Dice_Simulator.BusinessLayer;

namespace CST_150_Activity_5_Dice_Simulator
{
    /// <summary>
    /// Create an application that simulates rolling a PAIR of dice. 
    /// When the user clicks a button, the application should generate two random numbers, each in the range of 1 through 6, to represent the value of the dice. 
    /// Use PictureBox controls to display the dice. 
    /// (In the Student Sample Programs, in the Chap05 folder, you will find six images named Die1.bmp, Die2.bmp, Die3.bmp, Die4.bmp, Die5.bmp, and Die6.bmp that you can use in the PictureBoxes.)
    /// </summary>
    public partial class Form1 : Form
    {
        private Dice dice;
        private string imageFolderPath;

        public Form1()
        {
            InitializeComponent();
            dice = new Dice();
            imageFolderPath = @"C:\Users\nmcco\Desktop\CST-150\CST-150-Activity 5 Dice Simulator\CST-150-Activity 5 Dice Simulator\Img\"; // Set your image folder path

        }

        public void btnRollDice_Click(object sender, EventArgs e)
        {

            // Roll the dice using the Dice Class
            var (die1, die2) = dice.RollDice();

            string die1ImagePath = $"{imageFolderPath}die{die1}.png";
            string die2ImagePath = $"{imageFolderPath}die{die2}.png";

            //Check if images are null
            if (die1ImagePath == null || die2ImagePath == null)
            {
                MessageBox.Show("One of the images is not found.");
                return;
            }

            // Update PictureBox controls with the corresponding images
            picBoxDiceOne.Image = Image.FromFile(die1ImagePath);
            picBoxDiceTwo.Image = Image.FromFile(die2ImagePath);
            // Display the result
            lblResult.Text = $"You rolled a {die1} and a {die2}!";
            lblResult.Visible = true;
        }
    }
}
