using System;


namespace CodingPractice
{
    public static class RandomNumber
    {
        public static int getRandomNumber(int iRange)
        {
            Random random = new Random();
            return random.Next(1, iRange);
        }

        public static int[] getRandomNumbers(int iRange, int count)
        {
            int[] numbers = new int[count];

            for (int i = 0; i < count; i++)
            {
                numbers[i] = getRandomNumber(iRange);
            }
            return numbers;
        }

    }
}
