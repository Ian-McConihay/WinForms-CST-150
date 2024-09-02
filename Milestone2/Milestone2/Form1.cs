/*
 * Ian McConihay
 * CST-150
 * HelloWorldFormsApp
 * Sep 01 2024
 * 
 */

using System.Text;

namespace Milestone2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Event to display Inventory when clicked.
        /// </summary>
        /// <param name="sender">The source of the event, typically the button that was clicked.</param>
        /// <param name="e">An instance of <see cref="EventArgs"/> that contains no event data for this event.</param>
        private void btnShowInventory_Click(object sender, EventArgs e)
        {
            // Hard-coded initial fantasy inventory
            List<InventoryItem> armoryInventory = new List<InventoryItem>
            {
                new InventoryItem
                {
                    Id = 1,
                    Description = "Dragon Slayer Sword",
                    Damage = 150,
                    Quantity = 5,
                    Cost = 1200.00m,
                    Weight = 3.5
                },
                new InventoryItem
                {
                    Id = 2,
                    Description = "Elven Bow",
                    Damage = 85,
                    Quantity = 10,
                    Cost = 750.75m,
                    Weight = 1.2
                },
                new InventoryItem
                {
                    Id = 3,
                    Description = "Mystic Staff",
                    Damage = 100,
                    Quantity = 8,
                    Cost = 900.50m,
                    Weight = 2.0
                },
                new InventoryItem
                {
                    Id = 4,
                    Description = "Dwarven Axe",
                    Damage = 130,
                    Quantity = 4,
                    Cost = 1100.00m,
                    Weight = 4.0
                },
                new InventoryItem
                {
                    Id = 5,
                    Description = "Healing Potion",
                    Damage = 0, // Potions don't have damage
                    Quantity = 20,
                    Cost = 50.25m,
                    Weight = 0.5
                }
            };

            // Build the inventory display string
            StringBuilder sb = new StringBuilder();
            foreach (var item in armoryInventory)
            {
                sb.AppendLine($"ID: {item.Id}, Description: {item.Description}, Damage: {item.Damage}, Quantity: {item.Quantity}, Cost: {item.Cost}G, Weight: {item.Weight}lbs");
            }

            // Display the inventory in the Label
            lblInventory.Text = sb.ToString();
        }
    }
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
    }
}
