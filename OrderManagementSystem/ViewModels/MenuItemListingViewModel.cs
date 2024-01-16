using OrderManagementSystem.Commands;
using OrderManagementSystem.Models;
using OrderManagementSystem.Services;
using OrderManagementSystem.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Xml.Linq;

namespace OrderManagementSystem.ViewModels
{
    public class MenuItemListingViewModel
    {
        public ObservableCollection<MenuItem> MenuItems { get; set; }

        public ICommand AddMenuItemCommand { get; set; }

        public ICommand EditMenuItemCommand { get; set; }

        public ICommand DeleteMenuItemCommand { get; set; }


        public MenuItemListingViewModel()
        {
            MenuItems = MenuItemService.MenuItems;

            AddMenuItemCommand = new RelayCommand(ShowAddMenuItem, CanShowAddMenuItem);
            EditMenuItemCommand = new RelayCommand(ShowEditMenuItem, CanShowEditMenuItem);
            DeleteMenuItemCommand = new RelayCommand(ShowDeleteMenuItem, CanShowDeleteMenuItem);
        }

        private void ShowDeleteMenuItem(object obj)
        {
            MessageBoxResult result = MessageBox.Show("Are you sure you want to delete this item?", "Delete Menu Item", MessageBoxButton.OKCancel);
            if (result == MessageBoxResult.OK)
            {
                if (!Guid.TryParse(obj.ToString(), out Guid id))
                {
                    return;
                }
                 MenuItemService.DeleteMenuItem(id);
            }
        }

        private bool CanShowDeleteMenuItem(object obj)
        {
            return true;
        }

        private bool CanShowEditMenuItem(object obj)
        {
            return true;
        }

        private void ShowEditMenuItem(object name)
        {
            if(!Guid.TryParse(name.ToString(), out Guid result))
            {
                return;
            }
            MenuItem menuItem = MenuItemService.GetMenuItem(result);

            EditMenuItemView editMenuWindow = new(menuItem);
            editMenuWindow.Show();
        }

        private bool CanShowAddMenuItem(object obj)
        {
            return true;
        }

        private void ShowAddMenuItem(object obj)
        {
            AddMenuItemView addMenuItem = new();
            addMenuItem.Show();
        }
    }
}
