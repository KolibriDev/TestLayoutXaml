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
            this.BindingContext = new MainPageViewModel();
            InitializeComponent();
        }

        public void OnDelete(object sender, EventArgs e)
        {
            var mi = (MenuItem)sender;
            var thePerson = (Person)mi.CommandParameter;

            var vm = (MainPageViewModel) this.BindingContext;
            vm.RemovePerson(thePerson);
        }
    }
}
