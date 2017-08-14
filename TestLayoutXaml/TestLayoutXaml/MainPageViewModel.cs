using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.ComTypes;

namespace TestLayoutXaml
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public MainPageViewModel()
        {
            this.LoadItems();
        }

        public ObservableCollection<Person> PersonList { get; set; }
        public IList<ListGroup<string, Person>> PersonGroups { get; set; }

        public void RemovePerson(Person person)
        {
            this.PersonList.Remove(person);
        }

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void LoadItems()
        {
            this.PersonList = new ObservableCollection<Person>
            {
                new Person { Name = "Steve", Age = 21, Country = "USA" },
                new Person { Name = "Raven", Age = 32, Country = "Iceland" },
                new Person { Name = "Carsten", Age = 28, Country = "Denmark" },
                new Person { Name = "John", Age = 32, Country = "England" },
                new Person { Name = "Tony", Age = 37, Country = "Ireland" },
                new Person { Name = "Tom", Age = 43, Country = "USA" },
                new Person { Name = "Nonni", Age = 12, Country = "Iceland" },
                new Person { Name = "Rikki", Age = 17, Country = "Iceland" },
                new Person { Name = "Sam", Age = 56, Country = "Australia" },
                new Person { Name = "Mary", Age = 32, Country = "Denmark" },
                new Person { Name = "Sue", Age = 39, Country = "Scotland" },
                new Person { Name = "Ellen", Age = 45, Country = "Sweden" },
                new Person { Name = "Amy", Age = 67, Country = "USA" },
                new Person { Name = "Andy", Age = 69, Country = "Canada" },
                new Person { Name = "Magnus", Age = 22, Country = "Norway" },
                new Person { Name = "Gary", Age = 19, Country = "Russia" },
                new Person { Name = "Anatoly", Age = 11, Country = "Russia" },
                new Person { Name = "Victor", Age = 99, Country = "Switzerland" },
                new Person { Name = "Robert", Age = 25, Country = "USA" }
            };

            this.PersonGroups = new EnumerableQuery<ListGroup<string, Person>>(
                this.PersonList.GroupBy(x => x.Country).Select(x => new ListGroup<string, Person>(x))).ToList();;
        }
    }
}
