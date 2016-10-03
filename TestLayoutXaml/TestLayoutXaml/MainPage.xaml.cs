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
            this.LoadItems();
            InitializeComponent();
        }

        public void OnDelete(object sender, EventArgs e)
        {
            // Do something
        }

        private void LoadItems()
        {
            this.ListItems = new List<ListItem>
            {
                new ListItem { Person = null, ItemType = ItemType.Spinner },
                new ListItem { Person = new Person { Name = "Steve", Age = 21, Country = "USA" }, ItemType = ItemType.Person },
                new ListItem { Person = new Person { Name = "Raven", Age = 32, Country = "Iceland" }, ItemType = ItemType.Person },
                new ListItem { Person = new Person { Name = "Carsten", Age = 28, Country = "Denmark" }, ItemType = ItemType.Person },
                new ListItem { Person = new Person { Name = "John", Age = 32, Country = "England" }, ItemType = ItemType.Person },
                new ListItem { Person = new Person { Name = "Tony", Age = 37, Country = "Ireland" }, ItemType = ItemType.Person },
                new ListItem { Person = new Person { Name = "Tom", Age = 43, Country = "USA" }, ItemType = ItemType.Person },
                new ListItem { Person = new Person { Name = "Nonni", Age = 12, Country = "Iceland" }, ItemType = ItemType.Person },
                new ListItem { Person = new Person { Name = "Rikki", Age = 17, Country = "Iceland" }, ItemType = ItemType.Person },
                new ListItem { Person = new Person { Name = "Sam", Age = 56, Country = "Australia" }, ItemType = ItemType.Person },
                new ListItem { Person = new Person { Name = "Mary", Age = 32, Country = "Denmark" }, ItemType = ItemType.Person },
                new ListItem { Person = new Person { Name = "Sue", Age = 39, Country = "Scotland" }, ItemType = ItemType.Person },
                new ListItem { Person = new Person { Name = "Ellen", Age = 45, Country = "Sweden" }, ItemType = ItemType.Person },
                new ListItem { Person = new Person { Name = "Amy", Age = 67, Country = "USA" }, ItemType = ItemType.Person },
                new ListItem { Person = new Person { Name = "Andy", Age = 69, Country = "Canada" }, ItemType = ItemType.Person },
                new ListItem { Person = new Person { Name = "Magnus", Age = 22, Country = "Norway" }, ItemType = ItemType.Person },
                new ListItem { Person = new Person { Name = "Gary", Age = 19, Country = "Russia" }, ItemType = ItemType.Person },
                new ListItem { Person = new Person { Name = "Anatoly", Age = 11, Country = "Russia" }, ItemType = ItemType.Person },
                new ListItem { Person = new Person { Name = "Victor", Age = 99, Country = "Switzerland" }, ItemType = ItemType.Person },
                new ListItem { Person = new Person { Name = "Robert", Age = 25, Country = "USA" }, ItemType = ItemType.Person },
            };
        }

        public List<ListItem> ListItems { get; set; } 
    }
}
