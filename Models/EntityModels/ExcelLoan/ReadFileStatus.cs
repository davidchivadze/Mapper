﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Models.EntityModels.ExcelLoan
{
    public class ReadFileStatus:BaseEntityModel
    {
        [Key]
        public int ID { get; set; }
        public string Description { get; set; }

        
    }
}
