using Core.Results.Abstract;

namespace Core.Results.Concrete
{
    public class Result : IResult
    {
        public string Message { get ; set ; }
        public int StatusCode { get ; set ; }
        public string ErrorMessages { get ; set ; }

        public Result(string _message, int _StatusCode, string _ErrorMessage = null)
        {
            Message = _message;
            StatusCode = _StatusCode;
            ErrorMessages = _ErrorMessage;
        }
    }


}
