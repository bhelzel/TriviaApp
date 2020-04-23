using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TriviaApp.Controllers
{
    public class QuestionsController : Controller
    {
   
        public IActionResult Index()
        {
            return View();
        }

        public string Answer() => HtmlEncoder.Default.Encode("1903");
    }
}
