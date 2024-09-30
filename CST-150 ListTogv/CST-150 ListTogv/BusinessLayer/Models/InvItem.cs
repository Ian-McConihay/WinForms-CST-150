/*
* Ian McConihay
* CST-150
* Activity 6
* Sep 29 2024
* 
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CST_150_ListTogv.BusinessLayer.Models
{
    /// <summary>
    /// Structure for inventory items.
    /// </summary>
    internal class InvItem
    {
        public string Type { get; set; }
        public string Color { get; set; }
        public int Qty { get; set; }

        /// <summary>
        /// Parameterized Constructor.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="color"></param>
        /// <param name="qty"></param>
        public InvItem(string type, string color, int qty)
        {
            Type = type;
            Color = color;
            Qty = qty;
        }
    }
}
