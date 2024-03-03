using Pick_up_Point_App.Stores;
using Pick_up_Point_App.View;
using Pick_up_Point_App.ViewModel;
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

namespace Pick_up_Point_App
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            NavigationStore navigationStore = new NavigationStore();
            WindowTitleStore windowTitleStore = new WindowTitleStore();
            navigationStore.CurrentViedModel = new WelcomePageVM(navigationStore, windowTitleStore);
            DataContext = new MainVM(navigationStore, windowTitleStore);
        }
    }
}
