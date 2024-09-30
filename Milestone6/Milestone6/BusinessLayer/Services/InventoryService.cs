/*
* Ian McConihay
* CST-150
* Milestone
* Sep 29 2024
* 
*/

namespace Milestone6.BusinessLayer.Controllers
{
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using Milestone6.BusinessLayer.Models;
    using static System.Net.Mime.MediaTypeNames;
    using static System.Runtime.InteropServices.JavaScript.JSType;

    public class InventoryService
    {
        private readonly Form1 _view;
        private List<InventoryItem> inventoryList;
        private string _filePath = "C:\\Users\\nmcco\\Desktop\\CST-150\\Milestone3\\Milestone3\\bin\\Debug\\net8.0-windows\\Data\\Inventory.txt";

        public InventoryService(Form1 view)
        {
            _view = view;
            LoadData();
        }

        /// <summary>
        /// Gets the inventory returned as the list.
        /// </summary>
        /// <returns></returns>
        public List<InventoryItem> GetInventoryList()
        {
            return inventoryList;
        }

        /// <summary>
        /// Sets the Id of the new item. If the list has existing items, it sets the ID to the maximum existing ID plus one. If the list is empty, it starts with ID 1.
        /// </summary>
        /// <param name="item"></param>
        public void AddItem(InventoryItem item)
        {
            item.Id = inventoryList.Any() ? inventoryList.Max(i => i.Id) + 1 : 1;

            // Add Item: Adds the new item to the inventoryList.
            inventoryList.Add(item);

            // Save Data: Calls SaveData() to persist the updated list to the text file.
            SaveData();
        }

        /// <summary>
        /// Updates the item slected with input values.
        /// </summary>
        /// <param name="item"></param>
        public void UpdateItem(InventoryItem item)
        {
            var existingItem = inventoryList.FirstOrDefault(i => i.Id == item.Id);
            if (existingItem != null)
            {
                existingItem.Description = item.Description;
                existingItem.Damage = item.Damage;
                existingItem.Quantity = item.Quantity;
                existingItem.Cost = item.Cost;
                existingItem.Weight = item.Weight;
                SaveData();
            }
        }

        /// <summary>
        /// Removes selected list item.
        /// </summary>
        /// <param name="item"></param>
        public void DeleteItem(InventoryItem item)
        {
            inventoryList.Remove(item);
            SaveData();
        }

        /// <summary>
        /// Breaks down text file rows into parts for inventory list.
        /// </summary>
        private void LoadData()
        {
            inventoryList = new List<InventoryItem>();
            if (File.Exists(_filePath))
            {
                var lines = File.ReadAllLines(_filePath);
                inventoryList = lines.Select(line =>
                {
                    var parts = line.Split(',');
                    return new InventoryItem
                    {
                        Id = int.Parse(parts[0]),
                        Description = parts[1],
                        Damage = int.Parse(parts[2]),
                        Quantity = int.Parse(parts[3]),
                        Cost = decimal.Parse(parts[4]),
                        Weight = double.Parse(parts[5])
                    };
                }).ToList();
            }
        }

        /// <summary>
        /// Writes all line changes into text file.
        /// </summary>
        private void SaveData()
        {
            var lines = inventoryList.Select(item =>
                $"{item.Id},{item.Description},{item.Damage},{item.Quantity},{item.Cost},{item.Weight}");
            File.WriteAllLines(_filePath, lines);
        }
    }
}
