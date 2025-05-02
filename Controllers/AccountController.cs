using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using TP5.Data;

namespace TP5.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly ApplicationDbContext _context;

        public AccountController(UserManager<IdentityUser> userManager, ApplicationDbContext context)
        {
            _userManager = userManager;
            _context = context;
        }

        // Afficher la liste des utilisateurs
        public IActionResult UserManagement()
        {
            //var users = _userManager.Users.ToList();
            var users = _context.Users.ToList();
            return View(users);
        }
    }

}
