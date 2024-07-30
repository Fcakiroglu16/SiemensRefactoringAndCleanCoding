using System.Net;

namespace Application.Models
{
    public record ServiceResult<T>
    {
        public T? Data { get; set; }
        public HttpStatusCode StatusCode { get; set; }

        public List<string>? Errors { get; set; }


        public bool IsSuccess => Errors == null || Errors.Count == 0;

        public bool IsFail => !IsSuccess;

        // static factory method create
        public static ServiceResult<T> CreateSuccess(T data, HttpStatusCode statusCode)
        {
            return new ServiceResult<T> { Data = data, StatusCode = statusCode };
        }

        public static ServiceResult<T> CreateFail(List<string> errors, HttpStatusCode statusCode)
        {
            return new ServiceResult<T> { Errors = errors, StatusCode = statusCode };
        }


        public static ServiceResult<T> CreateFail(string error, HttpStatusCode statusCode)
        {
            return new ServiceResult<T> { Errors = [error], StatusCode = statusCode };
        }
    }

    public record ServiceResult
    {
        public HttpStatusCode StatusCode { get; set; }

        public List<string>? Errors { get; set; }


        public bool IsSuccess => Errors == null || Errors.Count == 0;

        public bool IsFail => !IsSuccess;

        // static factory method create
        public static ServiceResult CreateSuccess(HttpStatusCode statusCode = HttpStatusCode.NoContent)
        {
            return new ServiceResult { StatusCode = statusCode };
        }


        public static ServiceResult CreateFail(List<string> errors, HttpStatusCode statusCode)
        {
            return new ServiceResult { Errors = errors, StatusCode = statusCode };
        }


        public static ServiceResult CreateFail(string error, HttpStatusCode statusCode)
        {
            return new ServiceResult { Errors = [error], StatusCode = statusCode };
        }
    }
}