namespace Core.Results.Abstract
{
    public interface IResult
    {
        public string Message { get; set; }
        public int StatusCode { get; set; }
        public string ErrorMessages { get; set; }
    }
}
