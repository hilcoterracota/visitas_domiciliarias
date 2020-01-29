using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sivido.Model.Core
{
    public class Default
    {
        [Key]
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public DateTime RegistrationDate { get; set; } = DateTime.Now;
        public Boolean Active { get; set; } = true;
    }
}