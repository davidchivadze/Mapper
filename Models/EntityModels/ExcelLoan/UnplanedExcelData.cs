using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Models.EntityModels.ExcelLoan
{
    public class UnplanedExcelData:BaseEntityModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        public int ReadFileID { get; set; }
        public string VariableName { get; set; }
        public string ValueNvarchar { get; set; }
        public int ValueInt { get; set; }
        public decimal ValueDecimal { get; set; }
        public bool IsDeleted { get; set; }
        [ForeignKey("ReadFileID")]
        public virtual ReadFiles ReadFiles { get; set; } 

    }
}
