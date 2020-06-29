using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace lab5.Models
{
    public class PatientModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "You must provide a name")]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "You must provide a disease")]
        [Display(Name = "Disease")]
        public string Disease { get; set; }
    }
}
