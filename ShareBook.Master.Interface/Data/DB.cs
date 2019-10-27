using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShareBook.Master.Data
{
  public static class DB
    {

        public static void BuyAction(int StockId ,string Symbol, DateTime TransactionDate, int Quantity, float BuyPrice, int StockExchangeID, int RuleId)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=HOMELAP\\SQLEXPRESS;Initial Catalog=ShareBookDB;Integrated Security=True"; // ConfigurationManager.ConnectionStrings["ShareBookDBConnectionString"].ConnectionString; //  @"Data Source=HOMELAP\SQLEXPRESS;AttachDbFilename=ShareBookDB;Integrated Security=True;User Instance=True";
            SqlCommand cmd;


            try
            {
                cmd = new SqlCommand("InsertStockBuyRequest", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Connection.Open();

                cmd.Parameters.Add("@stock_id", SqlDbType.Int).Value = StockId;
                cmd.Parameters.Add("@symbol", SqlDbType.VarChar).Value = Symbol;
                cmd.Parameters.Add("@transaction_date", SqlDbType.DateTime).Value = TransactionDate;
                cmd.Parameters.Add("@quantity", SqlDbType.Int).Value = Quantity;
                cmd.Parameters.Add("@buyPrice", SqlDbType.Float).Value = BuyPrice;
                cmd.Parameters.Add("@stockexchange_id", SqlDbType.SmallInt).Value = StockExchangeID;
                cmd.Parameters.Add("@rule_id", SqlDbType.SmallInt).Value = RuleId;



                cmd.ExecuteNonQuery();

                cmd.Connection.Close();
                cmd = null;
                con = null;

            }
            catch (Exception ex)
            {
                throw ex;
            }

          
        }

        public static void BuyAction()
        {

        }


        public static void SellAction(int StockId, string Symbol, DateTime TransactionDate, int Quantity, float SellPrice, int StockExchangeID, int RuleId)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=HOMELAP\\SQLEXPRESS;Initial Catalog=ShareBookDB;Integrated Security=True"; // ConfigurationManager.ConnectionStrings["ShareBookDBConnectionString"].ConnectionString; //  @"Data Source=HOMELAP\SQLEXPRESS;AttachDbFilename=ShareBookDB;Integrated Security=True;User Instance=True";
            SqlCommand cmd;


            try
            {
                cmd = new SqlCommand("InsertStockSellRequest", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Connection.Open();

                cmd.Parameters.Add("@stock_id", SqlDbType.Int).Value = StockId;
                cmd.Parameters.Add("@symbol", SqlDbType.VarChar).Value = Symbol;
                cmd.Parameters.Add("@transaction_date", SqlDbType.DateTime).Value = TransactionDate;
                cmd.Parameters.Add("@quantity", SqlDbType.Int).Value = Quantity;
                cmd.Parameters.Add("@sellPrice", SqlDbType.Float).Value = SellPrice;
                cmd.Parameters.Add("@stockexchange_id", SqlDbType.SmallInt).Value = StockExchangeID;
                cmd.Parameters.Add("@rule_id", SqlDbType.Int).Value = RuleId;


                cmd.ExecuteNonQuery();

                cmd.Connection.Close();
                cmd = null;
                con = null;

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public static void SellAction()
        {

        }
    }
}
