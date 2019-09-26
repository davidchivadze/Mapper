using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Models.EntityModels.HR
{
   public class DutyStation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        [MaxLength(255)]
        public string ShortName { get; set; }
        [Required]
        [MaxLength(255)]
        public string DutyStationName { get; set; }
        [Required]
        [MaxLength(255)]
        public string DutyStationAddress { get; set; }


    }
}
