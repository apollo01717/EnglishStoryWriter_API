using EnglishStoryWriter_API.DTO;
using EnglishStoryWriter_API.Entities;
using EnglishStoryWriter_API.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnglishStoryWriter_API.Controllers
{
    public class LevelController : PrimaryController<Level, LevelDTO, CreateLevelDTO>
    {
        public LevelController(ILevelService levelService) : base(levelService) 
        {
        }  
       
    }
}
