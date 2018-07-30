using System.Collections.Generic;

namespace EFSecondLevelCachePlus.TestDataLayer.Models
{
    public class Tag
    {
        public int Id { set; get; }
        public string Name { set; get; }

        public virtual ICollection<Product> Products { set; get; }
    }
}