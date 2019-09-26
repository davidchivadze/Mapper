using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models.ViewModels.ExcelLoan
{
    public class UploadFileViewModel
    {
        public int ID { get; set; }
        public IFormFile UploadFile { get; set; }
        public int FileTypeID { get; set; }
        public string UploadFileTypeName { get; set; }
        public DateTime UploadDate { get; set; }
        public bool IsActive { get; set; }
        public List<SelectListItem> UploadFileTypes { get; set; }
        public byte[] FileBytes { get; set; }
        public string FileName { get; set; }
        public bool IsImported { get; set; }
        
    }
}
