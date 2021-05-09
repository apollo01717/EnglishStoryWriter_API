    using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnglishStoryWriter_API.Entities
{
    public class CategoryOfKeyword : BaseEntity
    {
        public int Id { set; get; }
        public string Name { get; set; }
    }
}
