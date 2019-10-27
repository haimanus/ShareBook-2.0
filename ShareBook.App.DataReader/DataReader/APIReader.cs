using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Net.Http;
using System.Net.Http.Headers;
using ShareBook.Master.Data;
using ShareBook.Master;
using Newtonsoft.Json.Linq;

namespace ShareBook.App.DataReader
{

    public class RootObject
    {
        public List<Candle> candles { get; set; }
        public string symbol { get; set; }
        public bool empty { get; set; }
    }
    public static class APIReader
    {
        //apikey=8FBL4ZPB5OPNLAAM90FRWYFKAMYNIVKH ; // url = "https://api.tdameritrade.com/v1/marketdata/GOOG/pricehistory?apikey=8FBL4ZPB5OPNLAAM90FRWYFKAMYNIVKH&periodType=day";
        public static List<Candle> GetPriceHistory(string symbol, StockExchange exchange)
        {
            string url_history = string.Empty;


            switch (exchange.stockExchange_Name)
            {
                case "NASDAQ":

                    //get history data
                    url_history = "https://api.tdameritrade.com/v1/marketdata/" + symbol + "/pricehistory?apikey=8FBL4ZPB5OPNLAAM90FRWYFKAMYNIVKH&periodType=year&period=1&frequencyType=daily&frequency=1";


                    HttpClient client = new HttpClient();

                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    HttpResponseMessage response = client.GetAsync(url_history).Result;


                    if (response.IsSuccessStatusCode)
                    {

                        string JSON = response.Content.ReadAsStringAsync().Result;
                        //Deserialize to strongly typed class i.e., RootObject
                        RootObject obj = JsonConvert.DeserializeObject<RootObject>(JSON);

                        return obj.candles;
                    }



                    break;
                default:
                    break;
            }


            return null;
        }




        public static MarketQuote GetCurrentMarketData(string symbol, StockExchange exchange)
        {
            string url_currentMarketData;
            MarketQuote marketQuote = new MarketQuote();
            //
            switch (exchange.stockExchange_Name)
            {
                case "NASDAQ":
                    url_currentMarketData = "https://api.tdameritrade.com/v1/marketdata/" + symbol + "/quotes?apikey=8FBL4ZPB5OPNLAAM90FRWYFKAMYNIVKH";
                    try
                    {

                        HttpClient client = new HttpClient();

                        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                        HttpResponseMessage response = client.GetAsync(url_currentMarketData).Result;

                        if (response.IsSuccessStatusCode)
                        {

                            string JSON = response.Content.ReadAsStringAsync().Result;
                            JObject jobject = JObject.Parse(JSON);
                            JToken jStock = jobject[symbol];

                            marketQuote.openPrice = (float)jStock["openPrice"];
                            marketQuote.closePrice =(float) jStock["closePrice"];

                            marketQuote.lastPrice = (float)jStock["lastPrice"];
                            
                            marketQuote.highPrice = (float)jStock["highPrice"];
                            marketQuote.lowPrice = (float)jStock["lowPrice"];

                            marketQuote.netChange = (float)jStock["netChange"];
                            marketQuote.totalVolume = (int)jStock["totalVolume"];
                            marketQuote.volatility = (float)jStock["volatility"];
                            marketQuote.w52WkHigh = (float)jStock["52WkHigh"];
                            marketQuote.w52WkLow = (float)jStock["52WkLow"];
                            marketQuote.markPercentChange = (float)jStock["markPercentChangeInDouble"];

                        }

                        break;

                    }
                    catch (Exception ex)
                    {
                        //log error
                        return null;
                    }


                default:
                    break;


            }

            return marketQuote;

        }
    }

}
