using System;
using System.Collections.Specialized;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Vestigen.Clients.HashiCorp
{
    public class HashiCorpClientHandler : IDisposable
    {
        private readonly HttpClient _httpClient;

        public HashiCorpClientHandler(string address)
        {
            _httpClient = new HttpClient();
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            _httpClient.BaseAddress = new Uri(address);
        }

        public virtual async Task<string> SendRequest(HttpMethod method, string address, NameValueCollection headers = null, string body = null, CancellationToken? ct = null)
        {
            try
            {
                using (var r = await SendRequestProcessor(method, address, headers, body, ct))
                {
                    if (r.StatusCode != HttpStatusCode.NotFound && !r.IsSuccessStatusCode)
                    {
                        throw new HashiCorpClientRequestException($"Unexpected response, status code {r.StatusCode}", r.StatusCode)
                        {
                            ResponseBody = await r.Content.ReadAsStringAsync()
                        };
                    }

                    return await r.Content.ReadAsStringAsync();
                }
            }
            catch (Exception ex)
            {
                throw new HashiCorpClientRequestException(ex.Message, default(HttpStatusCode), ex);
            }
        }

        private Task<HttpResponseMessage> SendRequestProcessor(HttpMethod method, string address, NameValueCollection headers, string body, CancellationToken? ct = null)
        {
            var requestMessage = new HttpRequestMessage(method, new Uri(_httpClient.BaseAddress, address));

            if (headers != null)
            {
                foreach (var item in headers.AllKeys)
                {
                    requestMessage.Headers.Add(item, headers[item]);
                }
            }

            if (body != null)
            {
                requestMessage.Content = new StringContent(body, Encoding.UTF8, "application/json");
            }

            return ct.HasValue
                ? _httpClient.SendAsync(requestMessage, ct.Value)
                : _httpClient.SendAsync(requestMessage);
        }

        public void Dispose()
        {
            _httpClient.Dispose();
        }
    }
}