using System;
using System.Collections.Generic;
using Domain;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class DataContext :DbContext
    {
        public DataContext(DbContextOptions options) :base(options)
        {

        }

        public DbSet<Activity> Activities {get;set;}
    }
}