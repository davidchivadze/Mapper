using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Models.EntityModels.ExcelLoan
{
    [Table("FileMapping")]
    public class FileMapping:BaseEntityModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
   
        public int FileTypeID { get; set; }
        public string SheetName { get; set; }
        public string Cell { get; set; }
        public string VariableName { get; set; }    
        public int VariableTypeID { get; set; }    


        [ForeignKey("VariableTypeID")]
        public virtual VariableType VariableType { get; set; }
        [ForeignKey("FileTypeID")]
        public virtual UploadFileType UploadFileType { get; set; }
    }
}
