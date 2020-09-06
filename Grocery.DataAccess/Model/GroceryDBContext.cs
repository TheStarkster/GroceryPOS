using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Core.Objects.DataClasses;
using System.Data;
//using System.Data.Entity.Infrastructure;
using System.Data.Entity.Infrastructure;
namespace Grocery.DataAccess.Model
{
    public static class GroceryDML
    {
        public static string GetConnectionStringUsingConfigurationManager(string nameOfConnectionString)
        {
            return System.Configuration.ConfigurationManager.ConnectionStrings[nameOfConnectionString].ToString();
        }
        public static string GetConnectionString(string nameOfConnectionString)
        {
            //null indicates default web.config
            //you can set it to what ever config file in you need
            //Grocery.DataAccess
            //System.Configuration.Configuration config =
            //System.Web.Configuration.WebConfigurationManager.OpenWebConfiguration("~/Grocery.Admin");
 
            return ConfigurationManager.ConnectionStrings["GroceryDBContext"].ToString();

            //if (config.ConnectionStrings.ConnectionStrings.Count > 0)
            //{
            //    var connString = config.ConnectionStrings.ConnectionStrings[nameOfConnectionString].ToString();
            //    return connString;
            //}
            //return "";
        }
        static string GetApplicationSettings(string sKey)
        {
            string sValue = null;
            System.Configuration.Configuration rootWebConfig =
               System.Web.Configuration.WebConfigurationManager.OpenWebConfiguration("~/Grocery.Admin");
            //check if the AppSettings section has items

            if (rootWebConfig.AppSettings.Settings.Count > 0)
            {
                sValue = rootWebConfig.AppSettings.Settings[sKey].Value;
            }
            return sValue;
        }
        //System.Configuration.Configuration rootWebConfig1;
        // public static string HitchConnectionStr = rootWebConfig1.AppSettings.Settings.Item("ConnectionString").Value;
        // public static string HitchConnectionStr = System.Configuration.ConfigurationManager.ConnectionStrings["HitchDBContext"].ToString();
        private static SqlConnection SqlConnectionVar = null;
        public static SqlConnection Connection
        {
            get
            {
                if (SqlConnectionVar == null || SqlConnectionVar.ConnectionString == "")
                {
                    SqlConnectionVar = new SqlConnection(GetConnectionString("GroceryDBContext"));
                }
                return SqlConnectionVar;
            }
            set { }
        }
        static DataSet ds;
        public static DataSet DQL(string Query)
        {
            try
            {
                ds = new DataSet();
                new SqlDataAdapter(Query, Connection).Fill(ds);

            }
            catch (Exception)
            {
            }
            return ds;
        }
        public static int DML(string Query)
        {
            try
            {
                Connection.Close();
                if (Connection.State != ConnectionState.Open)
                {
                    Connection.Open();
                }
                return new SqlCommand(Query, Connection).ExecuteNonQuery();
            }
            catch (Exception)
            {
            }
            return 0;
        }
    }
    public class GroceryDBContext : DbContext
    {
        public GroceryDBContext()
            : base("GroceryDBContext")

        { this.Configuration.LazyLoadingEnabled = false; }
        public virtual DbSet<branch_master> branch_masters { get; set; }
        public virtual int SP_Branch(Nullable<int> aCTION, string id, string name, string loca, string addr, string cntct, string trno, string shopname, string shopnamenew)
        {
            var aCTIONParameter = aCTION.HasValue ?
                new ObjectParameter("ACTION", aCTION) :
                new ObjectParameter("ACTION", typeof(int));

            var idParameter = id != null ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(string));

            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));

            var locaParameter = loca != null ?
                new ObjectParameter("loca", loca) :
                new ObjectParameter("loca", typeof(string));

            var addrParameter = addr != null ?
                new ObjectParameter("addr", addr) :
                new ObjectParameter("addr", typeof(string));

            var cntctParameter = cntct != null ?
                new ObjectParameter("cntct", cntct) :
                new ObjectParameter("cntct", typeof(string));

            var trnoParameter = trno != null ?
                new ObjectParameter("trno", trno) :
                new ObjectParameter("trno", typeof(string));

            var shopnameParameter = shopname != null ?
                new ObjectParameter("shopname", shopname) :
                new ObjectParameter("shopname", typeof(string));

            var shopnamenewParameter = shopnamenew != null ?
                new ObjectParameter("shopnamenew", shopnamenew) :
                new ObjectParameter("shopnamenew", typeof(string));

            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_Branch", aCTIONParameter, idParameter, nameParameter, locaParameter, addrParameter, cntctParameter, trnoParameter, shopnameParameter, shopnamenewParameter);
        }

    }
}
