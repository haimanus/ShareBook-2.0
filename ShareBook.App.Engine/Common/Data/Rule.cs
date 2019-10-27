using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShareBook.App.Engine.Common.Data
{
   public  class CERule
    {

       

            public int RuleID { get; set; }
            public string RuleName { get; set; }
            public string RuleDescription { get; set; }
            public string RuleXml { get; set; }
            public string RuleText { get; set; }
            public int RuleType { get; set; }
            public int ExecutionOrder { get; set; }
       
    }
}
