using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;

namespace IdentityProj.Models
{
    public class ApplicationUser : IdentityUser
    {
        public DateTime BirthDate { get; set; }
        public string FavoriteToy { get; set; }
    }
}
