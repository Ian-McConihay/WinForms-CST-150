/*
* Ian McConihay
* CST-150
* Milestone
* Sep 22 2024
* 
*/

using Milestone5.BusinessLayer.Models;
using System.Data;
using System.Text;

namespace Milestone5.BusinessLayer.Services
{
    public class InventoryService
    {
        // Hard-coded initial fantasy inventory
        private InventoryItem[] armoryInventory;

        public void LoadInventoryData(string filePath)
        {
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

        public DataTable PopulateDataGridView()
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

            return dataTable;

        }

        /// <summary>
        /// Increments Inventoryitems quantity 
        /// </summary>
        /// <param name="itemId"></param>
        /// <param name="incrementAmount"></param>
        public void IncrementInventory(int itemId, int incrementAmount)
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
        }

    }
}
