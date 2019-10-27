using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShareBook.Master.Interface;
using ShareBook.Master.Data;
using CodeEffects.Rule.Attributes;
using CodeEffects.Rule.Common;

namespace ShareBook.Master.Data
{
    public class Stock 
    {
        [ExcludeFromEvaluation]
        public string Symbol;

        [ExcludeFromEvaluation]
        public int StockID;

        [ExcludeFromEvaluation]
        public int StockExchangeID;

        [ExcludeFromEvaluation]
        public int RuleID;

        //_________________________________________________________________________________________
         [Field(DisplayName = "Today",Settable =false, Description = "If rule execution date is Today")]
        //[ExcludeFromEvaluation]
        public DateTime Today { get; set; }

        //[Method("Today", "If rule execution date is Today")]
        //public DateTime _Today()
        //{
        //    return Today;
        //}


        //_________________________________________________________________________________________

         [Field(DisplayName = "Previous Trade Date", Settable = false, Description = "Previous trade Date")]
       // [ExcludeFromEvaluation]
        public DateTime PreviousTradeDay { get; set; }

        //[Method("Previous Trade Date", "Previous trade Date")]
        //public DateTime _PreviousTradeDay()
        //{
        //    return PreviousTradeDay;
        //}

        //_________________________________________________________________________________________

         [Field(Min = 0, Max = 99999, Settable = false, DisplayName = "52 Week Low", Description = "52 Week Low Price")]
        //[ExcludeFromEvaluation]
        public float week52Low { get; set; }

        //[Method("52 Week Low", "52 Week Low Price")]
        //public float _Week52Low()
        //{
        //    return week52Low;
        //}


        //_________________________________________________________________________________________

        [Field(Min = 0, Max = 99999, Settable = false, DisplayName = "52 Week High", Description = "52 Week High Price")]
       // [ExcludeFromEvaluation]
        public float week52High { get; set; }

        //[Method("52 Week High", "52 Week High Price")]
        //public float _week52High()
        //{
        //    return week52High;
        //}
        //_________________________________________________________________________________________

        [Field( Min = 0, Max = 99999, ValueInputType = ValueInputType.Fields, Settable = false, DisplayName = "Volatility", Description = "Volatility factor")]
       // [ExcludeFromEvaluation]
        public float volatility { get; set; }

        //[Method("Volatility", "Volatility factor")]
        //public float _volatility()
        //{
        //    return volatility;
        //}

        //_________________________________________________________________________________________

        [Field(Min = 0, Max = 99999, Settable = false, DisplayName = "Last Price", Description = "Last Traded Price")]
      //  [ExcludeFromEvaluation]
        public float last_Price { get; set; }

        //[Method("Last Price", "Last Traded Price")]
        //public float _last_Price()
        //{
        //    return last_Price;
        //}
        //_________________________________________________________________________________________

         [Field(Min = 0, Max = 99999, Settable = false, DisplayName = "Net Change", Description = "Net Change")]
       // [ExcludeFromEvaluation]
        public float netChange { get; set; }

        //[Method("Net Change", "Net Change")]
        //public float _netChange()
        //{
        //    return netChange;
        //}

        //_________________________________________________________________________________________

        //yestreday or earlier
        [Field(Min = 0, Max = 99999, Settable = false, DisplayName = "Previous Day's Open Price", Description = "Market Open Price")]
        //[ExcludeFromEvaluation]
        public float previousDay_Open { get; set; }

        //[Method("Previous Day's Open Price", "Yesterday's Open Price")]
        //public float _previousDay_Open()
        //{
        //    return previousDay_Open;
        //}

        //_________________________________________________________________________________________

         [Field(Min = 0, Max = 99999, Settable = false, DisplayName = "Previous Day's Close Price", Description = "Market Close Price")]
       // [ExcludeFromEvaluation]
        public float previousDay_Close { get; set; }

        //[Method("Previous Day's Close Price", "Yesterday's Close Price")]
        //public float _previousDay_Close()
        //{
        //    return previousDay_Close;
        //}

        //_________________________________________________________________________________________

       [Field(Min = 0, Max = 99999, Settable = false, DisplayName = "Previous Day's High Price", Description = "Day High Price")]
       // [ExcludeFromEvaluation]
        public float previousDay_High { get; set; }

        //[Method("Previous Day's High Price", "Yesterday's High Price")]
        //public float _previousDay_High()
        //{
        //    return previousDay_High;
        //}


        //_________________________________________________________________________________________


         [Field(Min = 0, Max = 99999, Settable = false, DisplayName = "Previous Day's Low Price", Description = "Day Low Price")]
        //[ExcludeFromEvaluation]
        public float previousDay_Low { get; set; }

        //[Method("Previous Day's Low Price", "Yesterday's Low Price")]
        //public float _previousDay_Low()
        //{
        //    return previousDay_Low;
        //}


        //_________________________________________________________________________________________

        [Field(Min = 0, Max = 99999999, Settable = false, DisplayName = "Previous Day's Volume", Description = "Yesterday's Volume Traded")]
        //[ExcludeFromEvaluation]
        public float previousDay_Volume { get; set; }

        //[Method("Previous Day's Volume", "Yesterday's Volume")]
        //public float _previousDay_Volume()
        //{
        //    return previousDay_Volume;
        //}

        //_________________________________________________________________________________________

        //today or current
         [Field(Min = 0, Max = 99999, Settable = false, DisplayName = "Today's Open Price", Description = "Market Open Price")]
        //[ExcludeFromEvaluation]
        public float today_Open { get; set; }

        //[Method("Today's Open Price", "Today's Open Price")]
        //public float _today_Open()
        //{
        //    return today_Open;
        //}

        //_________________________________________________________________________________________

        [Field(Min = 0, Max = 99999, Settable = false, DisplayName = "Today's Close Price", Description = "Market Close Price")]
      //  [ExcludeFromEvaluation]
        public float today_Close { get; set; }

        //[Method("Today's Close Price", "Today's Close Price")]
        //public float _today_Close()
        //{
        //    return today_Close;
        //}

        //_________________________________________________________________________________________

           [Field(Min = 0, Max = 99999, Settable = false, DisplayName = "Today's High Price", Description = "Day High Price")]
      //  [ExcludeFromEvaluation]
        public float today_High { get; set; }

        //[Method("Today's High Price", "Today's High Price")]
        //public float _today_High()
        //{
        //    return today_High;
        //}
        //_________________________________________________________________________________________

         [Field(Min = 0, Max = 99999, Settable = false, DisplayName = "Today's Low Price", Description = "Day Low Price")]
       // [ExcludeFromEvaluation]
        public float today_Low { get; set; }

        //[Method("Today's Low Price", "Today's Low Price")]
        //public float _today_Low()
        //{
        //    return today_Low;
        //}

        //_________________________________________________________________________________________

        [Field(Min = 0, Max = 99999999, Settable = false, DisplayName = "Today's Volume", Description = "Today's Volume Traded")]
       // [ExcludeFromEvaluation]
        public float today_Volume { get; set; }

        //[Method("Today's Volume", "Today's Volume")]
        //public float _today_Volume()
        //{
        //    return today_Volume;
        //}
        //_________________________________________________________________________________________

         [Field(ValueInputType = ValueInputType.Fields,Settable =false, DisplayName = "Stock Industry", Description = "Select Industry the Stock belong to")]
       // [ExcludeFromEvaluation]
        public Industry StockIndustry { get; set; }

        //[Method("Stock Industry", "Select Industry the Stock belong to")]
        //public Industry _StockIndustry()
        //{
        //    return StockIndustry;
        //}

        //_________________________________________________________________________________________

         [Field(Min = 0, Max = 99, Settable = false, DisplayName = "IVX", Description = "IVX Sentiments")]
      //  [ExcludeFromEvaluation]
        public float IVX { get; set; }

        //[Method("IVX", "IVX")]
        //public float _IVX()
        //{
        //    return IVX;
        //}

        //_________________________________________________________________________________________

        [Field(Min = 0, Max = 99999, Settable = false, DisplayName = "SMA 200 days", Description = "SMA 200 days")]
      //  [ExcludeFromEvaluation]
        public double Sma200d { get; set; }

        //[Method("SMA 200 days", "SMA 200 days")]
        //public double _Sma200d()
        //{
        //    return Sma200d;
        //}
        //_________________________________________________________________________________________


        [Parent("JapaneseCandleStick", "Japanese CandleStick", "Japanese CandleStick Pattern formed")]          
      //   [ExcludeFromEvaluation]
        [Field( ValueInputType = ValueInputType.Fields, Settable = false, DisplayName = "Japanese CandleStick Pattern", Description = "Select Japanese CandleStick Pattern")]
        public JapaneseCandleStick JapaneseCandleStickPattern { get ; set ; }


        //[Method("Japanese CandleStick Pattern formed", "Japanese CandleStick Pattern", IncludeInCalculations = false)]
        //public JapaneseCandleStick _JapaneseCandleStickPattern()
        //{
        //    return JapaneseCandleStickPattern;
        //}

        //_________________________________________________________________________________________

        //actions//
        [Field(Gettable = false,  IncludeInCalculations =false, ValueInputType = ValueInputType.All, Min = 0, Max = 99999, DisplayName = "Buy Price", Description = "Set the buy Price")]
        public float BuyingPrice { get; set; }

        [Field(Gettable = false, IncludeInCalculations = false, ValueInputType = ValueInputType.All, Min = 0, Max = 99999, DisplayName = "Buy Quantity", Description = "Set the buy quantity")]
        public int BuyQty { get; set; }

        [Field(Gettable = false, IncludeInCalculations = false, ValueInputType = ValueInputType.All, Min = 0, Max = 99999, DisplayName = "Sell Price", Description = "Set the sell Price")]
        public float SellingPrice { get; set; }

        [Field(Gettable = false, IncludeInCalculations = false, ValueInputType = ValueInputType.All, Min = 0, Max = 99999, DisplayName = "Sell Quantity", Description = "Set the sell quantity")]
        public int SellQty { get; set; }

        [Action("Buy At", "Initiate Buy signal")]
        public void Buy([Parameter(ValueInputType.All, Description = "Buy Price")]  float BuyValue)
        {
            //db.save;
            DB.BuyAction(StockID,  Symbol,DateTime.Now, BuyQty, BuyValue, StockExchangeID,RuleID);


        }




        //[Action("Buy", "Initiate Buy signal")]
        //public void Buy()
        //{
        //    //db.save;
        //    DB.BuyAction(StockID, Symbol, DateTime.Now, BuyQty, BuyingPrice, StockExchangeID,RuleID);


        //}

        [Action("Buy At Market Rate", "Initiate Buy signal")]
        public void BuyAtMarketRate()
        {
            //db.save;
            DB.BuyAction(StockID, Symbol, DateTime.Now, BuyQty, 0, StockExchangeID, RuleID);


        }


        [Action("Sell At", "Initiate Sell signal")]
        public void Sell([Parameter(ValueInputType.All, Description = "Sell Price")]  float SellValue)
        {
            //db.save;
           // DB.SellAction(Symbol, DateTime.Now, BuyQty, SellValue);


        }


        [Action("Sell", "Initiate Sell signal")]
        public void Sell()
        {
            //db.save;
            DB.SellAction(StockID, Symbol, DateTime.Now, SellQty, SellingPrice, StockExchangeID, RuleID);


        }
    }
}
