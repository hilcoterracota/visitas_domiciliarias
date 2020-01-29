using System;
using System.ComponentModel.DataAnnotations;

namespace Sivido.Model.Core
{
    public class Default
    {
        [Key]
        [Required]
        public string Id { get; set; } = Guid.NewGuid().ToString();
        [Required]
        public DateTime RegistrationDate { get; set; } = DateTime.Now;
        [Required]
        public Boolean Active { get; set; } = true;
    }
}