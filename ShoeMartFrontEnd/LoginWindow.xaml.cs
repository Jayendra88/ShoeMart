using ShoeMartFrontEnd.ViewModel;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ShoeMartFrontEnd
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : UserControl
    {
        LoginWindowViewModel viewModel;

        public LoginWindow()//
        {
            
            InitializeComponent();
        }

        private void BtnClicked(object sender, RoutedEventArgs e)
        {
            this.viewModel = (LoginWindowViewModel)DataContext;
            viewModel.LogIn();
        }
    }
}
