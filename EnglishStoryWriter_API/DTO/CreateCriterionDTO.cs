using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EnglishStoryWriter_API.DTO
{
    public class CreateCriterionDTO
    {
        [Required]
        [MaxLength(25)]
        public string Name { get; set; }
    }
}
