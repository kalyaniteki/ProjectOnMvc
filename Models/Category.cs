using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCProject.Models
{
    public class Category
    {
        [Key]
        public int C_id { get; set; }
        public string Cname { get; set; }
        public Category()
        {

        }
        public Category(int cid,string cname)
        {
            this.C_id = cid;
            this.Cname = cname;
        }

    }
}
