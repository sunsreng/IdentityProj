using IdentityProj.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System.Collections.Generic;

namespace IdentityProj.ViewModels
{
    public class UserManagementAddRoleViewModel
    {
        public string UserId { get; set; }
        public string NewRole { get; set; }
        public List<IdentityRole> Roles { get; set; }
    }
}
