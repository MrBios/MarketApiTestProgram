using Bitget.Net.Clients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketApiTest
{
    internal class Bitget : ICryptoConnector
    {
        BitgetRestClient client;
        int maxRequest;
        public bool active = false;
        public bool connect(int _maxRequest)
        {
            maxRequest = _maxRequest;
            try
            {
                client = new BitgetRestClient();
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
            name += "_SPBL";
            for (int i = 0; i < maxRequest; i++)
            {
                try
                {
                    var tickerResult = await client.SpotApi.ExchangeData.GetTickerAsync(name);
                    decimal result = tickerResult.Data.ClosePrice;
                    return result;
                }
                catch { }
            }
            return 0;
        }
    }
}
