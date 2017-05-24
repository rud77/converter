using RestSharp;
using System;
using System.Text;

namespace FixerLib
{
    public class FixerClient
    {
        #region Init
        const string baseUrl = "http://api.fixer.io/";
        const string dateFormat = "yyyy-MM-dd";
        RestClient fixerClient = new RestClient(baseUrl);
        #endregion

        #region Get data
        public Exchange GetData()
        {
            string url = ConstructUrl();
            return Execute(url);
        }

        public Exchange GetData(DateTime date)
        {
            string url = ConstructUrl(date.ToString(dateFormat));
            return Execute(url);
        }

        public Exchange GetData(DateTime date, Rate baseCurrency)
        {
            string url = ConstructUrl(date.ToString(dateFormat), baseCurrency);
            return Execute(url);
        }

        public Exchange GetData(DateTime date, Rate baseCurrency, Rate rate)
        {
            string url = ConstructUrl(date.ToString(dateFormat), baseCurrency, rate);
            return Execute(url);
        }
        #endregion

        #region Methods
        private Exchange Execute(string url)
        {
            var request = new RestRequest(url, Method.GET);
            IRestResponse<Exchange> response = fixerClient.Execute<Exchange>(request);
            return response.Data;
        }

        private string ConstructUrl(string date = "latest", Rate baseCurrency = Rate.RUB, Rate rate = default(Rate))
        {
            StringBuilder sb = new StringBuilder();
            return sb.Append(date).Append("?base=").Append(baseCurrency).Append("&symbols=").Append(rate).ToString();
        }
        #endregion
    }
}