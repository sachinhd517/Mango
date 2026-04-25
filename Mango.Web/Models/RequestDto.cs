using System.Security.Principal;

namespace Mango.Web.Models
{
    public class RequestDto
    {
        public string ApiType { get; set; } = "GET";
        public string url { get; set; }
        public object Data { get; set; }
        public string AccessToken { get; set; }
    }
}
