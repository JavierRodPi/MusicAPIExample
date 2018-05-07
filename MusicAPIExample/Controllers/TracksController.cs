using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MusicAPIExample.Models;
using MusicAPIExample.Track;

namespace MusicAPIExample.Controllers
{
    public class TracksController : Controller
    {
        private readonly ITrackService _trackService;

        public TracksController(ITrackService trackService)
        {
            _trackService = trackService;
        }

        public async Task<IActionResult> Index()
        {
            var tracks = await _trackService.GetTrackByGenreWithAuthorNameAsync("rock");
            return View("Tracks", tracks);
        }
    }
}
