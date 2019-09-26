using Database.Interfaces;
using Database.Repository;
using Database.Interfaces.Shared;
using Database.Repository.Shared;
using System;
using Buisness.Interfaces.ExcelLoan;
using Buisness.Services.ExcelLoan;
using Database.Interfaces.ExcelLoan;
using Database.Repository.ExcelLoan;

namespace Buisness
{
    public class BaseService
    {
        private IUserRepository _userRepository;
        protected IUserRepository UserRepository
        {
            get
            {
                return _userRepository = _userRepository ?? new UserRepository();
            }
        }
        private IGenderRepository _genderRepository;
        protected IGenderRepository GenderRepository
        {
            get
            {
                return _genderRepository = _genderRepository ?? new GenderRepository();
            }
        }

        private IUploadFileTypeRepository _UploadFileTypeRepository;
        protected IUploadFileTypeRepository UploadFileTypeRepository
        {
            get
            {
                return _UploadFileTypeRepository = _UploadFileTypeRepository ?? new UploadFileTypeRepository();
            }
        }
        private IUploadFileRepository _UploadFileRepository;
        protected IUploadFileRepository UploadFileRepository
        {
            get
            {
                return _UploadFileRepository = _UploadFileRepository ?? new UploadFileRepository();
            }
        }

        private IFileMappingRepository _FileMappingRepository;
        protected IFileMappingRepository FileMappingRepository
        {
            get
            {
                return _FileMappingRepository = _FileMappingRepository ?? new FileMappingRepository();
            }
        }
        private IReadFilesRepository _ReadFileRepository;
        protected IReadFilesRepository ReadFilesRepository
        {
            get
            {
                return _ReadFileRepository = _ReadFileRepository ?? new ReadFilesRepository();
            }
        }
        private IUnplanedExcelDataRepository _unplanedExcelDataRepository;
        protected IUnplanedExcelDataRepository UnplanedExcelDataRepository
        {
            get
            {
                return _unplanedExcelDataRepository = _unplanedExcelDataRepository ?? new UnplanedExcelDataRepository();
            }
        }
    }
}
