using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace n01542751_Assignment2.Controllers
{
    public class J2Controller : ApiController
    {
        //Adapted J2 - Roll the Dice
        //Original Source : https://cemc.math.uwaterloo.ca/contests/computing/2006/stage1/juniorEn.pdf

        /// <summary>
        /// Return the total number ways to get the sum 10 with two dice
        /// </summary>
        /// <param name="m">The number of side on the first dice = 12</param>
        /// <param name="n">The number of side on the second dice = 4</param>
        /// <returns>total ways = 4</returns>


        [HttpGet]
        [Route("api/J2/DiceGame/{m}/{n}")]
        public string DiceGame(int m, int n)
        {
            //define default ways is 0
            int ways = 0;

            //m representing the number of sides on the first die
            //n representing the number of sides on the second die
            for (int i=1; i<=m; i++)
            {
                for(int j=1; j<=n; j++)
                {
                    //count sum of the number of side on the first dice and number of side on the second dice
                    int total = i + j;

                    //to check if sum is equal to 10
                    if(total == 10)
                    {
                        ways++;
                    }
                }
            }
            string finalOutput = "There are" + " " + ways + " " +"total ways to get the sum 10.";
            return finalOutput;
        }
    }
}
