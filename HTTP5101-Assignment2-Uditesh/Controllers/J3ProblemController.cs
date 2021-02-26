using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP5101_Assignment2_Uditesh.Controllers
{
    /// <summary>
    ///  You decide to go for a very long drive on a very straight road. Along this road are five cities. As
    ///  you travel, you record the distance between each pair of consecutive cities.
    ///  You would like to calculate a distance table that indicates the distance between any two of the cities
    ///  you have encountered.
    /// </summary>
    /// <param name="length1">first city to second city</param>
    /// <param name="length2">second city to third city</param>
    /// <param name="length3">third city to fourth city</param>
    /// <param name="length4">fourth city to fifth city</param>
    /// <returns> The output should be 5 lines, with the ith line (1 ≤ i ≤ 5) containing the distance from city i to
    ///  cities 1, 2, ... 5 in order, separated by one space.</returns>
    /// <example>
    /// GET: api/J3ProblemController/distance/5/8/10/15	
    /// </example>
    public class J3ProblemController : ApiController
    {
        [HttpGet]
        [Route("api/J3ProblemController/distance/{length1}/{length2}/{length3}/{length4}")]
        public IEnumerable<string> Get()
        {
            // Pseudo CODE
            // Guess 5 cities as A , B , C , D and E
            // Distance between them would be AB , BC, CD and DE that is in our example length1 to length4
            // Output should be 5 * 5 matrics.
            // First value of row is 0 as initial distance is 0.
            // First row and First column is values added to it's previous distance.
            // ex. 0 5 13 23 38 values at first row and first column.
            // Now in 5 * 5 matrics , every value will indicate distance from that city. 
            // If matcric is A and i is row and j is column then each value is represnted 
            // by A[i][j]
            //
            // example matrics of our output 5,8,10,15 is below .
            //    A   B   C   D   E
            // A  0   5   13  23  38
            // B  5   0   8   18  43
            // C  13  8   0   10  25
            // D  23  18  10   0  15
            // E  38  33  25  15   0
            return new string[] { "value1", "value2" };
        }
    }
}
