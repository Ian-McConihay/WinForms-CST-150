/*
* Ian McConihay
* CST-150
* Activity 7
* Oct 6 2024
* 
*/
using CST_150_ListTogv.BusinessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CST_150_ListTogv.BusinessLayer
{
    internal class Inventory
    {

        /// <summary>
        /// Read the inventory text file and return a list of type InvItems class.
        /// </summary>
        /// <param name="invItems"></param>
        /// <returns></returns>
        public List<InvItem> ReadInventory(List<InvItem> invItems)
        {
            string dirLoc = Application.StartupPath + "Data\\topic6.txt";

            using (var str = File.OpenText(dirLoc))
            {
                foreach(string line in File.ReadLines(dirLoc, Encoding.UTF8))
                {
                    string[] rowData = line.Split(", ");

                    invItems.Add(new InvItem(rowData[0].ToString().Trim(), rowData[1].ToString().Trim(), Convert.ToInt32(rowData[2])));
                }
                return invItems;
            }
        }

        /// <summary>
        /// Inc Inventory in the list and then return the updated list.
        /// </summary>
        /// <param name="invItems"></param>
        /// <param name="selectedRowIndex"></param>
        /// <returns></returns>
        public List<InvItem> IncQtyValue(List<InvItem> invItems, int selectedRowIndex)
        {
            int updateQty = ++invItems[selectedRowIndex].Qty;
            invItems[selectedRowIndex].Qty = updateQty;
            return invItems;
        }

        /// <summary>
        /// Search the item in the main inventory list and return the new search list
        /// </summary>
        /// <param name="invItems"></param>
        /// <param name="searchItem"></param>
        /// <param name="searchCriteria"></param>
        /// <returns></returns>
        public List<InvItem> SearchItem(List<InvItem> invItems, List<InvItem> invSearch, string searchCriteria)
        {
            invSearch.Clear();

            foreach(InvItem item in invItems)
            {
                if (item.Type.ToLower().Contains(searchCriteria.ToLower()))
                {
                    invSearch.Add(item);
                }
               
            }
            /*return invItems;*/ // The Activity says to return this list but that would return the original list
            return invSearch;
        }
    }
}
