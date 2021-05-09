using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnglishStoryWriter_API.Entities
{
    public class Criterion : BaseEntity
    {
        public int Id {get; set;}
        public string Name { get; set; }
    }
}
