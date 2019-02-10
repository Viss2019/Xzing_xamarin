using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using xzing.Models;

namespace xzing.Services
{
    public class MockDataStore : IDataStore<Item>
    {
        List<Item> items;

        public MockDataStore()
        {
            items = new List<Item>();
            var mockItems = new List<Item>
            {
                new Item { Id = "First_image", Name = "First item", ImageSource = "First_image", BarCodeSource = "First_bar" },
                new Item { Id = "Second_image", Name = "Second item", ImageSource = "Second_image", BarCodeSource = "Second_bar" },
                new Item { Id = "Third_image", Name = "Third item", ImageSource = "Third_image", BarCodeSource = "Third_bar" },
                new Item { Id = "Fourth_image", Name = "Fourth item", ImageSource = "Fourth_image", BarCodeSource = "Fourth_bar" },
                new Item { Id = "Fifth_image", Name = "Fifth item", ImageSource = "Fifth_image", BarCodeSource = "Fifth_bar" },
                new Item { Id = "Sixth_image", Name = "Sixth item", ImageSource = "Sixth_image", BarCodeSource = "Sixth_bar" }, 
            };

            foreach (var item in mockItems)
            {
                items.Add(item);
            }
        }

        public async Task<bool> AddItemAsync(Item item)
        {
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(Item item)
        {
            var oldItem = items.Where((Item arg) => arg.Id == item.Id).FirstOrDefault();
            items.Remove(oldItem);
            items.Add(item);

            return await Task.FromResult(true);
        }

       

        public async Task<Item> GetItemAsync(string id)
        {
            return await Task.FromResult(items.FirstOrDefault(s => s.Id == id));
        }



        public async Task<IEnumerable<Item>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(items);
        }
    }
}