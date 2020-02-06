using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Microsoft.AspNetCore.Mvc;

namespace MVCProject.Models
{
    public class Seller
    {
        [Key]
        [Required(ErrorMessage = "id required")]
       [RegularExpression(@"[0-9]{,5}", ErrorMessage = "enter valid id")]
        public int Sid { get; set; }
        [Required(ErrorMessage = "name required")]
        [RegularExpression(@"[A-Z][a-zA-Z]{5,10}", ErrorMessage = "Name should be valid")]
        [DisplayName("Name")]
        public string SName { get; set; }
        [Required(ErrorMessage = "password required")]
        [RegularExpression("^.*(?=.{8,})(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z])(?=.*[!*@#$%^&+=]).*$", ErrorMessage = "Name should be valid")]
        [DisplayName("Password")]
        public string Pass { get; set; }
        [Required(ErrorMessage = "email required")]
        [EmailAddress(ErrorMessage = "enter valid email")]
        [Remote(action: "IsEmailExist", controller: "Buyer")]
        [DisplayName("Email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "phno required")]
        [DisplayName("Mobile")]
        public int Phno { get; set; }
        [Required(ErrorMessage = "date required")]
        [DisplayName("Date")]
        public DateTime date { get; set; }
        public string Photopath { get; set; }

        public Seller()
        {

        }
        public Seller(int sid, string sname, string pass, string email, int phno, DateTime date,string photopath)
        {
            this.Sid = sid;
            this.SName = sname;
            this.Pass = pass;
            this.Email = email;
            this.Phno = phno;
            this.date = date;
            this.Photopath = photopath;
        }

    }
}
