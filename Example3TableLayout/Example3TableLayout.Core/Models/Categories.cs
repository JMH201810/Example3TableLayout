// This is a class modeling the Categories table in the database.
using System;
namespace Example3TableLayout.Core.Models
{
    public class Categories
    {
        public Categories()
        {
        }

        public int CategoryKey { get; set; }

        public string Name { get; set; }

        public int ParentID { get; set; }
    }
}
