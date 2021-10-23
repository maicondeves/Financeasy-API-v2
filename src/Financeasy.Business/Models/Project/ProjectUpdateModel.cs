using System;

namespace Financeasy.Business.Models
{
    public class ProjectUpdateModel
    {
        public Guid Id { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }
    }
}