using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;
namespace DemoMvc
{
    public class UserContext
    {
        public  UserContext()
        {
              this.connection = new SqlConnection(ConfigurationManager.ConnectionStrings["UserConnection"].ConnectionString);
         }
       

        public SqlConnection connection { get; set; }
        public List<User> users = new List<User>();


    }
}