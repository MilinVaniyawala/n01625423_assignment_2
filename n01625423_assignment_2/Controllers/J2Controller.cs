using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace n01625423_assignment_2.Controllers
{
    public class J2Controller : ApiController
    {
        /// <summary>
        /// GET: http://localhost/api/J2/DiceGame/{m}/{n} 
        /// {m} - positive integer representing the number of sides on the first die
        /// {n} - positive integer representing the number of sides on the second die
        /// </summary>
        /// <param name="m"></param>
        /// <param name="n"></param>
        /// Input 
        /// 1. GET ../api/J2/DiceGame/6/8
        /// 2. GET ../api/J2/DiceGame/12/4
        /// 3. GET ../api/J2/DiceGame/3/3
        /// 4. GET ../api/J2/Dicegame/5/5
        /// <returns>
        /// Output 
        /// 1. There are 5 total ways to get the sum 10.
        /// 2. There are 4 ways to get the sum 10.
        /// 3. There are 0 ways to get the sum 10.
        /// 4. There is 1 way to get the sum 10.
        /// </returns>

        ///  lecture -> git repo of "loop practice" very helpful to complete this practical
        /// https://github.com/christinebittle/LoopPractice/blob/master/LoopPractice/Controllers/LoopPracticeController.cs

        [HttpGet]
        [Route("api/J2/DiceGame/{m}/{n}")]
        public string DiceGame(int m, int n)
        {
            int count = 0;
            for (int i = 1; i <= m; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (i + j == 10)
                    {
                        count = count + 1; // We can also use count++
                    }
                }
            }
            if (count == 1)
            {
                return "There is " + count + " way to get the sum 10";
            }
            else if (count >= 5)
            {
                return "There are " + count + " total ways to get the sum 10";
            }
            else
            {
                return "There are " + count + " ways to get the sum 10";
            }
        }

    }
}
