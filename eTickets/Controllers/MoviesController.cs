﻿using eTickets.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Controllers
{
    public class MoviesController : Controller
    {
        private readonly AppDBContext _context;

        public MoviesController(AppDBContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var allMovies = await _context.Movies.Include(n => n.cinema).OrderBy(n => n.name).ToListAsync();

            return View(allMovies);
        }
    }
}
