using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Models.EntityModels.ExcelLoan
{
    [Table("UploadFiles")]
    public class UploadFile:BaseEntityModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public byte[] UploadFileData { get; set; }
       
        public int UploadFileTypeID { get; set; }
        public DateTime UploadDate { get; set; }
        public bool IsActive { get; set; }
        public bool IsImported { get; set; }
        public string FileName { get; set; }

        [ForeignKey("UploadFileTypeID")]
        public virtual UploadFileType UploadFileType { get; set; }
    }
}
