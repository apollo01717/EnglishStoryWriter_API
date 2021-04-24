﻿using EnglishStoryWriter_API.DTO;
using EnglishStoryWriter_API.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnglishStoryWriter_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StoryStatusController : ControllerBase
    {
        private readonly IStoryStatusService _storyStatusServie;

        public StoryStatusController(IStoryStatusService storyStatusService)
        {
            _storyStatusServie = storyStatusService;
        }

        [HttpGet]
        public ActionResult<StoryStatusDTO> GetAll()
        {
            return Ok(_storyStatusServie.GetAll());
        }

    }
}
