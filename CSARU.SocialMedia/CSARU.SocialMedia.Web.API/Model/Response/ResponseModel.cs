using System;

namespace CSARU.SocialMedia.Web.API.Model.Response
{
    public class ResponseModel<T>
    {
        public string Message { get; set; }
        public string ResponseTimeStamp { get { return DateTime.UtcNow.ToString("O"); } }
        public uint Status { get; set; }
        public T Data { get; set; }
        public ResponseModel()
        {
            this.Message = "Bad Request";
            this.Data = default(T);
            this.Status = 400;
        }
    }
}
