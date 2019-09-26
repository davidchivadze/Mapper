using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Models.EntityModels.ExcelLoan
{
    public class ReadFiles:BaseEntityModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string FileName { get; set; }     
        public int UploadFileTypeID { get; set; }  
        public int ReadFileStatusID { get; set; }

        [ForeignKey("UploadFileTypeID")]
        public virtual UploadFileType UploadFileType { get; set; }

        [ForeignKey("ReadFileStatusID")]
        public virtual ReadFileStatus ReadFileStatus { get; set; }
    }
}
