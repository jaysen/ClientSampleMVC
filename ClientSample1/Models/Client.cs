using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ClientSample1.Models
{
    public class Client
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Gender { get; set; }

        [Display(Name = "Email")]
        public string EmailAddress { get; set; }
        [Display(Name = "Contact Number")]
        public string ContactNumber { get; set; }
        [Display(Name = "Created")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DateTimeStamp { get; set; } = DateTime.Now;
        public bool Cancelled { get; set; }


        // Delete client by setting Cancelled field to true 
        // policy is never to delete data, but rather flag it as cancelled and hide it from interface
        public void Delete()
        {
            this.Cancelled = true;
        }
    }



}
