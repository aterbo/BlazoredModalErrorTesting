using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BlazoredModalTesting.Pages
{
    public class EditFormDataModel
    {
        [Required]
        [StringLength(10, ErrorMessage = "Name is too long.")]
        public string? Name { get; set; }

        [Required]
        public DateTime? Date { get; set; }
    }
}
