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
    public class AddMenuItemViewModel
    {
        private readonly AddMenuItemView addMenuView;

        public MenuItem MenuItem { get; set; }
        public ICommand AddMenuItemCommand { get; set; }

        public AddMenuItemViewModel(AddMenuItemView addMenuView)
        {
            MenuItem = new MenuItem();
            AddMenuItemCommand = new RelayCommand(AddMenuItem, CanAddMenuItem);
            this.addMenuView = addMenuView;
        }

        private bool CanAddMenuItem(object obj)
        {
            return true;
        }

        private void AddMenuItem(object obj)
        {
            MenuItemService.AddMenuItem(MenuItem);
            addMenuView.Close();
        }
    }
}
