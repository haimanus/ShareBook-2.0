using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShareBook.App.DataReader;

using ShareBook.Master.Data;

using ShareBook.Master;
using TicTacTec.TA.Library;
using ShareBook.App.Engine.Common.Data;
using CodeEffects.Rule.Core;

namespace ShareBook.App.Engine
{
    public class Actions
    {


        public bool ProcessRules(StockInfo stockInfo, StockExchange stockExchange)//int ruleType, symbol, ruleXML
        {




            bool result_TaLib = false;
            bool result_PriceBar = false;
            bool result_PrevioudDayPriceBar = false;
            bool result_CurrentDayPriceBar = false;
            bool result_Indices = false;
            bool result_Sentiments = false;
            bool result_NASDAQindicator = false;
            MarketQuote marketQoute = new MarketQuote();

            //create Stock object which is the feed for Codefeects rule engine
            Stock e_stock = new Stock();
            e_stock.Symbol = stockInfo.stock_symbol;
            e_stock.StockID = stockInfo.stock_ID;
            e_stock.StockExchangeID = stockExchange.stockExchange_ID;

            try
            {
                // fill with market data - open close high low
               
                marketQoute = APIReader.GetCurrentMarketData(stockInfo.stock_symbol, stockExchange);
            }
            catch (Exception)
            {

                Console.WriteLine("ERR in GetCurrentMarketData()");
            }
           
              result_CurrentDayPriceBar = MarketData.UpdateStockObjectWithMarketData(marketQoute, ref e_stock);

            //get History data
            List<Candle> candles = new List<Candle>();
            try
            {
                candles = APIReader.GetPriceHistory(stockInfo.stock_symbol, stockExchange);
            }
            catch (Exception)
            {

                Console.WriteLine("ERR in GetPriceHistory()");
            }

          
            //build a stock qoute object which will be used for all other calculations. this is holding data which needs for other analysis
            StockQuote stockQuote = new StockQuote();
            stockQuote.stock_candles = candles;

            //fill with previous day market data
            result_PrevioudDayPriceBar = MarketData.UpdateStockObjectWithPreviousDayData(stockQuote, ref e_stock);

            //fill with Talib values
         //   result_TaLib = TaLib.UpdateStockObjectWithTechnicalAnalysisData(stockQuote, ref e_stock);


            //get volatality factor)
            result_Indices = Indices.UpdateStockObjectWithIndicesData(stockQuote, ref e_stock);


            //Get sentinments)
            result_Sentiments = Sentiments.UpdateStockObjectWithSentimentData(ref e_stock);





            //get rule xml

            //if (ruleType == 1) //execute
            //{
            //    ///execute rule xml
            /// //// Get the rule XML


            //// Load Rule XML from the storage as a string
            List<CERule> rules = new List<CERule>();
            rules = ShareBook.App.Engine.Common.Data.DB.LoadRuleXml(1);
            foreach (CERule rule in rules)
            {
                Evaluator<Stock> evaluator = new Evaluator<Stock>(rule.RuleXml);

                try
                {

                    e_stock.RuleID = rule.RuleID;
                    // Evaluate the rule against the patient
                    bool success = evaluator.Evaluate(e_stock);



                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("ERR at rule evaluation-DivideByZeroException");
                    return false;
                }
                catch (FormatException)
                {
                    Console.WriteLine("ERR at rule evaluation-FormatException");
                    return false;
                }


            }
            return true;
        }




    }

}