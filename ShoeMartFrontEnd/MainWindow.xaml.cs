﻿using FirstFloor.ModernUI.Windows.Controls;
using ShoeMartBusiness.Interfaces;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : ModernWindow 
    {
        MainWindowViewModel viewModel;
        LoginWindowViewModel loginViewModel;

        public MainWindow(MainWindowViewModel viewModel, LoginWindowViewModel loginViewModel)
        {
            this.viewModel = viewModel;
            this.loginViewModel = loginViewModel;

            InitializeComponent();

            LoginView.DataContext = loginViewModel;
            //Log();
            //jay
        }

        
    }
}
