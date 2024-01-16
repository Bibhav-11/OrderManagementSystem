using OrderManagementSystem.Models;
using OrderManagementSystem.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagementSystem.Services
{
    public class MenuItemService
    {
        public static ObservableCollection<MenuItem> MenuItems = new ObservableCollection<MenuItem>()
        {
            new MenuItem(){ Name = "Chicken Momo", Price = 120.20m },
            new MenuItem(){ Name = "Chicken Pizza", Price = 180.80m },
            new MenuItem(){ Name = "Chicken Salami", Price = 180.80m },
        };


        public static void AddMenuItem(MenuItem menuItem)
        {
            MenuItems.Add(menuItem);
        }

        public static void UpdateMenuItem(MenuItem menuItem)
        {
            //Database operations
        }

        public static void DeleteMenuItem(Guid id)
        {
            var menuItem = MenuItems.FirstOrDefault(menuItem => menuItem.Id == id);
            if(menuItem != null)
            {
                MenuItems.Remove(menuItem);
            }
        }

        public static MenuItem GetMenuItem(Guid id)
        {
            return MenuItems.FirstOrDefault(x => x.Id == id);
        }
    }
}
