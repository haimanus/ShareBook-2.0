using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShareBook.Master.Data;

namespace ShareBook.App.UI.Data
{
   public class DB
    {

        public List<StockExchange> GetAllStockExchanges()
        {
            StockExchange _StockExchange = new StockExchange();
            _StockExchange.stockExchange_Name = "NASDAQ";
            _StockExchange.stockExchange_ID = 2;
            List<StockExchange> _StockExchanges = new List<StockExchange>();
            _StockExchanges.Add(_StockExchange);
            return _StockExchanges;
        }
        public Node GetNodeFromConfig()
        {
            Node _Node = new Node();
            _Node.node_name = "node1";
            return _Node;
        }


        public List<StockInfo> GetSymbolsForNode(string exchange, Node node)
        {

            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Data Source=HOMELAP\\SQLEXPRESS;Initial Catalog=ShareBookDB;Integrated Security=True"; // ConfigurationManager.ConnectionStrings["ShareBookDBConnectionString"].ConnectionString; //  @"Data Source=HOMELAP\SQLEXPRESS;AttachDbFilename=ShareBookDB;Integrated Security=True;User Instance=True";
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.Text;

            
            List<StockInfo> _StockInfos = new List<StockInfo>();

            using (connection)
            {


                //get all from DB


                string oString = "Select stock_id,  stock_symbol from stock where active =1 order by stock_symbol ";
                SqlCommand oCmd = new SqlCommand(oString, connection);
                //    oCmd.Parameters.AddWithValue("@Fname", fName);
                connection.Open();
                using (SqlDataReader oReader = oCmd.ExecuteReader())
                {
                    while (oReader.Read())
                    {

                        StockInfo _StockInfo = new StockInfo();
                        _StockInfo.stock_symbol = oReader["stock_symbol"].ToString();
                        _StockInfo.stock_ID = (int) oReader["stock_id"];
                        _StockInfos.Add(_StockInfo);

                    }

                    connection.Close();
                }
            }
            return _StockInfos;
        }

    }
}
