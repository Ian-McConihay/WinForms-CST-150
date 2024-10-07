/*
* Ian McConihay
* CST-150
* Milestone 7
* Oct 6 2024
* 
*/


using CST_150_ListTogv.PresentationLayer;
using Milestone7.BusinessLayer.Controllers;
using Milestone7.BusinessLayer.Models;

namespace Milestone7
{
    public partial class MainFrm : Form
    {
        private InventoryService inventoryService;

        /// <summary>
        /// List that will hold all items found for search
        /// </summary>
        List<InventoryItem> invSearch = new List<InventoryItem>();

        public MainFrm()
        {

            InitializeComponent();
            inventoryService = new InventoryService(this);
            LoadData();
        }

        /// <summary>
        /// Clearing the Binding by setting the DataSource to null removes any existing data binding. 
        /// This unhooks the DataGridView from its current data source, allowing a reset.
        /// </summary>
        public void LoadData()
        {
            dataGridViewInventory.DataSource = null;
            dataGridViewInventory.DataSource = inventoryService.GetInventoryList();
        }

        /// <summary>
        /// EVent to add new item to inventory list.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            var item = new InventoryItem
            {
                Description = txtDescription.Text,
                Damage = int.Parse(txtDamage.Text),
                Quantity = int.Parse(txtQuantity.Text),
                Cost = decimal.Parse(txtCost.Text),
                Weight = double.Parse(txtWeight.Text)
            };
            inventoryService.AddItem(item);
            LoadData();
        }

        /// <summary>
        /// event for updating item selected row with textboxes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridViewInventory.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a row to update.");
                return;
            }
            var selectedItem = dataGridViewInventory.SelectedRows[0].DataBoundItem as InventoryItem;
            if (selectedItem != null)
            {
                // Update only if the textbox is not empty or valid
                if (!string.IsNullOrEmpty(txtDescription.Text))
                {
                    selectedItem.Description = txtDescription.Text;
                }

                if (int.TryParse(txtDamage.Text, out int damage))
                {
                    selectedItem.Damage = damage;
                }

                if (int.TryParse(txtQuantity.Text, out int quantity))
                {
                    selectedItem.Quantity = quantity;
                }

                if (decimal.TryParse(txtCost.Text, out decimal cost))
                {
                    selectedItem.Cost = cost;
                }

                if (double.TryParse(txtWeight.Text, out double weight))
                {
                    selectedItem.Weight = weight;
                }
                inventoryService.UpdateItem(selectedItem);
                LoadData();
            }
        }

        /// <summary>
        /// Event to delete selected row.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            var selectedItem = dataGridViewInventory.SelectedRows[0].DataBoundItem as InventoryItem;
            if (selectedItem != null)
            {
                inventoryService.DeleteItem(selectedItem);
                LoadData();
            }
        }

        /// <summary>
        /// Search box for filtering description name to text box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            // Get the search term from the TextBox and convert it to lower case
            string searchTerm = searrchTxtBx.Text.ToLower();

            // Check if the search term is empty
            if (string.IsNullOrEmpty(searchTerm))
            {
                LoadData();
            }
            else
            {
                // Filter the original list based on the search term using LINQ
                var filteredList = inventoryService.GetInventoryList().Where(p => p.Description.ToLower().Contains(searchTerm)).ToList();

                // Update the BindingSource with the filtered list
                dataGridViewInventory.DataSource = filteredList;
            }
        }

        /// <summary>
        /// Sort method.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewInventory_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string strColumnName = dataGridViewInventory.Columns[e.ColumnIndex].Name;
            SortOrder strSortOrder = getSortOrder(e.ColumnIndex);
            List<InventoryItem> compareList;
            compareList = inventoryService.GetInventoryList();

            if (strSortOrder == SortOrder.Ascending)
            {
                compareList = compareList.OrderBy(x => typeof(InventoryItem).GetProperty(strColumnName).GetValue(x, null)).ToList();
            }
            else
            {
                compareList = compareList.OrderByDescending(x => typeof(InventoryItem).GetProperty(strColumnName).GetValue(x, null)).ToList();
            }
            dataGridViewInventory.DataSource = compareList;
            dataGridViewInventory.Columns[e.ColumnIndex].HeaderCell.SortGlyphDirection = strSortOrder;
        }

        /// <summary>
        /// Gets the current order of column to be sorted.
        /// </summary>
        /// <param name="columnIndex"></param>
        /// <returns></returns>
        private SortOrder getSortOrder(int columnIndex)
        {
            if (dataGridViewInventory.Columns[columnIndex].HeaderCell.SortGlyphDirection == SortOrder.None ||
                dataGridViewInventory.Columns[columnIndex].HeaderCell.SortGlyphDirection == SortOrder.Descending)
            {
                dataGridViewInventory.Columns[columnIndex].HeaderCell.SortGlyphDirection = SortOrder.Ascending;
                return SortOrder.Ascending;
            }
            else
            {
                dataGridViewInventory.Columns[columnIndex].HeaderCell.SortGlyphDirection = SortOrder.Descending;
                return SortOrder.Descending;
            }
        }

        /// <summary>
        /// Search event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSearch_ClickEvent(object sender, EventArgs e)
        {
            string searchFor = txtSearch.Text;
            var invItems = inventoryService.GetInventoryList();

            invSearch = inventoryService.SearchItem(invItems, invSearch, searchFor);

            SearchFrm searchFrm = new SearchFrm(invSearch);

            searchFrm.ShowDialog();

        }

    }
}
