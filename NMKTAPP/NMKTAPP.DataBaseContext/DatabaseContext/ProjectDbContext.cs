using Microsoft.EntityFrameworkCore;
using NMKTAPP.Models.Models;
using NMKTAPP.Models.Models.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NMKTAPP.DatabaseContext.DatabaseContext
{
    public class ProjectDbContext : DbContext
    {
        public ProjectDbContext(DbContextOptions<ProjectDbContext> options)
        : base(options)
        {
        }
        public DbSet<User> users { get; set; }
        public DbSet<ServiceInfo> ServiceInfos { get; set; }
        public DbSet<CompanyInfo> companyInfos { get; set; }
        public DbSet<SerCategory> serCategories { get; set; }
    }
}
