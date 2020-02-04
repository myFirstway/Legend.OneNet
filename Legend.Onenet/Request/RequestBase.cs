using System;
using System.Linq;
using System.Net.Http;
using System.Text;

namespace Legend.Onenet.Request
{
    public class RequestBase
    {
        protected readonly HttpRequestMessage _httpRequestMessage;
        private string _url;
        private bool _buildContent = true;
        public OnenetOptions OnenetOptions { get; set; }
        public RequestBase(string url, HttpMethod httpMethod, bool buildContent = true) : this(url, new OnenetOptions(), httpMethod, buildContent)
        {
            _httpRequestMessage = new HttpRequestMessage
            {
                Method = httpMethod
            };
            _url = url;
            _buildContent = buildContent;
        }
        public RequestBase(string url, OnenetOptions onenetOptions, HttpMethod httpMethod, bool buildContent = true)
        {
            _httpRequestMessage = new HttpRequestMessage
            {
                Method = httpMethod
            };
            _url = url;
            _buildContent = buildContent;
            OnenetOptions = onenetOptions;
        }
        public HttpRequestMessage BuildHttpRequestMessage()
        {
            _httpRequestMessage.RequestUri = new Uri(BuildUrl());
            if ((_httpRequestMessage.Method == HttpMethod.Post || _httpRequestMessage.Method == HttpMethod.Put) && _buildContent)
            {
                var content = Serialization.SerializationHelper.SerializeObject(this);
                _httpRequestMessage.Content = new StringContent(content, Encoding.UTF8, "application/json");
            }
            return _httpRequestMessage;
        }

        protected string BuildUrl()
        {
            string url = BuildUrlPath();
            if (_httpRequestMessage.Properties.Count > 0)
            {
                string param = _httpRequestMessage.Properties.Select(t => $"{ t.Key}={t.Value}").Aggregate((a, b) => $"{a}&{b}");
                return url + "?" + param;
            }
            return url;
        }

        protected virtual string BuildUrlPath()
        {
            return _url;
        }
        protected void PropertiesAdd(string key, string value)
        {
            if (_httpRequestMessage.Properties.TryGetValue(key, out object oldvalue))
            {
                _httpRequestMessage.Properties[key] = value;
            }
            else
            {
                _httpRequestMessage.Properties.Add(key, value);
            }
        }
    }
}
