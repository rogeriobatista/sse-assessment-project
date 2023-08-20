using System.Net;

namespace SSE.Assessment.Shared.Http
{
    public class HttpRequestResponse<TContent>
    {
        public HttpStatusCode StatusCode { get; set; }
        public TContent Content { get; set; }
    }
}
