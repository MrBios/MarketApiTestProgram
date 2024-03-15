using Kucoin.Net.Clients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketApiTest
{
    internal class Kucoin : ICryptoConnector
    {
        KucoinRestClient client;
        int maxRequest;
        public bool active = false;
        public bool connect(int _maxRequest)
        {
            maxRequest = _maxRequest;
            try
            {
                client = new KucoinRestClient();
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
            for (int i = 0; i < maxRequest; i++)
            {
                try
                {
                    var tickerResult = await client.SpotApi.ExchangeData.GetTickerAsync(name);
                    decimal result = (decimal)tickerResult.Data.LastPrice;
                    return result;
                }
                catch { }
            }
            return 0;
        }
    }
}
