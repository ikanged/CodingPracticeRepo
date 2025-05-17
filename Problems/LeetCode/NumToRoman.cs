using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPractice.Problems.LeetCode
{
	public class NumToRoman : AbsProblem, IProblem
	{
		private Dictionary<int, string> _romanSymbol;

		/*
		 * Symbol		Value
		 *  
			I             1
			IV			  4 **
			V             5
			IX			  9 *
			X             10
			XL			  40 **
			L             50
		    LC			  90 *
			C             100
			CD			  400 **
			D             500
			CM			  900 *
			M             1000
		 
			Rules: 
				If the number contains 4 or 9, it will have to be subtracted 
				by the previous symbol

		 */

		public NumToRoman() : base("Numbers to Roman Characters")
		{
		}

		public override void Begin()
		{
			initSymbol();

			UserInput userInput = new UserInput();
			var input = userInput.intUserInput();

			DisplayMessage(convertToRoman(input));
		}

		private string convertToRoman(int input)
		{
			StringBuilder sb = new StringBuilder();

			//input = 3875 output = MMMDCCCLXXV
			var thousand = input / 1000;
			if(thousand > 0)
			{
				sb.Append(getRomanSymbol(thousand, "thousands"));
			}
			input = getNewNumber(input, 1000, thousand);

			var hundred = input / 100;
			if (hundred > 0)
			{
				sb.Append(getRomanSymbol(hundred, "hundreds"));
			}
			input = getNewNumber(input, 100, hundred);

			var ten = input / 10;
			if (ten > 0)
			{
				sb.Append(getRomanSymbol(ten, "tens"));
			}
			input = getNewNumber(input, 10, ten);

			var one = input;
			if (one > 0)
			{
				sb.Append(getRomanSymbol(one, "ones"));
			}

			return sb.ToString();
		}

		private void initSymbol()
		{
			_romanSymbol = new Dictionary<int, string>();

			_romanSymbol.Add(1, "I");
			_romanSymbol.Add(4, "IV");
			_romanSymbol.Add(5, "V");
			_romanSymbol.Add(9, "IX");
			_romanSymbol.Add(10, "X");
			_romanSymbol.Add(40, "XL");
			_romanSymbol.Add(50, "L");
			_romanSymbol.Add(90, "XC");
			_romanSymbol.Add(100, "C");
			_romanSymbol.Add(400, "CD");
			_romanSymbol.Add(500, "D");
			_romanSymbol.Add(900, "CM");
			_romanSymbol.Add(1000, "M");

		}

		private int getNewNumber(int num, int diff, int multiplier)
		{
			return (num - (multiplier * diff));
		}

		private string getRomanSymbol(int num, string placement)
		{
			StringBuilder romanSymbol = new StringBuilder();
			int tempNum = num;

			switch(placement)
			{
				case "ones":
					{
						if (num == 4 ||
								num == 5 ||
								num == 9)
						{
							romanSymbol.Append(_romanSymbol[num]);
						}
						else if (num < 4)
						{
							for (int i = 0; i < num; i++)
							{
								romanSymbol.Append(_romanSymbol[1]);
							}
						}
						else if (num == 6 ||
								num == 7 ||
								num == 8)
						{
							romanSymbol.Append(_romanSymbol[5]);

							for(int i = num - 5; i > 0 ; i--)
							{
								romanSymbol.Append(_romanSymbol[1]);
							}
						}

						break;
					}
				case "tens":
					{
						if (num == 1 ||
								num == 4 ||
								num == 5 ||
								num == 9)
						{
							romanSymbol.Append(_romanSymbol[num*10]);
						}
						else if(num < 4)
						{
							for (int i = 0; i < num; i++)
							{
								romanSymbol.Append(_romanSymbol[10]);
							}
						}
						else if (num == 6 ||
								num == 7 ||
								num == 8)
						{
							romanSymbol.Append(_romanSymbol[50]);

							for (int i = num - 5; i > 0; i--)
							{
								romanSymbol.Append(_romanSymbol[10]);
							}
						}
						break;
					}
				case "hundreds":
					{
						if (num == 1 ||
								num == 4 ||
								num == 5 ||
								num == 9)
						{
							romanSymbol.Append(_romanSymbol[num*100]);
						}
						else if (num < 4)
						{
							for (int i = 0; i < num; i++)
							{
								romanSymbol.Append(_romanSymbol[100]);
							}
						}
						else if (num == 6 ||
								num == 7 ||
								num == 8)
						{
							romanSymbol.Append(_romanSymbol[500]);

							for (int i = num - 5; i > 0; i--)
							{
								romanSymbol.Append(_romanSymbol[100]);
							}
						}
						break;
					}
				case "thousands":
					{
						if (num < 4)
						{
							for (int i = 0; i < num; i++)
							{
								romanSymbol.Append(_romanSymbol[1000]);
							}
						}
						break;
					}
			}

			return romanSymbol.ToString();
		}
	}
}
