using Models.EntityModels.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Models.EntityModels.HR
{
    public class EmployeePerson
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PIN { get; set; }
        public DateTime BirthDate { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string BirthPlace { get; set; }
        public byte[] EmployeeImage { get; set; }
        [ForeignKey("EmployeMobileNumber")]
        public string EmployeMobileID { get; set; }
        public string IPPhoneNumber { get; set; }
        public string Email { get; set; }
        [ForeignKey("Gender")]
        public int GenderID { get; set; }
        //Connections FK

        public EmployeeMobileNumber EmployeeMobileNumber { get; set; }
        public Gender Gender { get; set; }



    }
}
