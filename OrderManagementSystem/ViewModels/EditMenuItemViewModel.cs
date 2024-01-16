using OrderManagementSystem.Commands;
using OrderManagementSystem.Models;
using OrderManagementSystem.Services;
using OrderManagementSystem.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace OrderManagementSystem.ViewModels
{
    public class EditMenuItemViewModel
    {
        private readonly EditMenuItemView editMenuWindow;

        public MenuItem MenuItem { get; set; }

        public ICommand UpdateMenuItemCommand { get; set; }

        public EditMenuItemViewModel(MenuItem menuItem, EditMenuItemView editMenuWindow)
        {
            MenuItem = menuItem;
            this.editMenuWindow = editMenuWindow;
            UpdateMenuItemCommand = new RelayCommand(UpdateMenuItem, CanUpdateMenuItem);
        }

        private void UpdateMenuItem(object obj)
        {
            //Database operations
            //var updatedMenuItem = (EditMenuItemViewModel)obj;
            //MenuItemService.UpdateMenuItem(updatedMenuItem.MenuItem);

            editMenuWindow.Close();
        }

        private bool CanUpdateMenuItem(object obj)
        {
            return true;
        }
    }
}
