using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TestLayoutXaml
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            this.LoadPersons();
            this.lstView.ItemsSource = this.Persons;
        }

        public void OnDelete(object sender, EventArgs e)
        {
            // Do something
        }

        private void LoadPersons()
        {
            this.Persons = new List<Person>
                             {
                                 new Person() { Name = "Steve", Age = 21, Country = "USA" },
                                 new Person() { Name = "Raven", Age = 32, Country = "Iceland" },
                                 new Person() { Name = "Carsten", Age = 28, Country = "Denmark" }

                             };
        }

        public List<Person> Persons { get; set; }
    }
}
