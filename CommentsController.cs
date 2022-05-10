using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Connected.Controllers
{
    public class CommentsController  :  Controller 
    {
        public ActionResult  Index()
        {
            return View ();
        }
    }
}