using ARMDel.Presentation.ViewModel;
using System;
using System.Windows;

namespace ARMDel.Presentation.View
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class AuthorizationWindow : Window
    {
        public AuthorizationWindow()
        {
            InitializeComponent();
            DataContext = new AuthorizationViewModel();
        }
    }
}
