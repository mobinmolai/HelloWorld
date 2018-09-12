using HelloWorld.Models;
using HelloWorld.Services;
using HelloWorld.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.Controllers.Web
{
    public class AppController : Controller
    {
        private IMailService _mailService;
        private HelloWorldContext _context;

        public AppController(IMailService mailService, HelloWorldContext context)
        {
            _mailService = mailService;
            _context = context;
        }

        public IActionResult Index()
        {
            //var data = _context.Trips.ToList();
            return View();
        }
        
        [Authorize]
        public IActionResult Trips()
        {
            var data = _context.Trips.ToList();
            return View(data);
        }

        public IActionResult Contact()
        {
            //throw new InvalidOperationException("Bad things happen to good developers");
            return View();
        }

        [HttpPost]
        public IActionResult Contact(ContactViewModel model)
        {
            _mailService.Send("Mobin", model.Email, "From Hello World!", model.Message);
            return View();
        }

        public IActionResult About()
        {
            return View();
        }
    }
}
