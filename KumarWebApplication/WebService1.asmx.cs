using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using Newtonsoft.Json;

namespace KumarWebApplication
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        DataTable dtCountries = new DataTable();

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        string c;




        [WebMethod]
        public string NoWayy()
        {
            c = "No way";
            return c;
        }


        [WebMethod]
        public int sum(int a, int b)
        {
            return a + b;
        }

        [WebMethod]
        public string Countries()
        {
            dtCountries.Columns.Add("Countries");
            dtCountries.Columns.Add("Continenet");

            dtCountries.Rows.Add("Pakistan", "Asia");
            dtCountries.Rows.Add("India", "Asia");
            dtCountries.Rows.Add("Germany", "Europe");
            dtCountries.Rows.Add("Denmark", "Europe");
            dtCountries.Rows.Add("Finland", "Europe");
            dtCountries.Rows.Add("USA", "North America");
            dtCountries.Rows.Add("New Zealand", "Oceania");


            //return dtCountries.ToString();
            
            return JsonConvert.SerializeObject(dtCountries);

        }
    }
}
