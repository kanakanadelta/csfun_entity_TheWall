using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TheWall.Models;
using Microsoft.EntityFrameworkCore;
namespace TheWall.Controllers
{
    public class HomeController : Controller
    {
        // // // // // // // /// //
        // DEPENDENCY INJECTION //
        WallContext dbContext;

        public HomeController(WallContext context)
        {
            dbContext = context;
        }

        // // // // // // // // // //
        // Login and Reg Section //
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("register")]
        public IActionResult Register(User user)
        {
            if(ModelState.IsValid)
            {
                // Invalid Email //
                if(dbContext.Users.Any(u => u.Email == user.Email))
                {

                    ModelState.AddModelError("Email", "This Email is already in use!");
                    // return the view
                    return View("Index");
                }

                // invalid Password //
                if(user.Password != user.Confirm)
                {
                    // Manually add a ModelState error to the Email field, with provided
                    // error message
                    ModelState.AddModelError("Password", "Password confirmation was not the same password.");
                    // return the view
                    return View("Index");
                }

                // // // // // // // // // //
                // hash the given password:

                // Initialize the hasher object
                var hasher = new PasswordHasher<User>();

                user.Password = hasher.HashPassword(user, user.Password);
                dbContext.Add(user);
                dbContext.SaveChanges();

                HttpContext.Session.SetString("UserName", user.FirstName);
                HttpContext.Session.SetInt32("UserId", user.UserId);
                return RedirectToAction("TheWall");
            }
            else
            return View("Index");
        }

        [HttpPost("loginconfirm")]
        public IActionResult LoginConfirm(LoginUser userSubmission)
        {
            if(ModelState.IsValid)
            {
                // If inital ModelState is valid, query for a user with provided email
                var userInDb = dbContext.Users.FirstOrDefault(u => u.Email == userSubmission.Email);
                // If no user exists with provided email
                if(userInDb == null)
                {
                    // Add an error to ModelState and return to View!
                    ModelState.AddModelError("Email", "Invalid Email/Password");
                    return View("Login");
                }
                // Initialize hasher object
                var hasher = new PasswordHasher<LoginUser>();
                
                // verify provided password against hash stored in db
                var result = hasher.VerifyHashedPassword(userSubmission, userInDb.Password, userSubmission.Password);
                
                // result can be compared to 0 for failure
                if(result == 0)
                {
                    // handle failure (this should be similar to how "existing email" is handled)
                    ModelState.AddModelError("Password", "Invalid Email/Password");
                    return View("Login");
                }
                else
                {
                    HttpContext.Session.SetString("UserName", userInDb.FirstName);
                    HttpContext.Session.SetInt32("UserId", userInDb.UserId);
                    return RedirectToAction("TheWall");
                }
                
            }
            else
            {
                return View("Index");
            }
        }

        [HttpGet("LogOut")]
        public IActionResult LogOut()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }

        // // // // 
        // Wall //
        [HttpGet("TheWall")]
        public IActionResult TheWall()
        {
            string name = HttpContext.Session.GetString("UserName");
            if(name == null)
            {
                return RedirectToAction("Index");
            }
            ViewBag.UserName = name;

            int? userId = HttpContext.Session.GetInt32("UserId");
            ViewBag.UserId = userId;

            List<Message> messages = dbContext
                .Messages
                .OrderByDescending(m => m.CreatedAt)
                .Include(m => m.Author)
                .ToList();

            List<Comment> comments = dbContext
                .Comments
                .Include(c => c.Message)
                .Include(c=> c.User)
                .ToList();
                
            ViewBag.Messages = messages;
            ViewBag.Comments = comments;

            return View();
        }

        // // // /// //
        // MESSAGES //
        [HttpPost("NewMessage")]
        public IActionResult NewMessage(Message message)
        {
            int? userId = HttpContext.Session.GetInt32("UserId");

            if(ModelState.IsValid)
            {
                User user = dbContext.Users.FirstOrDefault(u => u.UserId == userId);
                message.Author = user;
                dbContext.Add(message);
                dbContext.SaveChanges();
                return RedirectToAction("TheWall");
            }
            else
            {
                List<Message> messages = dbContext.Messages.ToList();
                ViewBag.Messages = messages;
                return View("TheWall");
            }
        }

        // // // /// //
        // COMMENTS //
        [HttpPost("messages/{messageId}/NewComment")]
        public IActionResult NewMessage(int messageId, string commentText)
        {
            int? userId = HttpContext.Session.GetInt32("UserId");
            User user = dbContext.Users.FirstOrDefault(u => u.UserId == userId);
            Message message = dbContext.Messages.FirstOrDefault(m => m.MessageId == messageId);

            Comment comment = new Comment(user.UserId, user, messageId, message, commentText);
            dbContext.Add(comment);
            dbContext.SaveChanges();
            return RedirectToAction("TheWall");
        }
        // // /// //
        // ERROR //
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
