using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
using System.Configuration;

namespace DemoMvc.Controllers
{
    public class UserController : Controller
    {
        UserContext context = new UserContext();
        SqlConnection connection;

        // GET: User
        [HttpGet]
        public ActionResult Index()
        {
            connection = context.connection;

            String query = "select * from tbl_student";
            SqlCommand cmd = new SqlCommand(query,connection);
            connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            while(reader.Read())
            {
                User u = new User();
                u.id =Convert.ToInt32(reader["Id"]);
                u.name = reader["Name"].ToString();
                u.gender = reader["Gender"].ToString();
                u.city = reader["City"].ToString();

                context.users.Add(u);
            }
            connection.Close();
            return View(context.users);
            //return Json(context.users,JsonRequestBehavior.AllowGet);
        }
    }
}