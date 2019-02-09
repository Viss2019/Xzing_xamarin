using System;

namespace xzing.Models
{
    public class Item
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string ImageSource { get; set; }
        public string BarCodeSource  { get; set; }
    }
}