using System.Collections.Generic;
using System.Linq;

namespace TestLayoutXaml
{
    public class ListGroup<TKey, T> : List<T>
    {
        public ListGroup(IGrouping<TKey, T> group)
            : base(group)
        {
            this.Key = group.Key;
        }

        /// <summary>
        /// Gets or sets the key for the group.
        /// </summary>
        public TKey Key
        {
            get; set;
        }
    }
}
