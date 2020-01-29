using System;
using System.ComponentModel.DataAnnotations;

namespace Sivido.Model.Core
{
    public class DefaultBreak
    {
        [Required]
        public DateTime RegistrationDate { get; set; } = DateTime.Now;
        [Required]
        public Boolean Active { get; set; } = true;
    }
}