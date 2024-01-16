using OrderManagementSystem.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace OrderManagementSystem.Views
{
    /// <summary>
    /// Interaction logic for AddMenuItemView.xaml
    /// </summary>
    public partial class AddMenuItemView : Window
    {
        public AddMenuItemView()
        {
            InitializeComponent();
            this.DataContext = new AddMenuItemViewModel(this);
        }
    }
}
