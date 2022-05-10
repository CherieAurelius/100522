using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Connected.Controllers
{
    public class CommentsController  :  SurfaceController
    {
        public ActionResult  CommentForm()
        {
            return PartialView("CommentForm", new CommentModel());
        }

        [HttpPost]
        public ActionResult SubmitComment(CommentModel model)
        {
            

        }
    }
}