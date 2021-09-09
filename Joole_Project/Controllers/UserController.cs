using Joole_DataAccess;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity.Validation;

namespace Joole_Project.Controllers
{
    public class UserController : Controller
    {
        private JooleDBEntities1 db = new JooleDBEntities1();

        // GET: User
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Auth(User user) 
        {
            using (JooleDBEntities1 db = new JooleDBEntities1())
            {
                //if username entered or email entered matches with database username or email AND entered password matches with password in database then implement success
                if (db.Users.Any(x=> (x.User_Name == user.User_Name || x.User_Email == user.User_Email) && x.User_Password == user.User_Password))
                {
                    ViewBag.SuccessMessage = "Successful Login";
                    return RedirectToAction("Search", "Search");
                }

                else
                {
                    user.LoginErrorMessage = "Wrong Username or Password";
                    return View("Login", user);
                }
            }
        }

        public ActionResult SignUp()
        {
            User user = new User();
            return View(user);
        }

        [HttpPost]
        public ActionResult SignUp(User user, HttpPostedFileBase file)
        {
            User usr = new User();
            using (JooleDBEntities1 db = new JooleDBEntities1())
            {
                //check if username exists
                if (db.Users.Any(x=> x.User_Name == user.User_Name))
                {
                    ViewBag.DuplicateMessage = "Username is already in use";
                    return View("SignUp", user);
                }
                else
                {
                    if (file != null && file.ContentLength > 0)
                    {
                        try
                        {
                            byte[] bytes = null;
                            using (var binaryReader = new BinaryReader(file.InputStream))
                            {
                                bytes = binaryReader.ReadBytes(file.ContentLength);
                            }

                            user.User_Image = bytes;
                            ViewBag.Message = "Successful Upload";
                        }
                        catch
                        {
                            ViewBag.Message = "Failed Image Upload";
                        }
                    }
                    else { ViewBag.Message = "There is no file"; }

                    try
                    {
                        db.Users.Add(user);

                        db.SaveChanges();

                        ModelState.Clear();

                        ViewBag.SuccessMessage = "Saved";
                        return View("SignUp", new User());
                    }
                    catch (DbEntityValidationException)
                    {

                        ViewBag.ErrorMessage = "Required fields need to be filled";
                        return View("SignUp", user);
                    }
                }
            }
        }
    }
}