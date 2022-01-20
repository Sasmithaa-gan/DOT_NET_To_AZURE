using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using task.Models;

namespace task.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Strong()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Strong(Employee emp)
        {

            return View();
        }
        
    }
}




//The HtmlHelper class generates HTML elements.For example,

// @Html.ActionLink("Create New", "Create")
// would generate anchor tag 
//<a href="/Student/Create">Create New</a>.

//-------------------------------------------------------------------------

//1.HTML vs HTML Helper

//<input type=”text” name=”firtsname” id=”firstname” />

//@Html.TextBox(“firstname”) 



//@Html.TextBox(“firstname”, “Pranaya”)

//< input id =”firstname” name =”firstname” type =”text” value =”Pranaya” />
//     ---------------------------------------------------------------------------------

//     2.html attributes

//     @Html.TextBox(“firstname”, “Pranaya”, new { style = “background - color:Red; color:White; font - weight:bold”, title =”Please enter your first name” })

