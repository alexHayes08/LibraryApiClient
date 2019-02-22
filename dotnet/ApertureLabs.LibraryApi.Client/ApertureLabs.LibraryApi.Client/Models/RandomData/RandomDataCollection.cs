using System.Collections.Generic;

namespace LibraryServerApi.Models.RandomData
{
    public class RandomDataCollection : BaseEntity
    {
        public RandomDataCollection()
        {
            Items = new List<RandomDataItem>();
        }

        public string Group { get; set; }

        public IList<RandomDataItem> Items { get; set; }
    }
}
