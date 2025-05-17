using System.Linq;
using System.Collections.Generic;

namespace CodingPractice.Problems.LeetCode
{
	public class ValidParentheses : AbsProblem, IProblem
	{
		Dictionary<int, int> setMatches = new Dictionary<int, int>();

        /*
		 * Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid. 
		 * An input string is valid if: 
		 * Open brackets must be closed by the same type of brackets. 
		 * Open brackets must be closed in the correct order. 
		 * Every close bracket has a corresponding open bracket of the same type. 
		 * 
		 * Example: 
		 *	Input: s = "()[]{}" 
		 *	Output: true
		 *	
		 *	Input: s = "(]" 
		 *	Output: false
		 *	
		 *	Input: s = "}]({[())" 
		 *	Output: false
		 */
        public ValidParentheses() : base ("Validate Parentheses")
		{
            //Go through each char and see count the number of 
        }

        public override void Begin()
        {			
			var input = "([)]";

			DisplayMessage($"{IsAllParenthesesMatching(input)}");
        }

		public bool IsAllParenthesesMatching(string s)
		{
            InitializeSet();

            foreach (var ch in s)
            {
                int value = IsCloseChar(ch) ? -1 : 1;

                switch(ch)
                {
                    case '(':
                    case ')':
                        {
                            setMatches[0] += value;
                            break;
                        }
                    case '{':
                    case '}':
                        {
                            setMatches[1] += value;

                            break;
                        }
                    case '[':
                    case ']':
                        {
                            setMatches[2] += value;
                            break;
                        }
                }

                if (setMatches.Values.Any(value => value < 0))
                {
                    return false;
                }
            }

            foreach (var values in setMatches.Values)
            {
                if(values >= 1)
                {
                    return false;
                }
            }

            return true;
        }

        private void InitializeSet()
        {
            setMatches.Clear();

            for (int i = 0; i <= 2; i++)
            {
                setMatches.Add(i, 0);
            }
        }


        private bool IsCloseChar(char ch)
		{
			if(ch == '}' || ch == ']' || ch == ')')
			{
				return true;
			}

			return false;
        }
    }
}

