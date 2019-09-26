using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Models.EntityModels.HR
{
    public class EmployeeMobileNumber
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        public string Number { get; set; }
        [ForeignKey("MobileNumberType")]
        public int NumberTypeID { get; set; }
        public bool IsDefault { get; set; }

        public MobileNumberType MobileNumberType {get;set;}
    }
}
