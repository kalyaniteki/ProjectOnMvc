using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace MVCProject.Models
{
    public class Buyer
    {
        [Key]
        [Required(ErrorMessage ="id required")]
       [RegularExpression(@"[0-9]{,5}",ErrorMessage ="enter valid id")]
       [DisplayName("Buyreid")]
        public int Bid { get; set; }
        [Required(ErrorMessage = "name required")]
        [RegularExpression(@"[A-Z][a-zA-Z]{5,10}",ErrorMessage ="Name should be valid")]
        [DisplayName("Name")]
        public string BName { get; set; }
        [Required(ErrorMessage = "password required")]
        [RegularExpression("^.*(?=.{8,})(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z])(?=.*[!*@#$%^&+=]).*$", ErrorMessage = "password should be valid")]
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

        public Buyer()
        {

        }
        public Buyer(int bid, string bname, string pass, string email, int phno, DateTime date)
        {
            this.Bid = bid;
            this.BName = bname;
            this.Pass = pass;
            this.Email = email;
            this.Phno = phno;
            this.date = date;
    
        }
    }
}
