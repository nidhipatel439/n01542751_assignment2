using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace n01542751_Assignment2.Controllers
{
    public class J1Controller : ApiController
    {
        //Adapted J1 - The New CCC (Canadian Calorie Counting)
        //Original Source : https://cemc.math.uwaterloo.ca/contests/computing/2006/stage1/juniorEn.pd


        /// <summary>
        /// Input the index of burger , drinks, sides and desserts calories and echos the total calories of the meal
        /// </summary>
        /// <param name="burger">The index of burger choice = 1</param>
        /// <param name="drink">The index of drink choice = 2</param>
        /// <param name="side">The index of side choice = 3</param>
        /// <param name="dessert">The index of dessert choice = 4</param>
        /// <returns>total calorie count is = 691</returns>

        [HttpGet]
        [Route("api/J1/Menu/{burger}/{drink}/{side}/{dessert}")]
        public string Menu(int burger, int drink, int side, int dessert)
        {
            //define different calories of various types of burger, drinks, sides and desserts
            int[] burgerChoice = { 461, 431, 420, 0 };
            int[] drinkChoice = { 130, 160, 118, 0 };
            int[] sideChoice = { 100, 57, 70, 0 };
            int[] dessertChoice = { 167, 266, 75, 0 };

            //sum of the total calories of the meal
            int totalCalories = burgerChoice[burger-1] + drinkChoice[drink-1] + sideChoice[side-1] + dessertChoice[dessert-1];

            string finalOutput = "Your total calorie count is" + " " + totalCalories;
            return finalOutput;
        }
    }
}
