using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace n01542751_Assignment2.Controllers
{
    public class J3Controller : ApiController
    {
        //Problem J3 - Cell-Phone Messaging
        //Original Source : https://cemc.math.uwaterloo.ca/contests/computing/2006/stage1/juniorEn.pdf

        /// <summary>
        /// Input contains a word consisting only of lowercase letters and echos the the minimal number of seconds needed to type in the word
        /// If the input word is "halt" then output is default which is "0".
        /// </summary>
        /// <param name="word">Input word = "dada"</param>
        /// <returns>minimal number of second = 4</returns>


        [HttpGet]
        [Route("api/J3/Message/{word}")]

        public int Messgae(string word)
        {
            // Create a character array of same length as of input word string 
            //Reference :https://www.geeksforgeeks.org/convert-string-to-character-array-in-c-sharp/ (Method2)
            char[] wordArr = word.ToCharArray();

            //define default output number
            int output = 0;
            
            //define every first letter to each key (As per phone keyboard)  
            char[] firstLetters = "adgjmptw".ToCharArray();

            //define every second letter to each key (As per phone keyboard)
            char[] secondLetters = "behknqux".ToCharArray();

            //define every third letter to each key (As per phone keyboard)
            char[] thirdLetters = "cfilorvy".ToCharArray();

            //define every fourth letter to each key (As per phone keyboard)
            //If not available the fourth letter to any key than define as a  "_"
            char[] fourthLetters = "_____s_z".ToCharArray();

            //define default prevoius index number of value   
            int prevIndex = -2;

            //define default current index number of value
            int currentIndex = 0;

            //check the input word is "halt" then return 0
            if(word == "halt")
            {
                return output;
            }

             
            for (int i = 0; i < wordArr.Length; i++)
            {
                //check firstlettrs, secondletters, thirdletters and fourthletters of arrays within a giving word of array or not
                //It returns true or false
                //Reference : https://www.geeksforgeeks.org/c-sharp-string-contains-method/
                if (firstLetters.Contains(wordArr[i]))
                {
                    //output = output + 1;
                    output += 1;

                    //save the index of first occurrence of value in firstletter array
                    //Reference: https://docs.microsoft.com/en-us/dotnet/api/system.array.indexof?view=net-6.0
                    currentIndex = Array.IndexOf(firstLetters, wordArr[i]);
                }
                else if (secondLetters.Contains(wordArr[i]))
                {
                    //output = output + 2;
                    output += 2;
                    currentIndex = Array.IndexOf(secondLetters, wordArr[i]);

                }
                else if (thirdLetters.Contains(wordArr[i]))
                {
                    //output = output + 3;
                    output += 3;
                    currentIndex = Array.IndexOf(thirdLetters, wordArr[i]);

                }
                else if (fourthLetters.Contains(wordArr[i]))
                {
                    //output = output + 4;
                    output += 4;
                    currentIndex = Array.IndexOf(firstLetters, wordArr[i]);

                }

                //check previous Index number of value in array and current Index number of value in array are similar or not
                if(prevIndex == currentIndex)
                {
                    //output = output + 2;
                    output += 2;
                }

                //save the current Index number as the previous index number
                prevIndex = currentIndex;
            }
            return output;

        }
    }
}
