using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SmartHouseMVC.Models.DbClass
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name {get;set;}
        [Required]
        public string Password {get;set;}
    }
}