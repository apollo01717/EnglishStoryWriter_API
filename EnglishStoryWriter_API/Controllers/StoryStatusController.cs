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
    public class StoryStatusController : PrimaryController<StoryStatus, StoryStatusDTO, CreateStoryStatusDTO>
    {
        public StoryStatusController(IStoryStatusService storyStatusService): base(storyStatusService)
        {
        }
    }
}
