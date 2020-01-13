using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;
using WebFormTaskP405.Models;

namespace WebFormTaskP405.Forms
{
    public partial class Profile : System.Web.UI.Page
    {
        PersonDbContext db = new PersonDbContext();

        protected void Page_Load(object sender, EventArgs e)
        {
            DataLoad();
            
        }


        public void DataLoad()
        {
            List<LoginModel> models = new List<LoginModel>();
            using (PersonDbContext db = new PersonDbContext())
            {
                models =  db.People.Select(x => new LoginModel
                {
                    Email = x.Email,
                    Password=x.Password
                }).ToList();

                GridView1.DataSource = models;
                GridView1.DataBind();
            }
        }
    }
}