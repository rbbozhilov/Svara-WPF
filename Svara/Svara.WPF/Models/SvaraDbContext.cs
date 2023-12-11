using Svara.WPF.Models.Svara;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Svara.WPF.Models
{
    public class SvaraDbContext : DbContext
    {
        public SvaraDbContext() : base("DefaultConnection")
        {
        }

        public DbSet<SvaraCheck> SvaraChecks { get; set; }
    }
}
