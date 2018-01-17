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
        public string EmailAddress { get; set; }
        public string ContactNumber { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DateTimeStamp { get; set; } = DateTime.Now;
        public bool Cancelled { get; set; }
    }
}
