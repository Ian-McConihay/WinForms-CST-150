/*
* Ian McConihay
* CST-150
* Activity 7
* Oct 6 2024
* 
*/
using CST_150_ListTogv.BusinessLayer;
using CST_150_ListTogv.BusinessLayer.Models;
using CST_150_ListTogv.PresentationLayer;

namespace CST_150_ListTogv
{
    public partial class FrmInventory : Form
    {
        /// <summary>
        /// Reference variable ofr the master inventory.
        /// </summary>
        List<InvItem> invItems = new List<InvItem>();

        /// <summary>
        /// List that will hold all items found for search
        /// </summary>
        List<InvItem> invSearch = new List<InvItem>();

        private int SelectedGridIndex { get; set; }

        public FrmInventory()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Binds data grid.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PopulateGrid_LoadEventHandler(object sender, EventArgs e)
        {
            Inventory readInv = new Inventory();
            invItems = readInv.ReadInventory(invItems);

            gvInv.DataSource = null;
            gvInv.DataSource = invItems;

            foreach (DataGridViewColumn column in gvInv.Columns)
            {
                switch (column.Index)
                {
                    case 0:
                        column.HeaderText = "Bunny Type";
                        break;
                    case 1:
                        column.HeaderText = "Bunny Color";
                        break;
                    case 2:
                        column.HeaderText = "Quantity";
                        //  column.DefaultCellStyle.Format = "NO";
                        column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                        break;
                    default:
                        MessageBox.Show("Invalid column was trying to be accessed!");
                        break;

                }
            }
        }

        /// <summary>
        /// Event Handler to manage click events of Data grid view.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GridView_ClickEventHandler(object sender, EventArgs e)
        {
            //var testing = "test";

            //Get selected row
            SelectedGridIndex = gvInv.CurrentRow.Index;

        }

        /// <summary>
        /// Event handler to increment a quantity
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnIncQty_ClickEventHandler(object sender, EventArgs e)
        {
            Inventory invQty = new Inventory();
            invItems = invQty.IncQtyValue(invItems, SelectedGridIndex);
            gvInv.Refresh();

        }

        /// <summary>
        /// Delete an Item from inventory
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnDeleteItem_EventHandler(object sender, EventArgs e)
        {
            invItems.RemoveAt(SelectedGridIndex);
            gvInv.DataSource = null;
            gvInv.DataSource = invItems;

        }

        /// <summary>
        /// Search event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSearch_ClickEvent(object sender, EventArgs e)
        {
            string searchFor = txtSearch.Text;
            Inventory businessLayer = new Inventory();

            invSearch = businessLayer.SearchItem(invItems, invSearch, searchFor);

            FrmSecondary frmSecondary = new FrmSecondary(invSearch);

            frmSecondary.ShowDialog();

        }
    }
}
