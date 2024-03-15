using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketApiTest
{
    internal interface ICryptoConnector
    {
        bool connect(int _maxRequest);

        Task<decimal> getCurrPrice(string name);

    }
}
