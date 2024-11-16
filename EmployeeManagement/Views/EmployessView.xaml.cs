using EmployeeManagement.Models;
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

namespace EmployeeManagement.Views
{
    /// <summary>
    /// Логика взаимодействия для EmployessView.xaml
    /// </summary>
    public partial class EmployessView : Window
    {
        public EmployessView()
        {
            InitializeComponent();
        }

        private void ListView_PrevieMouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var item = (sender as ListView).SelectedItem;

            if (item is null)
            {
                return;
            }
            var emploee = item as Employee;
            MessageBox.Show(
                $"Сотрудник: {emploee.LastName} {emploee.FirstName}\n" +
                $"Возраст: {emploee.Age}\n" +
                $"Должность: {emploee.Position}\n" +
                $"Копания: {emploee.CompanyName} ({emploee.CityName})");
        }

    }
}
