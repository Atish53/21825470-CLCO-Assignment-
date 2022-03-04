using _21825470_CLCO_Assignment_1.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _21825470_CLCO_Assignment_1
{
    public partial class _Default : Page
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            if (CheckBox1.Checked || CheckBox2.Checked || CheckBox3.Checked)
            {
                var UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(db));
                ApplicationUser currentUser = UserManager.FindById(User.Identity.GetUserId());
                if (CheckBox1.Checked && CheckBox2.Checked == false && CheckBox3.Checked == false)
                {
                    currentUser.Option = 1;
                    currentUser.Data = 500;
                    currentUser.Price = 50;
                    currentUser.Minutes = 300;
                }
                else if (CheckBox1.Checked == false && CheckBox2.Checked && CheckBox3.Checked == false)
                {
                    currentUser.Option = 2;
                    currentUser.Data = 700;
                    currentUser.Price = 75;
                    currentUser.Minutes = 500;
                }
                else if (CheckBox1.Checked == false && CheckBox2.Checked == false && CheckBox3.Checked)
                {
                    currentUser.Option = 3;
                    currentUser.Data = 1000;
                    currentUser.Price = 100;
                    currentUser.Minutes = 1000;
                }
            }
            else if (CheckBox1.Checked && (CheckBox2.Checked || CheckBox3.Checked))
            {
                
            }
            db.SaveChangesAsync();
        }
    }
}