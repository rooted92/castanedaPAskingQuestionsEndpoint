//Pedro Castaneda
//10-25-2022
//Asking Questions - Endpoint
//Create a Controller with an Enpoint that calls a function that allows user to have a conversation with the computer
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace castanedaPAskingQuestionsEndpoint.Controllers
{
    [Route("[controller]")]
    public class AskingQuestionsController : Controller
    {
        [HttpGet]
        [Route("Asking/{name}/{time}")]
        public string Ask(string name, string time)
        {
            //added validation for time to make sure it's a number then realized I didn't really need it but kept for example
            //int validTime = 0;
            bool checkName = name.All(Char.IsLetter);
            //bool checkTime = Int32.TryParse(time, out validTime);
            string result = $"Nice to meet you {name}! {time} is a great time to wake up!";
            if(!checkName/*|| !checkTime*/)
            {
                result = "Invalid Entry";
            }
            return result;
        }
    }
}