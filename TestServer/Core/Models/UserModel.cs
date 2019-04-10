using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using TestServer.Core.Enums;

namespace TestServer.Core.Models
{
    public class UserModel
    {
        [Required]
        [MinLength(1)]
        [JsonProperty("name")]
        public string Name { get; set; }

        [Required]
        [JsonProperty("employment_type")]
        public EmploymentType EmploymentType { get; set; }

        [Required]
        [JsonProperty("sex")]
        public Sex Sex { get; set; }

        [Required]
        [JsonProperty("married")]
        public bool Married { get; set; }

        [Required]
        [MinLength(1)]
        [JsonProperty("hobbies")]
        public string Hobbies { get; set; }
    }
}