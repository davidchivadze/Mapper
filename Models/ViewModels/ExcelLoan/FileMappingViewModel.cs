using System;
using System.Collections.Generic;
using System.Text;

namespace Models.ViewModels.ExcelLoan
{
   public class FileMappingViewModel
    {

        public int ID { get; set; }
        public int FileTypeID { get; set; }
        public string SheetName { get; set; }
        public string Cell { get; set; }
        public string VariableName { get; set; }
        public int VariableTypeID { get; set; }
    }
}
