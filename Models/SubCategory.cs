using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCProject.Models
{
    public class SubCategory:Category
    {
       
        public int Subid { get; set; }
        public string Subname { get; set; }
        public SubCategory()
        {

        }
        public SubCategory(int subid,string subname,int cid,string cname)
        {
            this.Subid = subid;
            this.Subname = subname;
            this.C_id = cid;
            this.Cname = cname;
        }
    }
}
