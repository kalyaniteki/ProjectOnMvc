using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MVCProject.Models
{
    public class Categorycontext:DbContext
    {
        public Categorycontext(DbContextOptions<Categorycontext> options) : base(options)
        {

        }
        public DbSet<Category>CategoriesDb { get; set; }
    }
}
