using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PDC03_MODULE04
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Activity02 : ContentPage
    {
        ObservableCollection<Employee> employees = new ObservableCollection<Employee> ();
        public ObservableCollection<Employee> Employees { get { return employees; } }
        public Activity02()
        {
            InitializeComponent();
            EmployeeView.ItemsSource = employees;
            employees.Add(new Employee { DisplayName = "Jello Mangune", Position = "President" });
            employees.Add(new Employee { DisplayName = "Bobby Marcko Cruz", Position = "Vice President" });
            employees.Add(new Employee { DisplayName = "Calvin Kent Pamandanan", Position = "Director" });
            employees.Add(new Employee { DisplayName = "Kane Erryl Castillano", Position = "Supervisor" });
        }
        private void AddItem(object sender, EventArgs e)
        {
            var menuItem = sender as MenuItem;
            if (menuItem != null)
            {

            }
        }
        private void EditItem(object sender, EventArgs e)
        {
            var menuItem = sender as MenuItem;
            if (menuItem != null)
            {

            }
        }
        private void DeleteItem(object sender, EventArgs e)
        {
            var menuItem = sender as MenuItem;
            if (menuItem != null)
            {

            }
        }
    }
}