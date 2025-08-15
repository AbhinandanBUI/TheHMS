namespace TheHMS.Model.Model.Common
{
    public class Response : IDisposable
    {
        public long transationId { get; set; } = DateTime.Now.Ticks;
        public int totalRecords { get; set; } = 0;
        public int statusCode { get; set; } = 404;
        public bool success { get; set; } = false;

        public string message { get; set; } = string.Empty;
        public object? responseData { get; set; }
        public object? cookiesData { get; set; }
        public string token { get; set; } = string.Empty;

        public void Dispose()
        {
            Console.WriteLine($"Object  is Destroyed");
            GC.SuppressFinalize(this);
        }
    }
    public enum StatusCode
    {
        RecordNotFound = 0,
        RecordFound = 1,
        NewRecordFound = 2,
        UpdatingRecord = 3,
        DeletingRecord = 4,
        Success = 200,
        Error = 400,
        NotFound = 404
    }
    public class DBResponse : IDisposable
    {

        public long transationId { get; set; } = DateTime.Now.Ticks;

        public int totalRecords { get; set; } = 0;
        public int statusCode { get; set; }
        public bool success { get; set; }
        public string message { get; set; } = String.Empty;
        public object? responseData { get; set; }

        public void Dispose()
        {
            Console.WriteLine($"Object  is Destroyed");
            GC.SuppressFinalize(this);
        }
    }
    public class MPaginaion
    {
        public int PageNo { get; set; } = 1;
        public int PageSize { get; set; } = 5;
        public bool IsNext { get; set; } = true;
        public bool IsPrev { get; set; } = false;
    }
}
