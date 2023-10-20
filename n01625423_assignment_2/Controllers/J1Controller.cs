using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace n01625423_assignment_2.Controllers
{
    public class J1Controller : ApiController
    {
        /// <summary>
        /// At Chip’s Fast Food emporium there's a very simple menu. Each food item is selected entering a digit choice. 
        /// Where Input is GET : http://localhost/api/J1/Menu/{burger}/{drink}/{side}/{dessert}
        /// {burger} - Integer representing the index burger choice
        /// {drink} - Integer representing the index drink choice
        /// { side } - Integer representing the index side choice
        /// { dessert } - Integer representing the index dessert choice
        /// </summary>
        /// <param name="burger">4 Or 1</param>  
        /// <param name="drink">4 or 2</param>
        /// <param name="side">4 or 3</param>
        /// <param name="dessert">4 or 4</param>
        /// <returns>
        ///  If i/p is GET ../api/J1/Menu/4/4/4/4 then o/p is Your total calorie count is 0
        ///  If i/p is GET ../api/J1/Menu/1/2/3/4 then o/p is Your total calorie count is 691
        /// </returns>
        ///  lecture -> git repo of "If Practice" very helpful to complete this practical
        /// https://github.com/christinebittle/if_practice_w2021/blob/master/IF_PRACTICE/Controllers/IfPracticeController.cs


        [HttpGet]
        [Route("api/J1/Menu/{burger}/{drink}/{side}/{dessert}")]
        public string Menu(int burger, int drink, int side, int dessert)
        {
            int[] burgerCaloriesAsPerChoice = { 461, 431, 420, 0 }; // For no burger option I take 0;
            int[] drinkCaloiresAsPerChoice = { 130, 160, 118, 0 }; // For no drink option I take 0;
            int[] sideCaloiresAsPerChoice = { 100, 57, 70, 0 }; // For no side order option I take 0;
            int[] dessertCaloiresAsPerChoice = { 167, 266, 75, 0 }; // For no dessert option I take 0;

            if (burger < 1 || burger > 4 || drink < 1 || drink > 4 || side < 1 || side > 4 || dessert < 1 || dessert > 4)
            {
                return "Invalid Choice!! Choice must be between 1 to 4";
            }

            int totalCalories = burgerCaloriesAsPerChoice[burger - 1] + drinkCaloiresAsPerChoice[drink - 1] + sideCaloiresAsPerChoice[side - 1] + dessertCaloiresAsPerChoice[dessert - 1];

            return "Your total calorie count is " + totalCalories;
        }
    }
}
