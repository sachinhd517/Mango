using System.Security.Principal;
using static Mango.Web.Utility.SD;

namespace Mango.Web.Models
{
    public class RequestDto
    {
        public ApiType ApiType { get; set; } = ApiType.GET;
        public string url { get; set; }
        public object Data { get; set; }
        public string AccessToken { get; set; }
    }
}
