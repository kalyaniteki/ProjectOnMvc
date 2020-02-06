using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace MVCProject.Models
{
    public class ItemContext :DbContext
    {
        public ItemContext(DbContextOptions<ItemContext> options) : base(options)
        {

        }
        public DbSet<Item> ItemDb { get; set; }
    }
}
