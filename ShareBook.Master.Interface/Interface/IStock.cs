using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShareBook.Master.Data;
namespace ShareBook.Master.Interface
{
    public interface IStock
    {
        JapaneseCandleStick JapaneseCandleStickPattern { get; set; }
        Industry StockIndustry { get; set; }


        float Open { get; set; }
        float Close { get; set; }
        float High { get; set; }
        float Low { get; set; }

        float Volume { get; set; }
      

        DateTime Today { get; set; }

        float IVX { get; set; }

        double Sma200d { get; set; }



        void Register(int buy_value);
    }
   
}
