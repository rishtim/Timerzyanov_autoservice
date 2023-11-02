using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Логика взаимодействия для SignUpPage.xaml
    /// </summary>
    /// 

    public partial class SignUpPage : Page
    {

        private Service _currentService = new Service();
        public SignUpPage(Service SelectedService)
        {
            InitializeComponent();
            
            if (SelectedService != null)
                this._currentService = SelectedService;

            DataContext = _currentService;

            var _currentClient = Timerzyanov_autoserviceEntities.GetContext().Client.ToList();
            ComboClient.ItemsSource = _currentClient;
        }

        private ClientService _currentClientService = new ClientService();
        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();

            if(ComboClient.SelectedItem == null)
                    errors.AppendLine("Укажите ФИО клиента");

            if (StartDate.Text == "")
                errors.AppendLine("Укажите дату услуги");

            if (TBStart.Text == "")
                errors.AppendLine("Укажите время начало услуги");

            if(errors.Length>0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }

            _currentClientService.ClientID = ComboClient.SelectedIndex + 1;
            _currentClientService.ServiceID = _currentService.ID;
            _currentClientService.StartTime = Convert.ToDateTime(StartDate.Text + " " + TBStart.Text);
            if (_currentClientService.ID == 0)
                Timerzyanov_autoserviceEntities.GetContext().ClientService.Add(_currentClientService);

            try
            {
                Timerzyanov_autoserviceEntities.GetContext().SaveChanges();
                MessageBox.Show("Информация сохранена");
                Manager.MainFrame.GoBack();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void ComboClient_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void TBStart_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[0-9:]");
            //Match match = regex.Match(e.Text);
           
            /*if (!match.Success)
            {
                e.Handled = true;

            }*/
            if (!regex.IsMatch(e.Text))
                e.Handled = true;
            
                //e.Handled = regex.IsMatch(e.Text);
            }
        private void TBStart_TextChanged(object sender, TextChangedEventArgs e)
        {
            string s = TBStart.Text;
            if (s.Length < 5 || !s.Contains(':'))
                TBEnd.Text = "";
            else
            {
                Regex regex = new Regex("\\b[0-2]?\\d:[0-5]\\d\\b");
                if (!regex.IsMatch(s))
                {
                    MessageBox.Show("Введите корректное время начала!");
                    TBStart.Clear();
                }
                else
                {
                    string[] start = s.Split(new char[] { ':' });
                    int startHour = Convert.ToInt32(start[0].ToString()) * 60;
                    int startMin = Convert.ToInt32(start[1].ToString());

                    int sum = startHour + startMin + _currentService.Duration;

                    int EndHour = sum / 60;
                    int EndMin = sum % 60;
                    s = EndHour.ToString() + ":" + EndMin.ToString();
                    TBEnd.Text = s;
                }
            }
        }

        //private static readonly Regex TimeMask = new Regex("\b[0-2]?[0-9]:[0-5][0-9]\b");

        /*private static bool IsTextAllowed(string text)
        {
            return !TimeMask.IsMatch(text);
        }*/

        

        
    }
}
