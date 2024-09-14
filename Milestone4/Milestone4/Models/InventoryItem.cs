using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milestone4.Models
{
    /// <summary>
    /// Items for the Inventory.
    /// </summary>
    public class InventoryItem
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int Damage { get; set; }
        public int Quantity { get; set; }
        public decimal Cost { get; set; }
        public double Weight { get; set; }

        /// <summary>
        /// /
        /// </summary>
        /// <param name="id">Inventory unique ID.</param>
        /// <param name="description">The Name of the item.</param>
        /// <param name="damage">How much the item deals in attack.</param>
        /// <param name="quantity">How many in stock of the item.</param>
        /// <param name="cost">How much the item cost.</param>
        /// <param name="weight">The item weight.</param>
        public InventoryItem(int id, string description, int damage, int quantity, decimal cost, double weight)
        {
            Id = id;
            Description = description;
            Damage = damage;
            Quantity = quantity;
            Cost = cost;
            Weight = weight;
        }
    }
}
