/*
* Ian McConihay
* CST-150
* Milestone 7
* Oct 6 2024
* 
*/

using Milestone7.BusinessLayer.Models;

namespace CST_150_ListTogv.PresentationLayer
{
    public partial class SearchFrm : Form
    {
        // Class level List
        List<InventoryItem> mySearch = new List<InventoryItem>();

        public SearchFrm(List<InventoryItem> invSearch)
        {
            InitializeComponent();

            this.mySearch = invSearch;
        }

        /// <summary>
        /// When the form is loaded populate the gird
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmLoad_EventHandler(object sender, EventArgs e)
        {
            gvSearchResults.DataSource = this.mySearch;
        }
        
        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
