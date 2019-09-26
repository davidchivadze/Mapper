using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models.ViewModels.ExcelLoan
{
    public class UploadProcessingFilesViewModel
    {
        public int FileTypeID { get; set; }
        public List<SelectListItem> UploadFileTypes { get; set; }
        public List<IFormFile> Files { get; set; }
    }
}
