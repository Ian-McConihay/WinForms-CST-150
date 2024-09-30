/*
* Ian McConihay
* CST-150
* Activity 6
* Sep 29 2024
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
    }
}
