using ShareBook.App.Engine.Common.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShareBook.App.Engine.Common.Data
{
  public static class DB
    {
        public static bool InsertStocksToBuy()
        {
            return false;
        }

        public static List<CERule> LoadRuleXml(int ruleType)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=HOMELAP\\SQLEXPRESS;Initial Catalog=ShareBookDB;Integrated Security=True"; // ConfigurationManager.ConnectionStrings["ShareBookDBConnectionString"].ConnectionString; //  @"Data Source=HOMELAP\SQLEXPRESS;AttachDbFilename=ShareBookDB;Integrated Security=True;User Instance=True";
            SqlCommand cmd;

            List<CERule> rules = new List<CERule>();


            try
            {

               
                cmd = new SqlCommand("GetRules", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection.Open();
                cmd.Parameters.Add("@RuleType", SqlDbType.Int).Value = ruleType;
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    CERule rule = new CERule();

                    rule.RuleID = Convert.ToInt32(dr["RuleID"]);
                    rule.RuleName = Convert.ToString(dr["RuleName"]);
                    rule.RuleDescription = Convert.ToString(dr["RuleDescription"]);
                    rule.RuleType = 1;
                    rule.RuleXml = Convert.ToString(dr["RuleXml"]);
                    rule.RuleText = Convert.ToString(dr["RuleText"]);
                    rule.ExecutionOrder = Convert.ToInt32(dr["ExecutionOrder"]);
                    rules.Add(rule);


                }
                cmd.Connection.Close();
            }
            catch (Exception ex)
            {
                rules = null;
                throw ex;
            }
            finally
            {

                con = null;
                cmd = null;
            }

            return rules;
        }
    }
}
