using Bybit.Net.Clients;
using CryptoExchange.Net.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketApiTest
{
    internal class Bybit : ICryptoConnector
    {
        BybitRestClient client;
        int maxRequest;
        public bool active = false;
        public bool connect(int _maxRequest)
        {
            maxRequest = _maxRequest;
            try
            {
                client = new BybitRestClient();
                active = true;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<decimal> getCurrPrice(string name)
        {
            name = name.Replace("-", "");
            for (int i = 0; i < maxRequest; i++)
            {
                try
                {
                    var tickerResult = await client.V5Api.ExchangeData.GetSpotTickersAsync(name);
                    decimal result = tickerResult.Data.List.First().LastPrice;
                    return result;
                }
                catch { }
            }
            return 0;
        }
    }
}
