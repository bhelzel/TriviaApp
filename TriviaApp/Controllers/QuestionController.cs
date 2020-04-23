using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TriviaApp.Controllers
{
    public class QuestionController : Controller
    {
   
        public string Index()
        {
            return HtmlEncoder.Default.Encode("What year did the Wright brothers first take flight?");
        }

        public string Answer() => HtmlEncoder.Default.Encode("1903");
    }
}
