/*
* Ian McConihay
* CST-150
* Milestone
* Sep 22 2024
* 
*/

using Milestone5.BusinessLayer.Services;
using System.Data;

namespace Milestone5
{
    public partial class Form1 : Form
    {
        string filePath = "C:\\Users\\nmcco\\Desktop\\CST-150\\Milestone3\\Milestone3\\bin\\Debug\\net8.0-windows\\Data\\Inventory.txt"; // Ensure this path is correct
        InventoryService inventoryService;
        public Form1()
        {
            InitializeComponent();
            LoadInventoryData();

        }

        /// <summary>
        /// Event to display Inventory when clicked.
        /// </summary>
        /// <param name="sender">The source of the event, typically the button that was clicked.</param>
        /// <param name="e">An instance of <see cref="EventArgs"/> that contains no event data for this event.</param>
        private void btnShowInventory_Click(object sender, EventArgs e)
        {
            dataGridViewInventory.Visible = true;

        }

        /// <summary>
        /// Event to increment quantity when clicked.
        /// </summary>
        /// <param name="sender">The source of the event, typically the button that was clicked.</param>
        /// <param name="e">An instance of <see cref="EventArgs"/> that contains no event data for this event.</param>
        private void btnIncrement_Click(object sender, EventArgs e)
        {
            var inventoryService = new InventoryService();
            inventoryService.LoadInventoryData(filePath);
            inventoryService.IncrementInventory(int.Parse(txtBoxIncQty.Text), int.Parse(txtBoxQty.Text));
            DataTable inventoryData = inventoryService.PopulateDataGridView();
            dataGridViewInventory.DataSource = inventoryData;

        }


        private void LoadInventoryData()
        {
            var inventoryService = new InventoryService();
            inventoryService.LoadInventoryData(filePath);

            // Populate the DataGridView
            DataTable inventoryData = inventoryService.PopulateDataGridView();
            dataGridViewInventory.DataSource = inventoryData;
            dataGridViewInventory.Visible = true; // Show the DataGridView
        }
    }
}
