using System.ComponentModel.DataAnnotations;
using TestServer.Core.Enums;

namespace TestServer.Core.Models
{
    public class FormModel
    {
        [Required]
        [MinLength(1)]
        public string Name { get; set; }

        [Required]
        public EmploymentType EmploymentType { get; set; }

        [Required]
        public Sex Sex { get; set; }

        [Required]
        public bool Married { get; set; }

        [Required]
        [MinLength(1)]
        public string Hobbies { get; set; }
    }
}