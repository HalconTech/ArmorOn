using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ArmorOn.Models;
using System.Net.Mail;
using System.Net;
using System.Threading.Tasks;
using System.IO;
using CaptchaMvc.HtmlHelpers;
namespace ArmorOn.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        [HttpPost]
        public async Task<ActionResult> Contact(ContactModel model, HttpPostedFileBase fileUploader)
        {
            if (ModelState.IsValid)
            {
                var body = "<p>Email From: {0} ({1})</p><p>Number of Uniforms: {2}</p><p>Mobile Number: {3}</p><p>Date Needed: {4}</p><p>Message:</p><p>{5}</p>";
                var message = new MailMessage();
                message.To.Add(new MailAddress("oliverlacap1995@gmail.com"));  // replace with valid value 
                message.From = new MailAddress(model.EmailAddress);  // replace with valid value
                message.Subject = "Inquiry";
                message.Body = string.Format(body, model.FullName, model.EmailAddress,model.NumberOfUniforms,model.MobileNumber,model.DateNeeded.ToShortDateString(),model.CustomerMessage);
                message.IsBodyHtml = true;
                if (fileUploader != null)
                {
                    string fileName = Path.GetFileName(fileUploader.FileName);
                    message.Attachments.Add(new Attachment(fileUploader.InputStream, fileName));
                }

                using (var smtp = new SmtpClient())
                {
                    //EMAIL NG ARMOR ON
                    var credential = new NetworkCredential
                    {
                        UserName = "oliverlacap1995@gmail.com",  // replace with valid value
                        Password = "johnoliver"  // replace with valid value
                    };
                    smtp.Credentials = credential;
                    smtp.Host = "smtp.gmail.com";
                    smtp.Port = 587;
                    smtp.EnableSsl = true;
                    await smtp.SendMailAsync(message);
                    if (this.IsCaptchaValid("Validate your captcha"))
                    {
                        return RedirectToAction("Index");        
                    }
                    else
                    {
                        ViewBag.ErrorMessage = "Please verify captcha";
                        return View(model);
                    }
                   
                }
            }
           
            return View(model);
        }
        
             public ActionResult Gallery()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

             public ActionResult Shop()
             {
                 ViewBag.Message = "Your contact page.";

                 return View();
             }

             public ActionResult Careers()
             {
                 ViewBag.Message = "Your contact page.";

                 return View();
             }
             public ActionResult Clients()
             {
                 ViewBag.Message = "Your contact page.";

                 return View();
             }

             public ActionResult History()
             {
                 ViewBag.Message = "Your contact page.";

                 return View();
             }
             public ActionResult Vision()
             {
                 ViewBag.Message = "Your contact page.";

                 return View();
             }

        public ActionResult SizeChart()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

    }
}