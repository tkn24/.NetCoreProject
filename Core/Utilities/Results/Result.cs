using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {

        //Read Only'ler Constructorda set edilebilir !
        public Result(bool success, string message):this(success)
        {
            Message = message;
           
        }
        public Result(bool success) //OverLoading
        {
            Success = success;
        }

        public bool Success { get; }

        public string Message { get; }
    }
}
