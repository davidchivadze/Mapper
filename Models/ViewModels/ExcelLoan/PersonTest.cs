using System;
using System.Collections.Generic;
using System.Text;

namespace Models.ViewModels.ExcelLoan
{
   public class PersonTest:BaseMappingModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Other { get; set; }
    }
}
