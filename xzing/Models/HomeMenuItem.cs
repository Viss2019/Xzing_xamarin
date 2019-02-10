using System;
using System.Collections.Generic;
using System.Text;

namespace xzing.Models
{
    public enum MenuItemType
    {
        ItemsDetail,
        Search
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
