using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebFormTaskP405.Models;

namespace WebFormTaskP405.Forms
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void register_btn_Click(object sender, EventArgs e)
        {
            RegisterModel registerModel = new RegisterModel()
            {
                Name = txbx_name.Value,
                Surname = txbx_surname.Value,
                Email = txbx_email.Value,
                Password = txbx_password.Value
            };

            ValidationContext validationContext = new ValidationContext(registerModel);
            List<ValidationResult> validationResults = new List<ValidationResult>();
            if (!Validator.TryValidateObject(registerModel, validationContext, validationResults))
            {
                foreach (var result in validationResults)
                {
                    ModelState.AddModelError(result.MemberNames.ToList()[1].ToString(), result.ErrorMessage);
                }

            }
            else
            {
                Models.Person user = new Person
                {
                    Name = registerModel.Name,
                    Surname = registerModel.Surname,
                    Email = registerModel.Email,
                    Password = registerModel.Password,
                    IsLockedOut = false,
                    RegisterDate = DateTime.Now
                };

                Person dbUser = new Person();
                using (PersonDbContext db = new PersonDbContext())
                {
                    dbUser = db.People.Where(x => x.Email == registerModel.Email).FirstOrDefault();
                    if (dbUser == null)
                    {
                        db.People.Add(user);
                        db.SaveChanges();
                        Response.Redirect("Login.aspx");
                    }

                    if (dbUser.Email==user.Email)
                    {
                        ModelState.AddModelError("Email", "Bele bir email movcuddd");
                    }
                }
            }
        }
    }
}