using System;

namespace Sivido.Model.Core
{
    public class DefaultBreak
    {
        public DateTime RegistrationDate { get; set; } = DateTime.Now;
        public Boolean Active { get; set; } = true;
    }
}