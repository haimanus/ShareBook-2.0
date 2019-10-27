using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShareBook.Master.Interface;

using ShareBook.Master.Data;
using ShareBook.App.UI.Data;
using ShareBook.App.Engine;


namespace ShareBook.App.UI
{
    public partial class Home : Form
    {
        private IContainer components;

        public Home()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'shareBookDBDataSet.stock' table. You can move, or remove it, as needed.
            this.stockTableAdapter.Fill(this.shareBookDBDataSet.StockInfoDB);

        }

        private void btnGetdata_Click(object sender, EventArgs e)
        {
            Actions actions = new Actions();
            UI.Data.DB db = new UI.Data.DB();
            List<StockInfo> stockInfos = new List<StockInfo>();

         
          
            

            StockExchange stock_exchange = db.GetAllStockExchanges().First();//change to loop later            
            Node node = db.GetNodeFromConfig();
            


            stockInfos = db.GetSymbolsForNode(stock_exchange.stockExchange_Name, node);//get all symbols for this node
            //prgIncrement = stockInfos.Count;
            //prgIncrement = 100 / prgIncrement;
            Console.WriteLine("Started at " + DateTime.Now);

            int icount = 0;
            foreach (StockInfo stockinfo in stockInfos)
            {
                icount++;
                try
                {
                    bool result_processing = false;
                    result_processing = actions.ProcessRules(stockinfo, stock_exchange);

                  

                    // prgStocks.Value += 1;


                    DataGridViewRow grdFetchStatus_row = (DataGridViewRow)grdFetchStatus.Rows[0].Clone();
                    grdFetchStatus_row.Cells[0].Value = stockinfo.stock_symbol;
                    Console.WriteLine(icount + ")  "  + stockinfo.stock_symbol + "   " + "Done !" );

                    if (result_processing)
                    {


                        grdFetchStatus_row.Cells[1].Value = "Y";

                    }
                    else
                    {
                        grdFetchStatus_row.Cells[1].Value = "X";
                    }
                    grdFetchStatus.Rows.Add(grdFetchStatus_row);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(stockinfo.stock_symbol + "   " + "ERR at button click !");
                    DataGridViewRow grdFetchStatus_row = (DataGridViewRow)grdFetchStatus.Rows[0].Clone();
                    grdFetchStatus_row.Cells[0].Value = stockinfo.stock_symbol;
                    grdFetchStatus_row.Cells[1].Value = "F";
                    grdFetchStatus.Rows.Add(grdFetchStatus_row);
                }


            }

            Console.WriteLine("Completed at " + DateTime.Now);
        }
    }
}

