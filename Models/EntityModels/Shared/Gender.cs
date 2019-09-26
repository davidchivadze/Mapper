using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Models.EntityModels.Shared
{
    public class Gender:BaseEntityModel
    {
        [Key]
        public int ID { get; set; }
        public int Description { get; set; }

    }
}
