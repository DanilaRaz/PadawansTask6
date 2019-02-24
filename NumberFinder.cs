using System;

namespace PadawansTask6
{
    public static class NumberFinder
    {
        public static int? NextBiggerThan(int number)
        {
            if( number > int.MaxValue || number < 1)
            {
                throw new ArgumentOutOfRangeException();
            }
            int check = number;
            int compare = int.MaxValue;
            
            int stat = number;
            int stat2 = number;
            int counter = 0;
                for (int i=0; number >0;i++)
                {
                    number = number / 10;
                    counter++;
                }
           
            int[] array = new int[counter];
            Array.Clear(array, 0, counter);
                for (int i = 0; stat2 > 0; i++)
                {
                    array[i] = stat2 % 10;
                    stat2 = stat2 / 10;
                }

            int temporary = 0;

            for (int i = 0; array.Length > i; i++)
            {
                for (int j = 0; array.Length > j; j++)
                {
                    if (i == j)
                    {
                        continue;
                    }
                    else
                    {
                        temporary = array[i];
                        array[i] = array[j];
                        array[j] = temporary;
                        int vremennaya = 0;
                        for (int k = array.Length-1 ; k > -1; k--)
                        {
                            vremennaya = vremennaya * 10 + array[k];
                        }
                        if (vremennaya > check && vremennaya-check < compare-check)
                        {
                            compare = vremennaya;
                        }
                    }

                }
            }

            if(compare==int.MaxValue)
            {
                return 0;
            }
            return compare;
        }
    }
}
