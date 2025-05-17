using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPractice.Problems.Other_Code_Problems
{
    class StringOrder : AbsProblem, IProblem
    {
		public StringOrder() : base("CodeWars: Your order,please")
		{
		}

        public override void Begin()
        {
            Order("is2 Thi1s T4est 3a");
        }

        public static string Order(string words)
        {
            SortedDictionary<int, string> sentence = new SortedDictionary<int, string>();
            StringBuilder sb = new StringBuilder();

            if (words.Length == 0)
            {
                return "";
            }
            else
            {
                //extact number from string 
                var listOfStrings = words.Split(' ');
                foreach (var word in listOfStrings)
                {
                    KeyValuePair<int, string> kvp = extractOrder(word);
                    //returns key/value pair 
                    sentence.Add(kvp.Key, kvp.Value);

                }

                //Flatten out the dictionary 
                foreach (var word in sentence)
                {
                    sb.Append(" " + word.Value);
                }
            }

            return sb.ToString().Remove(0,1);
        }

        private static KeyValuePair<int, string> extractOrder(string word)
        {
            int order = 0;
            foreach (var letter in word)
            {
                if(char.IsNumber(letter))
                {
                    order = (int)char.GetNumericValue(letter);
                    return new KeyValuePair<int, string>(order, word);
                }
            }

            return new KeyValuePair<int, string>(order, word);
        }
		
	}
}