using IdentityProj.Models;
using IdentityProj.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityProj.Controllers
{
    public class UserManagementController : Controller
    {
        private readonly IdentityContext _dbContext;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public UserManagementController(IdentityContext dbContext, UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _dbContext = dbContext;
            _userManager = userManager;
            _roleManager = roleManager;
        }
        public IActionResult Index()
        {
            var vm = new UserManagementIndexViewModel { Users = _dbContext.Users.OrderBy(u => u.Email).ToList() };
            return View(vm);
        }
        [HttpGet]
        public IActionResult AddRole(string id)
        {
            var vm = new UserManagementAddRoleViewModel
            {
                Roles = _roleManager.Roles.ToList(),
                UserId=
            };
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddRole(UserManagementAddRoleViewModel rvm)
        {
            var user = await _userManager.FindByIdAsync(rvm.UserId);
            await _userManager.AddToRoleAsync(user, rvm.NewRole);
            return RedirectToAction("Index");
        }
    }
}