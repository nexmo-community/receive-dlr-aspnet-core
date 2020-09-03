using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ReceiveDlrAspNet.Models;
using Vonage.Messaging;
using Vonage.Utility;
using System.IO;
using Newtonsoft.Json;

namespace ReceiveDlrAspNet.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost("/webhooks/dlr")]
        public async Task<IActionResult> HandleDlr()
        {            
            var dlr = WebhookParser.ParseWebhook<DeliveryReceipt>(Request.Body,Request.ContentType);
            Console.WriteLine("***********DLR**************");
            Console.WriteLine(dlr.MessageTimestamp);
            Console.WriteLine(dlr.Msisdn);
            Console.WriteLine(dlr.To);
            Console.WriteLine(dlr.MessageId);
            Console.WriteLine("***********END**************");
            return NoContent();
        }
    }
}
