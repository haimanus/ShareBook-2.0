using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShareBook.Master.Data
{
    public class StockInfo
    {
        public int stock_ID { get; set; }
        public string stock_symbol { get; set; }
        public string stock_name { get; set; }
        public DateTime last_updated { get; set; }
        public bool active;
    }
    public class StockQuote
    {


        public string stock_symbol { get; set; }
        public DateTime transaction_date { get; set; }
        public List<Candle> stock_candles { get; set; }



       


    }
    public class StockExchange
    {
        public int stockExchange_ID { get; set; }
        public string stockExchange_Name { get; set; }
        public string country { get; set; }
    }
    public class Node
    {
        public string node_name { get; set; }
    }
    public class Candle
    {

        public float open { get; set; }
        public float high { get; set; }
        public float low { get; set; }
        public float close { get; set; }
        public int volume { get; set; }
        public long datetime { get; set; }
        public DateTime trade_date
        {

            get
            {
    
              
                DateTimeOffset dateTimeOffset = DateTimeOffset.FromUnixTimeMilliseconds(datetime);
                return dateTimeOffset.DateTime;
            }
           
        }
    }


    public class MarketQuote
    {
        public string assetType { get; set; }
        public string symbol { get; set; }
        public string description { get; set; }
        public int bidPrice { get; set; }
        public int bidSize { get; set; }
        public string bidId { get; set; }
        public float askPrice { get; set; }
        public int askSize { get; set; }
        public string askId { get; set; }
        public float lastPrice { get; set; }
        public int lastSize { get; set; }
        public string lastId { get; set; }
        public float openPrice { get; set; }
        public float highPrice { get; set; }
        public float lowPrice { get; set; }
        public string bidTick { get; set; }
        public float closePrice { get; set; }
        public float netChange { get; set; }
        public int totalVolume { get; set; }
        public long quoteTimeInLong { get; set; }
        public long tradeTimeInLong { get; set; }
        public float mark { get; set; }
        public string exchange { get; set; }
        public string exchangeName { get; set; }
        public bool marginable { get; set; }
        public bool shortable { get; set; }
        public float volatility { get; set; }
        public int digits { get; set; }
        public float w52WkHigh { get; set; }
        public float w52WkLow { get; set; }
        public int nAV { get; set; }
        public float peRatio { get; set; }
        public int divAmount { get; set; }
        public int divYield { get; set; }
        public string divDate { get; set; }
        public string securityStatus { get; set; }
        public float regularMarketLastPrice { get; set; }
        public int regularMarketLastSize { get; set; }
        public float regularMarketNetChange { get; set; }
        public long regularMarketTradeTimeInLong { get; set; }
        public float netPercentChange { get; set; }
        public float markChange { get; set; }
        public float markPercentChange { get; set; }
        public float regularMarketPercentChange { get; set; }
        public bool delayed { get; set; }
    }


    public enum JapaneseCandleStick
    {
        Any,
        MorningDojiStar,
        Unknown
    }

    public enum Industry
    {
        CapitalGoods,
        HealthCare,
        Finance,
        InvestorsServices,
        ConsumerServices,
        SavingsInstitutions,
        MajorBanks,
        Technology,
        BusinessServices,
        EDPServices,
        MajorPharmaceuticals,
        TelecommunicationsEquipment,
        OilandGasProduction,
        MultiSectorCompanies,
        Biotechnology,
        MedicalDental,
        Semiconductors,
        PublicUtilities,
        BasicIndustries

    }


}
