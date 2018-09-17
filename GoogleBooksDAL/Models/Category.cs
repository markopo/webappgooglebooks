using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoogleBooksDAL.Models
{
    public class Category
    {
        public virtual long Id { get; set; }
        public virtual string Name { get; set; }
        public virtual DateTime Created { get; set; }
        public virtual DateTime Updated { get; set; }
        public virtual Book Book { get; set; }
    }
}
