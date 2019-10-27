using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShareBook.Master.Data;

namespace ShareBook.App.Engine.Common.Data
{
   public  static class MarketData
    {
        public static bool UpdateStockObjectWithMarketData(MarketQuote marketQoute, ref Stock e_stock)
        {

            try
            {
                e_stock.today_Close = marketQoute.closePrice;

                e_stock.today_High = marketQoute.highPrice;
                e_stock.today_Low = marketQoute.lowPrice;
                e_stock.today_Open = marketQoute.openPrice;
                e_stock.today_Close = marketQoute.closePrice;
                e_stock.today_Volume = marketQoute.totalVolume;
                e_stock.volatility = marketQoute.volatility;
                e_stock.week52High = marketQoute.w52WkHigh;
                e_stock.week52Low = marketQoute.w52WkLow;
                e_stock.netChange = marketQoute.netChange;
                e_stock.last_Price = marketQoute.lastPrice;
                return true;
            }
            catch (Exception)
            {

                return false; ;
            }
            
        }


        public static bool UpdateStockObjectWithPreviousDayData(StockQuote quote, ref Stock e_stock)
        {

            try
            {
                ////fill yesterday value
                e_stock.previousDay_Open = quote.stock_candles.Last().open;
                e_stock.previousDay_Close = quote.stock_candles.Last().close;
                e_stock.previousDay_High = quote.stock_candles.Last().high;
                e_stock.previousDay_Low = quote.stock_candles.Last().low;
                e_stock.previousDay_Volume = quote.stock_candles.Last().volume;
                e_stock.PreviousTradeDay = quote.stock_candles.Last().trade_date;

                return true;
            }
            catch (Exception)
            {

                return false; ;
            }

        }
    }
}
