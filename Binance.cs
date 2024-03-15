using Binance.Net.Clients;
using CryptoExchange.Net.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketApiTest
{
    class Binance : ICryptoConnector
    {
        BinanceRestClient client;
        int maxRequest;
        public bool active = false;
        public bool connect(int _maxRequest)
        {
            maxRequest = _maxRequest;
            try
            {
                client = new BinanceRestClient();
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
                    var tickerResult = await client.SpotApi.ExchangeData.GetTickerAsync(name);
                    decimal result = tickerResult.Data.LastPrice;
                    return result;
                } catch { }
            }
            return 0;
        }

    }
}
