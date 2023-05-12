using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PDC03_MODULE04
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Activity05 : ContentPage
    {
        List<Contacts> contacts;
        public Activity05()
        {
            InitializeComponent();
            SetUpData();
            listView.ItemsSource = contacts;
        }
        void SetUpData()
        {
            contacts = new List<Contacts>();
            contacts.Add(new Contacts
            {
                Name = "Jello P. Mangune",
                Age=21,
                Occupation = "Programmer",
                Country = "Philippines"
            });
            contacts.Add(new Contacts
            {
                Name = "Bobby M. Cruz",
                Age = 21,
                Occupation = "Analyst",
                Country = "China"
            });
            contacts.Add(new Contacts
            {
                Name = "Calvin K. Pamandanan",
                Age = 21,
                Occupation = "Software Engineer",
                Country = "Canada"
            });
            contacts.Add(new Contacts
            {
                Name = "Kane Castillano",
                Age = 20,
                Occupation = "Cloud Engineer",
                Country = "Russia"
            });
            contacts.Add(new Contacts
            {
                Name = "Karylle Lopez",
                Age = 20,
                Occupation = "Front End Engineer",
                Country = "South Korea"
            });
        }
        async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (listView.SelectedItem != null)
            {
                var detailPage = new DataPage();
                detailPage.BindingContext = e.SelectedItem as Contacts;
                listView.SelectedItem = null;
                await Navigation.PushModalAsync(detailPage);
            }
        }
    }
}