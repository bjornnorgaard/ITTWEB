using System.ComponentModel.DataAnnotations;

namespace DotnetCore.Api.Models
{
    public class PetPost
    {
        [Required, MinLength(3)]
        public string Name { get; set; }
        [Required, MinLength(5)]
        public string Secret { get; set; }
    }
}
