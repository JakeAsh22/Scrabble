using System;

namespace Scrabbin
{
    public class Scrabble
    {
        private string _input;
        string one = "aeioulnrst";
        string two = "dg";
        string three = "bcmp";
        string four = "fhvwy";
        string five = "k";
        string eight = "jx";
        string ten = "qz";
        int count = 0;
        public Scrabble(string userInput)
        {
            _input = userInput;
        }

        public string ScrabbleScore()
        {
           string lowerInput = _input.ToLower();

            for(int i =0; i<lowerInput.Length;i++)
            {
                if (one.Contains(lowerInput[i]))
                    count++;
                else if (two.Contains(lowerInput[i]))
                    count+= 2;
                else if (three.Contains(lowerInput[i]))
                    count += 3;
                else if (four.Contains(lowerInput[i]))
                    count += 4;
                else if (five.Contains(lowerInput[i]))
                    count += 5;
                else if (eight.Contains(lowerInput[i]))
                    count += 8;
                else if (ten.Contains(lowerInput[i]))
                    count += 10;
                else 
                    return "Please only use one word, with letters only.";
            }
            string counter = count.ToString();
            return counter;
        }

    }
} 