using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1_Capstone
{
    class Program
    {
        static void Main(string[] args)
        {
            string check = "y";//initialization of starting variables
            string vowels = "aeiou";
            string input;

            Console.WriteLine("Welcome to the pig latin translator!");//salutaion

            while (check.ToLower() == "y")//exit procedure check
            {
                Console.WriteLine("Enter a word or sentence to be translated (Please don't use any numbers, characters, or punctuation).");
                
                input = Console.ReadLine().ToLower();//converts word(s) to lowercase

                string[] arr = input.Split(' ');//creates a string array of all word(s)
                
                if (arr.Length > 1)//this loop is for when the user inputs a sentence
                {
                    for (int i = 0; i < arr.Length; i++)
                    {
                        int firstVowelIndexNum = arr[i].IndexOfAny(vowels.ToCharArray());
                        
                        if (firstVowelIndexNum == 0)//if the word in the loop starts with a vowel
                        {
                            Console.Write(arr[i] + "way" + " ");
                        }
                        else//if the word starts with a consonant
                        {
                            string part = arr[i].Substring(firstVowelIndexNum);
                            string firstCon = arr[i].Substring(0, firstVowelIndexNum);
                            
                            Console.Write(part + firstCon + "ay" + " ");
                        }
                    }
                    Console.WriteLine();//carriage return
                }
                else//this loop is for when the user inputs a single word
                {
                    int firstVowelIndexNum = input.IndexOfAny(vowels.ToCharArray());

                    if (firstVowelIndexNum == 0)//if the word starts with a vowel
                    {
                        Console.WriteLine(input + "way");
                    }
                    else//if the word starts with a consonant
                    {
                        string part = input.Substring(firstVowelIndexNum);
                        string firstCon = input.Substring(0, firstVowelIndexNum);
                        Console.WriteLine(part + firstCon + "ay");
                    }
                }
                Console.WriteLine("Would you like to translate another word or sentence? (y/n)");
                check = Console.ReadLine();//exit check to close or continue while loop
            } 
        }
    }
}

/*--------------------------------NOTES----------------------------------*/
/*Challenges Accomplished: 
1. translate word with contractions
2. make the application take a line instead of a single word, then find the pig latin for every word in the line.
*/

//string testsen = "This IS A TEST sentence.";
//int index = testsen.IndexOfAny(vowels.ToCharArray());
//string n = testsen.Substring(index);//"Thi"
//string n2 = testsen.Substring(0,index);
//Console.WriteLine(n + n2);

//Console.WriteLine($"sentence character length is {testsen.Length}");//24
//Console.WriteLine(testsen.Contains("hello"));//false
//Console.WriteLine(testsen.Contains("test"));//true
//Console.WriteLine(testsen.Substring(5));//"is a test sentence."
//Console.WriteLine(testsen.Substring(5, 9));//"IS A TEST"
//Console.WriteLine(testsen.Substring(5, 9).ToLower());//"is a test"
//Console.WriteLine(testsen.IndexOf("TEST"));//10