using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SitecoreBlogHelix.Feature.SitecoreBlog.Models;
using Sitecore.Web.UI.WebControls;

namespace SitecoreBlogHelix.Feature.SitecoreBlog.Controllers
{
    //SitecoreBlogHelix.Feature.SitecoreBlog.Controllers.PostcardController,SitecoreBlogHelix.Feature.SitecoreBlog
    public class PostcardController : Controller
    {
        // GET: Postcard
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Postcard()
        {
            var result = new List<ArticleModel>();
            try
            { 
                Sitecore.Data.Database db = Sitecore.Configuration.Factory.GetDatabase("web");
                Sitecore.Data.Items.Item[] items = db.SelectItems(@"fast:/sitecore/content/SitecoreBlog/Home/Article//*[@@templateid ='{96E980FC-AAC5-4A65-9501-5CB02FA81DBF}']");
                //collect all items 
                foreach(var i in items)
                {
                    result.Add(new ArticleModel
                    {
                        Title = FieldRenderer.Render(i, "Title"),
                        ShortDescription = FieldRenderer.Render(i, "ShortDescription"),
                        PosteDate = FieldRenderer.Render(i, "PostedDate"),
                        ArticleShortImage = FieldRenderer.Render(i , "ArticleSmallImage"),
                        Author = FieldRenderer.Render(i, "Autor"),
                        Category = FieldRenderer.Render(i, "Category"),

                    });
                }
               
            }
            catch(Exception ex)
            {
                Console.WriteLine("Somthing went wrong");
            }
            finally
            {
                Console.WriteLine("Try catch block completed");
            }
            return View("~/Views/SitecoreBlog/Postcard.cshtml", result);
        }
    }
}