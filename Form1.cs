using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketApiTest
{
    public partial class Form1 : Form
    {
        Binance binance = new Binance();
        Bybit bybit = new Bybit();
        Kucoin kucoin = new Kucoin();
        Bitget bitget = new Bitget();
        int maxRequest;
        int time = 10;
        bool inWork = false;
        public Form1()
        {
            InitializeComponent();

            List<string> pairs = new List<string>();
            using (StreamReader sr = new StreamReader("settings/настройки.txt"))
            {
                sr.ReadLine();
                if(!Int32.TryParse(sr.ReadLine(), out maxRequest))
                {
                    MessageBox.Show("У вас ошибка в файле настроек на 2 строке", "Ошибка");
                    Environment.Exit(0);
                }
                sr.ReadLine();
                while(!sr.EndOfStream)
                {
                    pairs.Add(sr.ReadLine());
                }
            }
            pairBox.DataSource = pairs.ToArray();

            pairBox.SelectedIndex = 0;

            bool connected;

            infoText.Text = "Инициализация API";

            while(true)
            {
                connected = binance.connect(5);
                if(!connected)
                {
                    DialogResult result = MessageBox.Show("Ошибка подключения к Binance API\nПопробовать подключиться снова?", "Ошибка", MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes) continue;
                }
                break;
            }

            if(!connected)
            {
                binanceTextBox.Text = "не подключен";
            }

            while (true)
            {
                connected = bybit.connect(5);
                if (!connected)
                {
                    DialogResult result = MessageBox.Show("Ошибка подключения к Bybit API\nПопробовать подключиться снова?", "Ошибка", MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes) continue;
                }
                break;
            }

            if (!connected)
            {
                bybitTextBox.Text = "не подключен";
            }

            while (true)
            {
                connected = kucoin.connect(5);
                if (!connected)
                {
                    DialogResult result = MessageBox.Show("Ошибка подключения к Kucoin API\nПопробовать подключиться снова?", "Ошибка", MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes) continue;
                }
                break;
            }

            if (!connected)
            {
                kucoinTextBox.Text = "не подключен";
            }

            while (true)
            {
                connected = bitget.connect(5);
                if (!connected)
                {
                    DialogResult result = MessageBox.Show("Ошибка подключения к Bitget API\nПопробовать подключиться снова?", "Ошибка", MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes) continue;
                }
                break;
            }

            if (!connected)
            {
                bitgetTextBox.Text = "не подключен";
            }

            infoText.Text = "";
            timer.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        async void getPrices(string name)
        {
            decimal binancePrice = 0;
            decimal bybitPrice = 0;
            decimal kucoinPrice = 0;
            decimal bitgetPrice = 0;

            if (binance.active)
            {
                binancePrice = await binance.getCurrPrice(name);
            }
            if(bybit.active)
            {
                bybitPrice = await bybit.getCurrPrice(name);
            }
            if (kucoin.active)
            {
                kucoinPrice = await kucoin.getCurrPrice(name);
            }
            if (bitget.active)
            {
                bitgetPrice = await bitget.getCurrPrice(name);
            }

            if (binance.active)
            {
                binanceTextBox.Text = removeZero(binancePrice);
            }
            if (bybit.active)
            {
                bybitTextBox.Text = removeZero(bybitPrice);
            }
            if (kucoin.active)
            {
                kucoinTextBox.Text = removeZero(kucoinPrice);
            }
            if (bitget.active)
            {
                bitgetTextBox.Text = removeZero(bitgetPrice);
            }
            inWork = false;
            infoText.Text = "";
        }

        private string removeZero(decimal price)
        {
            if (price == 0)
                return "error";
            string textPrice = price.ToString();
            for(int i = textPrice.Length - 1; i >= 0; i--)
            {
                if (textPrice[i] == '0')
                {
                    textPrice = textPrice.Remove(textPrice.Length - 1);
                }
                else if(textPrice[i] == ',')
                {
                    textPrice = textPrice.Remove(textPrice.Length - 1);
                    break;
                }
                else
                    break;
            }
            return textPrice;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (inWork)
                return;
            time++;
            if(time >= 10)
            {
                string name = pairBox.SelectedItem.ToString();
                infoText.Text = "Получение цен " + name;
                time = 0;
                inWork = true;
                getPrices(name);
            }
        }
    }
}
