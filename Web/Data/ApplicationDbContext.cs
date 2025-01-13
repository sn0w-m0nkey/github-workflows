using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Web.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
    : IdentityDbContext<ApplicationUser>(options)
{

}

// public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
// {
//     private DbContextOptions<ApplicationDbContext> _options;
//     public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
//     {
//         _options = options;
//     }
// }
