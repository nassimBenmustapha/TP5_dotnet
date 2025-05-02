using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using TP5.Data;

using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using TP5.Data;
using TP5.Models;

namespace TP5.Controllers;

public class MovieController : Controller
{
    
    private readonly ApplicationDbContext _context;

    public MovieController(ApplicationDbContext context)
    {
        _context = context;
    }
    
    public IActionResult MovieMangement()
    {
        //var users = _userManager.Users.ToList();
        var movies = _context.Movies.ToList();
        return View(movies);
    }
}