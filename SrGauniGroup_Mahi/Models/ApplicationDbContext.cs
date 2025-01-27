using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace SrGauniGroup_Mahi.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<User> SrGauni { get; set; }
    }
}