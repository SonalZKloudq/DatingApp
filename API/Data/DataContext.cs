using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using API.Entities;

namespace API.Data
{
    public class DataContext:DbContext
    {
        #nullable disable
                public DataContext(DbContextOptions options) : base(options)
        {
            
        }
#nullable restore
        public DbSet<AppUser> Users{get;set;}
    }
} 