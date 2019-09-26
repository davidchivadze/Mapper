using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Models.ViewModels.Auth
{
    public class UserViewModel
    {
        public int ID { get; set; }
        [Required]
        [MaxLength(250)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(250)]
        public string LastName { get; set; }
        [Required]
        [StringLength(11)]
        public string PIN { get; set; }

        public string Address { get; set; }
        [Required]
        public bool IsDeleted { get; set; }

        public DateTime BirthDate { get; set; }
        [Required]
        [MaxLength(250)]
        public string UserName { get; set; }

        [Required]
        [MaxLength(500)]
        public string Password { get; set; }

        public List<RolesViewModel> UserRoles { get; set; }
    }
}
