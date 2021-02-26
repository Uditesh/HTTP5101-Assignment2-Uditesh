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
        ///  This program is checking only matches of parking of yesterday and today. Just Parking
        ///  is matched or not. Input should be string only. No special character (like @, . etc)
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
            int count = 0;
            for(int i=0; i < length; i++)
            {
                if ((day1[i].Equals(day2[i]))){
                    count++;
                }
            }
            return count;
        }
    }
}