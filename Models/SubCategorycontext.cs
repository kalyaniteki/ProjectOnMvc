using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MVCProject.Models
{
    public class SubCategorycontext:DbContext
    {
        public SubCategorycontext(DbContextOptions<SubCategorycontext>options):base(options)
        {

        }
        public DbSet<SubCategory> SubCategoriesDb { get; set; }
    }
}
