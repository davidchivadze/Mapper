using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using FincaHR.Models.ExcelLoan;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Office.Interop.Excel;
using Models.ViewModels.ExcelLoan;
using Excel = Microsoft.Office.Interop.Excel;

namespace FincaHR.Controllers.ExcelLoanReader
{
    [Authorize(Roles = "ExcelLoan")]
    public class ExcelLoanController : BaseController
    {

        protected readonly IHostingEnvironment _hostingEnvironment;

        public ExcelLoanController(IHostingEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }
        public IActionResult Index()
        {
            // Get files List From Path


            //var data=ExcelLoanServices.ReadExcelFileData(filesList, _hostingEnvironment.WebRootPath,new PersonTest().GetType());
            //ExcelLoanServices.ReadFile(filesList,_hostingEnvironment.WebRootPath);

            return View(new FolderFileListViewModel
            {
                FileListModels = ExcelLoanServices.GetFileListByTypes(_hostingEnvironment.WebRootPath)
            });
        }

        public IActionResult ReadFiles()
        {
            try
            {
                var filesList = ExcelLoanServices.GetFileListByTypes(_hostingEnvironment.WebRootPath);
                //var data = ExcelLoanServices.ReadExcelFileData(filesList, _hostingEnvironment.WebRootPath, new PersonTest().GetType());
                ExcelLoanServices.ReadFile(filesList, _hostingEnvironment.WebRootPath);
                return Json(new { success = true });
            }
            catch (Exception ex)
            {
                return Json(new { success = false, error = ex.Message });
            }
        }
        [HttpGet]
        public IActionResult UploadMapperFile()
        {
            var viewModel = new UploadFileViewModel();
            viewModel.UploadFileTypes = ExcelLoanServices.GetUploadFileTypes().Select(m => new SelectListItem() { Text = m.Description, Value = m.ID.ToString() }).ToList();
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult UploadMapperFile(UploadFileViewModel model)
        {
            try
            {
                if (ExcelLoanServices.SaveExcelFileToDatabase(model))
                {
                    return RedirectToAction("MapperFileList", "ExcelLoan");
                }
                else
                {

                    return View(model);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public IActionResult MapperFileList()
        {
            UploadFIleListViewModel fileList = new UploadFIleListViewModel
            {
                FileList = ExcelLoanServices.GetFileList().ToList()
            };



            return View(fileList);
        }
        [HttpGet]
        public IActionResult ImportMaping(int Id)
        {
            try
            {
                ExcelLoanServices.ImportMapping(Id);
                return RedirectToAction("MapperFileList", "ExcelLoan");
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index", "Errors", new { ErrorMessage = ex.Message });
            }
        }
        [HttpGet]
        public IActionResult AddFileType()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddFileType(UploadFileTypeViewModel model)
        {

            try
            {
                ExcelLoanServices.AddUploadFileType(model, _hostingEnvironment.WebRootPath);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index", "Error", new { ErrorMessage = ex.Message });
            }

        }
        [HttpGet]
        public IActionResult UploadProcessingFiles()
        {
            return View(new UploadProcessingFilesViewModel()
            {
                UploadFileTypes = ExcelLoanServices.GetUploadFileTypes().Select(m => new SelectListItem() { Text = m.Description, Value = m.ID.ToString() }).ToList()
            });

        }
        [HttpPost]
        public async Task<IActionResult> UploadProcessingFiles(UploadProcessingFilesViewModel model)
        {
            try
            {
                ExcelLoanServices.UploadProcessingFiles(model, _hostingEnvironment.WebRootPath);
                return RedirectToAction("Index", "ExcelLoan");
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index", "Error", new { ErrorMessage = ex.Message });
            }
        }
    }
}