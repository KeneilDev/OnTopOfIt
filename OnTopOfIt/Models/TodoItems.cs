using OnTopOfIt.Areas.Identity.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace OnTopOfIt.Models
{
    public class TodoItems
    {
        public int Id { get; set; }
        [Required]
        [DisplayName("Task")]
        public string Name { get; set; }

        [Required]
        [DisplayName("Icon")]
        public string icon { get; set; }

        [Required]
        [DisplayName("Colour Category")]
        public string colour { get; set; }

        [DisplayName("Monday")]
        public bool repeatMonday { get; set; }

        [DisplayName("Tuesday")]
        public bool repeatTuesday { get; set; }

        [DisplayName("Wednesday")]
        public bool repeatWednesday { get; set; }

        [DisplayName("Thursday")]
        public bool repeatThursday { get; set; }

        [DisplayName("Friday")]
        public bool repeatFriday { get; set; }

        [DisplayName("Saturday")]
        public bool repeatSaturday { get; set; }

        [DisplayName("Sunday")]
        public bool repeatSunday { get; set; }

        [Required]
        [DisplayName("Time of Day")]
        public string timeofDay { get; set; }

        public DateTime completeBy { get; set; }

        public virtual OnTopOfItUser OnTopOfItUser{ get; set; }

        public bool taskComplete { get; set; }
    }
}
