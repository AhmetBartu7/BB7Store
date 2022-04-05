using Core.Results.Abstract;

namespace Core.Results.Concrete
{
    public class DataResult<T> : IDataResult<T>
    {
        public T Data { get; set ; }
        public string Message { get ; set ; }
        public int StatusCode { get ; set ; }
        public string ErrorMessages { get ; set ; } = null;

        public DataResult(string _message, int _StatusCode, T _Data)
        {
            Message = _message;
            StatusCode = _StatusCode;
            Data = _Data;
        }
    }
}