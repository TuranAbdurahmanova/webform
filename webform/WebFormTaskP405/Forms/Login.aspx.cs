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
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void login_btn_Click(object sender, EventArgs e)
        {
            LoginModel loginModel = new LoginModel
            {
                Email = txbx_email.Value,
                Password = txbx_password.Value
            };

            ValidationContext validationContext = new ValidationContext(loginModel);
            List<ValidationResult> validationResults = new List<ValidationResult>();
            if (!Validator.TryValidateObject(loginModel, validationContext, validationResults))
            {
                foreach (var result in validationResults)
                {
                    ModelState.AddModelError(result.MemberNames.ToList()[1].ToString(), result.ErrorMessage);
                }

            }
            else
            {
                Models.Person currentUser = new Person();
                using (PersonDbContext person = new PersonDbContext())
                {
                    currentUser = person.People.Where(x => x.Email == loginModel.Email && x.Password == loginModel.Password).FirstOrDefault();
                }

                if (currentUser?.IsLockedOut == false)
                {
                    Response.Redirect("Profile.aspx");
                }
                else
                    if (currentUser?.IsLockedOut == true)
                {
                    ModelState.AddModelError("", "User blocked!Please contact with Administrator");
                }
                else
                {
                    ModelState.AddModelError("", "User email or password is not valid");
                }
            }
        }
    }
}
