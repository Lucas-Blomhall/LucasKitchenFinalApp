﻿using LucasWpfFinalApp.Helpers;
using LucasWpfFinalApp.MVVM.ViewModels;
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

namespace LucasWpfFinalApp.MVVM.Components
{
    /// <summary>
    /// Interaction logic for MenuComponent.xaml
    /// </summary>
    
    public partial class MenuComponent : UserControl
    {
        private readonly NavigationStore _navigationStore;
        public MenuComponent()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
