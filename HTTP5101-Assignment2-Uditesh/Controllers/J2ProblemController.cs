using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP5101_Assignment2_Uditesh.Controllers
{
    public class J2ProblemController : ApiController
    {
        /// <summary>
        ///  You supervise a small parking lot which has N parking spaces.
        ///  Yesterday, you recorded which parking spaces were occupied by cars and 
        ///  which were empty. Today, you recorded the same information.
        ///  How many of the parking spaces were occupied both yesterday and today?
        ///  !!!!!!!!!!!!! NOTE !!!!!!!!!!!!!!!!!!
        ///  This program is checking only matches of parking of yesterday and today. 
        ///  If character 'c'(not case sensitive) is matched it will return number of matches.
        ///  Input should be string only. To match, Special character (like @, . , $ etc) or 
        ///  charcters other than 'c' should not be typed.
        /// </summary>
        /// <param name="length">Length of the parking</param>
        /// <param name="day1">First Day</param>
        /// <param name="day2">Second Day</param>
        /// <returns> the number of parking spaces which were occupied yesterday and today.</returns>
        /// <example>
        /// GET: api/J2ProblemController/occupy/3/ccc/ccc	
        /// </example>
        [HttpGet]
        [Route("api/J2ProblemController/occupy/{length}/{day1}/{day2}")]
        public int OccupyParking(int length, string day1, string day2)
        {
            string day1Upper = day1.ToUpper();
            string day2Upper = day2.ToUpper();

            char[] day1chars = day1Upper.ToCharArray();
            char[] day2chars = day2Upper.ToCharArray();
            int count = 0;
            for(int i=0; i < length; i++)
            {
                if ((day1chars[i] == 'C' &&  day1chars[i] == day2chars[i]))
                {
                    count++;
                }
            }
            return count;
        }
    }
}