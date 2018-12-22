using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Builder
{
    public class UrlBuilder
    {
        private StringBuilder _urlStringBuilder;
        private List<string> _queryStringParameters = new List<string>();

        public UrlBuilder()
        {
            _urlStringBuilder = new StringBuilder();
        }

        public UrlBuilder WithBaseUri(string baseUri)
        {
            _urlStringBuilder.Append(baseUri);

            return this;
        }

        public UrlBuilder WithQueryStringParam(string value)
        {
            if (_queryStringParameters.Count == 0)
            {
                _urlStringBuilder.Append($"?{value}");
                _queryStringParameters.Add(value);
            }
            else
            {
                _urlStringBuilder.Append($"&{value}");

            }

            return this;
        }

        public string Create()
        {
            return _urlStringBuilder.ToString();
        }
    }
}
