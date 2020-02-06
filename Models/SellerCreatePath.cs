using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCProject.Models
{
    public class SellerCreatePath
    {
        public int Sid { get; set; }
        public string Sname { get; set; }
        public string Pass { get; set; }
        public string Email { get; set; }
       public int Mobile { get; set; }
        public DateTime date { get; set; }

        public IFormFile photo { get; set; }
    }
}
