using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EFSecondLevelCachePlus.TestDataLayer.Models
{
    public class User
    {
        public int Id { set; get; }

        [Required]
        public string Name { set; get; }

        public virtual ICollection<Product> Products { set; get; }

        public virtual ICollection<Post> Posts { set; get; }
    }
}