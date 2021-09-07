using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication5.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Category()
        {
            Countries = new HashSet<Country>();
        }

        public virtual ICollection<Country> Countries { get; set; }
    }
}