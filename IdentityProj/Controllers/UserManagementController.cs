using IdentityProj.Models;
using IdentityProj.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace IdentityProj.Controllers
{
    public class UserManagementController : Controller
    {
        private readonly IdentityContext _dbContext;

        public UserManagementController(IdentityContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IActionResult Index()
        {
            var vm = new UserManagementIndexViewModel { Users = _dbContext.Users.OrderBy(u => u.Email).ToList() };
            return View(vm);
        }
    }
}