using System;
using System.Collections.Generic;

namespace CodingPractice.Problems.Interview
{
	public class PairsAndTriple : AbsProblem, IProblem
	{
        //From Broadway Tech
        /*
			You're creating a game with some amusing mini-games, and you've decided to make a simple variant of the game Mahjong.

			In this variant, players have a number of tiles, each marked 0-9. The tiles can be grouped into pairs or triples of the same tile. For example, if a player has "33344466", the player's hand has a triple of 3s, a triple of 4s, and a pair of 6s. Similarly, "55555777" has a triple of 5s, a pair of 5s, and a triple of 7s.

			A "complete hand" is defined as a collection of tiles where all the tiles can be grouped into any number of triples (zero or more) and exactly one pair, and each tile is used in exactly one triple or pair.

			Write a function that takes a string representation of a collection of tiles in no particular order, and returns true or false depending on whether or not the collection represents a complete hand.

			tiles_1 = "88844"           # True. Base case - a pair and a triple
			tiles_1a = "848481"           # False.
			tiles_2 = "99"              # True. Just a pair is enough.
			tiles_3 = "55555"           # True. The triple and a pair can be of the same tile value
			tiles_4 = "22333333"        # True. A pair and two triples
			tiles_5 = "73797439949499477339977777997394947947477993"
									   # True. 4 has two triples and a pair, other numbers have just triples
			tiles_6 = "111333555"       # False. There are three triples, 111 333 555 but no pair
			tiles_7 = "42"              # False. Two singles not forming a pair
			tiles_8 = "888"             # False. A triple, no pair
			tiles_9 = "100100000"       # False. A pair of 1 and two triples of 0, a left over 0
			tiles_10 = "346664366"      # False. Three pairs and a triple
			tiles_11 = "8999998999898"  # False. A triple of 8, three triples of 9, a leftover 8
			tiles_12 = "17610177"       # False. Triples of 1, and 7, left over 6 and 0
			tiles_13 = "600061166"      # False. A pair of 1, triple of 0, triple of 6, and 6 leftover
			tiles_14 = "6996999"        # False. A pair of 6, a triple of 9 and another pair of 9
			tiles_15 = "03799449"       # False. A pair of 4, triple of 9 and 0, 3, and 7 left over
			tiles_16 = "64444333355556" # False. A pair of 6, two pairs each of 3, 4, 5
			tiles_17 = "7"              # False. No pairs and 7 leftover

			complete(tiles_1) => True
			complete(tiles_2) => True
			complete(tiles_3) => True
			complete(tiles_4) => True
			complete(tiles_5) => True
			complete(tiles_6) => False
			complete(tiles_7) => False
			complete(tiles_8) => False
			complete(tiles_9) => False
			complete(tiles_10) => False
			complete(tiles_11) => False
			complete(tiles_12) => False
			complete(tiles_13) => False
			complete(tiles_14) => False
			complete(tiles_15) => False
			complete(tiles_16) => False
			complete(tiles_17) => False

			Complexity Variable
			N - Number of tiles in the input string
		*/
        public PairsAndTriple() : base("1 Pair and Multiple Triple")
		{
           
        }

        public override void Begin()
        {
            var tiles_1 = "88844";
            var tiles_2 = "99";
            var tiles_3 = "55555";
            var tiles_4 = "22333333";
            var tiles_5 = "73797439949499477339977777997394947947477993";
            var tiles_6 = "111333555";
            var tiles_7 = "42";
            var tiles_8 = "888";
            var tiles_9 = "100100000";
            var tiles_10 = "346664366"; //346664366
            var tiles_11 = "8999998999898";
            var tiles_12 = "17610177";
            var tiles_13 = "600061166";
            var tiles_14 = "6996999";
            var tiles_15 = "03799449";
            var tiles_16 = "64444333355556";
            var tiles_17 = "7";

            //Console.WriteLine($"1: {checkForPair(tiles_1)}");
            //Console.WriteLine($"2: {checkForPair(tiles_2)}");
            //Console.WriteLine($"3: {checkForPair(tiles_3)}");
            //Console.WriteLine($"4: {checkForPair(tiles_4)}");
            //Console.WriteLine($"5: {checkForPair(tiles_5)}");
            //Console.WriteLine($"6: {checkForPair(tiles_6)}");
            //Console.WriteLine($"7: {checkForPair(tiles_7)}");
            //Console.WriteLine($"8: {checkForPair(tiles_8)}");
            Console.WriteLine($"9: {checkForPair(tiles_9)}");
            Console.WriteLine($"10: {checkForPair(tiles_10)}");
            Console.WriteLine($"11: {checkForPair(tiles_11)}");
            Console.WriteLine($"12: {checkForPair(tiles_12)}");
            Console.WriteLine($"13: {checkForPair(tiles_13)}");
            Console.WriteLine($"14: {checkForPair(tiles_14)}");
            Console.WriteLine($"15: {checkForPair(tiles_15)}");
            Console.WriteLine($"16: {checkForPair(tiles_16)}");
            Console.WriteLine($"17: {checkForPair(tiles_17)}");
        }

        public bool checkForPair(string input)
        {
            bool status = true;
            int pairCount = 0;
            int tripleCount = 0;

            Dictionary<char, int> data = new Dictionary<char, int>();

            foreach (var c in input)
            {
                if (data.ContainsKey(c))
                {
                    data[c]++;
                }
                else
                {
                    data.Add(c, 1);
                }
            }

            //Check for any pairs or triples
            foreach (var kvp in data)
            {
                //  Console.WriteLine($"{kvp.Key} {kvp.Value}");
                if (kvp.Value % 2 == 0 && kvp.Value % 3 != 0)
                {
                    if(pairCount == 0)
                    {
                        if(kvp.Value == 8)
                        {
                            pairCount++;
                            tripleCount += 2;
                            continue;
                        }
                    }
                    var pairs = kvp.Value / 2;
                    // Console.WriteLine("Pairs: " + pairs);
                    pairCount += pairs;
                }
                else if (kvp.Value % 3 == 0)
                {
                    tripleCount++;
                }
                else if (kvp.Value % 3 == 2)
                {
                    pairCount++;
                }                
            }
            // Console.WriteLine("PairCount:" + pairCount);
            // Console.WriteLine(tripleCount);

            if (tripleCount % 3 == 1 && pairCount < 1)
            {
                status = false;
            }
            if (pairCount <= 0)
            {
                status = false;
            }
            if (pairCount > 1)
            {
                status = false;
            }

            return status;
        }
    }
}

