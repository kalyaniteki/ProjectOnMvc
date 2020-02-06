using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCProject.Models
{
    public class Item:SubCategory
    {
       
        public int I_id { get; set; }
        public string Iname { get; set; }
        public int Price { get; set; }
      
        public Item()
        {

        }
        public Item(int id,string name,int price,int subid,string subname,int cid,string cname)
        {
            this.I_id = id;
            this.Iname = name;
            this.Price = price;
            this.Subid = subid;
            this.Subname = subname;
            this.C_id = cid;
            this.Cname = cname;

        }
        

    }
}
