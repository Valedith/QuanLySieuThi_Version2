using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySieuThi_Version2.Infrastructures
{
    class CustomResult
    {
        public CustomResult(CustomResultType resultType)
        {
            Result = resultType;
        }

        public CustomResult(CustomResultType resultType, string errorMessage)
        {
            Result = resultType;
            ErrorMessage = errorMessage;
        }
        public CustomResult(CustomResultType resultType, CustomInvalidInputType invalidInputType, string errorMessage)
        {
            Result = resultType;
            InvalidInputType = invalidInputType;
            ErrorMessage = errorMessage;
        }
        public CustomResult(CustomResultType resultType, CustomInvalidInputType invalidInputType)
        {
            Result = resultType;
            InvalidInputType = invalidInputType;
        }
        public CustomResultType Result { get; set; }
        public CustomInvalidInputType InvalidInputType { get; set; }
        public string ErrorMessage { get; set; }
    }
    enum CustomResultType
    {
        InvalidModelState, UnexpectedError, Succeed, Existed, InvalidInput, NotExisted
    }
    enum CustomInvalidInputType
    {
        PhoneNumber, Name
    }
}
