using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Models.EntityModels.ExcelLoan
{
    [Table("UploadFileType")]
    public class UploadFileType:BaseEntityModel
    {
       
        [Key]
        public int ID { get; set; }
        public string Description { get; set; }
        public string FilesPath { get; set; }
     
    }
}
