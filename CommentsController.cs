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
            if(!ModelState.IsValid){
                returm CurrentUmbracoPage();
            }
            else
            {
                int userId = 0;
                var content = Current.Services.ContentService.Create(model.Title, CurrentPage.Id, "comment",userId );

                content.SetValue("title", model.Title);
                content.SetValue("creator", model.Name);
                content.SetValue("email", model.Email);
                content.SetValue("comments", model.Comments);

                Umbraco.Core.Service.OperationResult  saveResult =  Current.Services.ContentService.Save(content);

                if(saveResult.Result  == 0 )
                    return RedirectToCurrentUmbracoPage();
            }
        
         return RedirectToCurrentUmbracoPage();

        }
    }
}