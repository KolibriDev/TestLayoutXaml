namespace TestLayoutXaml
{
    /// <summary>
    /// Enum for type of item
    /// </summary>
    public enum ItemType { Spinner, Person};

    /// <summary>
    /// ListItem class, contain group, account and creditcard.
    /// </summary>
    public class ListItem
    {
        /// <summary>
        /// Gets or sets the person of the list item.
        /// </summary>
        public Person Person { get; set; }

        /// <summary>
        /// Gets or sets the item type
        /// </summary>
        public ItemType ItemType { get; set; }
    }
}
