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

namespace Timerzyanov_autoservice
{
    /// <summary>
    /// Логика взаимодействия для ServicePage.xaml
    /// </summary>
    public partial class ServicePage : Page
    {
        public ServicePage()
        {
            InitializeComponent();
            var currentServices = Timerzyanov_autoserviceEntities.GetContext().Service.ToList();
            ServiceListView.ItemsSource = currentServices;

            ComboType.SelectedIndex = 0;

            UpdateServices();
        }

        private void UpdateServices()
        {
            var CurrentServices = Timerzyanov_autoserviceEntities.GetContext().Service.ToList();

            if (ComboType.SelectedIndex==0)
            {
                CurrentServices = CurrentServices.Where(p => (p.Discount >= 0 && p.Discount <= 100)).ToList();
            }
            if (ComboType.SelectedIndex==1)
            {
                CurrentServices = CurrentServices.Where(p => (p.Discount >= 0 && p.Discount < 5)).ToList();
            }
            if (ComboType.SelectedIndex == 2)
            {
                CurrentServices = CurrentServices.Where(p => (p.Discount >= 5 && p.Discount < 15)).ToList();
            }
            if (ComboType.SelectedIndex == 3)
            {
                CurrentServices = CurrentServices.Where(p => (p.Discount >= 15 && p.Discount < 30)).ToList();
            }
            if (ComboType.SelectedIndex == 4)
            {
                CurrentServices = CurrentServices.Where(p => (p.Discount >= 30 && p.Discount < 70)).ToList();
            }
            if (ComboType.SelectedIndex == 5)
            {
                CurrentServices = CurrentServices.Where(p => (p.Discount >= 70 && p.Discount <= 100)).ToList();
            }


            CurrentServices = CurrentServices.Where(p => p.Title.ToLower().Contains(TBoxSearch.Text.ToLower())).ToList();

            if(RButtonDown.IsChecked.Value)
            {
                CurrentServices = CurrentServices.OrderByDescending(p => p.Cost).ToList();
            }

            if(RButtonUp.IsChecked.Value)
            {
                CurrentServices = CurrentServices.OrderBy(p => p.Cost).ToList();
            }

            ServiceListView.ItemsSource = CurrentServices;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new AddEditPage());
        }

        private void TBoxSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            UpdateServices();
        }

        private void ComboType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateServices();
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            UpdateServices();
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            UpdateServices();
        }
    }
}
