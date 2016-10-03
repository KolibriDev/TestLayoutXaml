using System;
using Xamarin.Forms;

namespace TestLayoutXaml
{
    public class MainPageTemplateSelector : DataTemplateSelector
    {
        public DataTemplate PersonTemplate { get; set; }

        public DataTemplate SpinnerTemplate { get; set; }

        public DataTemplate SelectTemplate(ListItem item)
        {
            if (item == null)
            {
                return null;
            }

            switch (item.ItemType)
            {
                case ItemType.Spinner:
                    return this.SpinnerTemplate;
                case ItemType.Person:
                    return this.PersonTemplate;
                default:
                    throw new ArgumentException();
            }
        }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            return this.SelectTemplate((ListItem) item);
        }
    }
}