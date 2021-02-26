using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP5101_Assignment2_Uditesh.Controllers
{
    public class J1ProblemController : ApiController
    {
        /// <summary>
        ///  Properties for telemarketer are as bellow
        ///  ->the first of these four digits is an 8 or 9
        ///  ->the last digit is an 8 or 9
        ///  ->the second and third digits are the same
        /// </summary>
        /// <param name="num1">First Number</param>
        /// <param name="num2">Second Number</param>
        /// <param name="num3">Third Number</param>
        /// <param name="num4">Fourth Number</param>
        /// <returns>'ignore' if telemarketer and 'answer' if not telemarketer</returns>
        /// <example>
        /// GET: api/J1ProblemController/telemarketer/8/6/6/9	
        /// </example>
        [HttpGet]
        [Route("api/J1ProblemController/telemarketer/{num1}/{num2}/{num3}/{num4}")]
        public string FindTelemarketer(int num1, int num2, int num3, int num4)
        {
            if((num1 == 8 || num1 == 9) && (num4 == 8 || num4 == 9) && (num2 == num3))
            {
                return "Ignore";
            }
            else
            {
                return "Answer";
            }
        }
    }
}
