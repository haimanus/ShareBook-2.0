
using ShareBook.Master.Data;
using ShareBook.Master.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacTec.TA.Library;

namespace ShareBook.App.Engine.Common.Data
{
 public static  class TaLib
    {
        public static bool UpdateStockObjectWithTechnicalAnalysisData(StockQuote qoute, ref Stock stock)
        {
            //---------variables-----------//
            int count = qoute.stock_candles.Count;
            int outBegIdx = 0;
            int startIdx = 0;
            int endidx = 0;
            int outNBElement = 0;
            int[] outInteger = new int[1];
            double[] outDouble=new double[1];
            float[] outFloat = null;

            float[] inOpen = new float[count];
            float[] inClose = new float[count];
            float[] inHigh = new float[count];
            float[] inLow = new float[count];



            int i = 0;
            int outBegIndex;


            double[] output = new double[1];
            // ---------------------------//




            foreach (Candle candle in qoute.stock_candles)
            {

                inOpen[i] = candle.open;
                inClose[i] = candle.close;
                inHigh[i] = candle.high;
                inLow[i] = candle.low;
                i++;
            }

            Core.RetCode retCode;

            endidx = inOpen.Length;
            startIdx = endidx - 3;



            //200 sma
            retCode = Core.Sma(  startIdx, endidx, inClose, 200, out outBegIndex, out outNBElement, outDouble);
            stock.Sma200d = output[0];

            //retCode = Core.Cdl3LineStrike((startIdx, endidx, inOpen, inHigh, inLow, inClose, 0, out outBegIndex, out outNBElement, outInteger);
            //if (retCode == Core.RetCode.Success)
            //{
            //    stock.JapaneseCandleStickPattern = (JapaneseCandleStick)Enum.Parse(typeof(JapaneseCandleStick), "CdlMorningDojiStar");

            //}

            return false;
        }
    }
}
