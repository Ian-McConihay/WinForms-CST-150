/*
 * Ian McConihay
 * CST-150
 * Activity 5 
 * Sep 22 2024
 * 
 */
using CST_150_DogClass.BusinessLayer;

namespace CST_150_DogClass
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            lblErrorMessage.Visible = false;
        }

        /// <summary>
        /// Click event to add a new dog.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAddNewDog_ClickEvent(object sender, EventArgs e)
        {
            var bill = txtName.Text;
            var combobox = cmbSit.SelectedItem;
            //Test Dog
            Dog ginger = new Dog("Ginger", 12.24, "Golden Cream", 57.25, false);
            var name = ginger.Name;
            var color = ginger.Color;
            //End Test Dog

            bool isVaildEntries = true;
            double weight = 0.00D, neckRad = 0.00D, neckCircum = 0.00D;
            bool isValid = false;

            lblErrorMessage.Visible = false;

            Utility utility = new Utility();

            if (!double.TryParse(txtNeck.Text, out neckRad))
            {
                MessageBox.Show("Please enter a valid number for Neck Radius.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Try to parse weight
            if (!double.TryParse(txtWeight.Text, out weight))
            {
                MessageBox.Show("Please enter a valid number for Weight.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (isVaildEntries)
            {
                //This is not going to work when adding a Dog. neckRad and weight need to be set up like txtName and txtColor.
                Dog dogObject = new Dog(txtName.Text, neckRad, txtColor.Text, weight, utility.ConvertToBool(cmbSit.Text));
                gvShowDogs.Rows.Add(dogObject.Name, dogObject.CalCircumference(), dogObject.Sit,  dogObject.CalWeight(), dogObject.Color);
            }
            else
            {
                lblErrorMessage.Visible = true;
            }
        }

        /// <summary>
        /// Creates the column names for the dataGridView.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMainLoadEventHandler(object sender, EventArgs e)
        {
            gvShowDogs.ColumnCount = 5;
            gvShowDogs.Columns[0].Name = "Name";
            gvShowDogs.Columns[1].Name = "Neck Circum";
            gvShowDogs.Columns[2].Name = "Sitting";
            gvShowDogs.Columns[3].Name = "Weight";
            gvShowDogs.Columns[4].Name = "Color";

            gvShowDogs.Columns[1].DefaultCellStyle.Format = "#.00";
            gvShowDogs.Columns[3].DefaultCellStyle.Format = "#.00";


        }

    }
}
