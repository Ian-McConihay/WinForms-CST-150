/*
* Ian McConihay
* CST-150
* HelloWorldFormsApp
* Sep 15 2024
* 
*/

using Milestone4.Models;
using System;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace Milestone4
{
    public partial class Form1 : Form
    {
        // Hard-coded initial fantasy inventory
        private InventoryItem[] armoryInventory;

        public Form1()
        {
            InitializeComponent();
            LoadInventoryData();
            PopulateDataGridView();
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
            IncrementInventory(int.Parse(txtBoxIncQty.Text), int.Parse(txtBoxQty.Text));
        }

        private void LoadInventoryData()
        {
            string filePath = "C:\\Users\\nmcco\\Desktop\\CST-150\\Milestone3\\Milestone3\\bin\\Debug\\net8.0-windows\\Data\\Inventory.txt"; // Ensure this path is correct

            try
            {
                // Read all lines from the file
                string[] lines = File.ReadAllLines(filePath, Encoding.UTF8);
                if (lines.Length == 0)
                {
                    MessageBox.Show("The inventory file is empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                // Initialize the array with the correct size
                armoryInventory = new InventoryItem[lines.Length];

                for (int i = 0; i < lines.Length; i++)
                {
                    string line = lines[i];
                    string[] parts = line.Split(',');

                    if (parts.Length == 6)
                    {
                        int id = int.Parse(parts[0]);
                        string description = parts[1];
                        int damage = int.Parse(parts[2]);
                        int quantity = int.Parse(parts[3]);
                        decimal cost = decimal.Parse(parts[4]);
                        double weight = double.Parse(parts[5]);

                        armoryInventory[i] = new InventoryItem(id, description, damage, quantity, cost, weight);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading inventory data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PopulateDataGridView()
        {
            // Create a DataTable to hold the data
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Id", typeof(int));
            dataTable.Columns.Add("Description", typeof(string));
            dataTable.Columns.Add("Damage", typeof(int));
            dataTable.Columns.Add("Quantity", typeof(int));
            dataTable.Columns.Add("Cost", typeof(decimal));
            dataTable.Columns.Add("Weight", typeof(double));

            // Populate the DataTable with data from the array
            foreach (var item in armoryInventory)
            {
                DataRow row = dataTable.NewRow();
                row["Id"] = item.Id;
                row["Description"] = item.Description;
                row["Damage"] = item.Damage;
                row["Quantity"] = item.Quantity;
                row["Cost"] = item.Cost;
                row["Weight"] = item.Weight;
                dataTable.Rows.Add(row);
            }

            // Bind the DataTable to the DataGridView
            dataGridViewInventory.DataSource = dataTable;
            dataGridViewInventory.Visible = false;
        }

        /// <summary>
        /// Increments Inventoryitems quantity 
        /// </summary>
        /// <param name="itemId"></param>
        /// <param name="incrementAmount"></param>
        private void IncrementInventory(int itemId, int incrementAmount)
        {
            if (armoryInventory == null || armoryInventory.Length == 0)
            {
                MessageBox.Show("Inventory data is not loaded.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Find the item with the specified ID
            InventoryItem itemToUpdate = Array.Find(armoryInventory, item => item.Id == itemId);

            if (itemToUpdate == null)
            {
                MessageBox.Show($"Item with ID {itemId} not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Update the quantity
            itemToUpdate.Quantity += incrementAmount;

            // Refresh the DataGridView
            PopulateDataGridView();
            dataGridViewInventory.Visible = true;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
