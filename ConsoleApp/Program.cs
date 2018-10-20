using System;
using System.Linq;

namespace ConsoleApp
{
    class Program
    {
        /*
       * Complete the function below.
       * DO NOT MODIFY CODE OUTSIDE THIS FUNCTION!
       */
        static int[] slidingmax(int[] elements, int k)
        {
            int j, maxi;
            int[] value = new int[elements.Length - k + 1];

            for (int i = 0; i <= elements.Length - k; i++)
            {
                maxi = elements[i];

                for (j = 1; j < k; j++)
                {
                    if (elements[i + j] > maxi)
                        maxi = elements[i + j];
                }
                value[i] = maxi;
            }
            return value;
        }
        // DO NOT MODIFY CODE OUTSIDE THE ABOVE FUNCTION!

        static void Main(String[] args)
        {
            int[] res;


            var str = Console.ReadLine().Split(' ');
            int _elements_size = Convert.ToInt32(str[0]);
            int windowsize = Convert.ToInt32(str[1]);
            int[] _elements = new int[_elements_size];
            int _elements_item;
            for (int _elements_i = 0; _elements_i < _elements_size; _elements_i++)
            {
                _elements_item = Convert.ToInt32(Console.ReadLine());
                _elements[_elements_i] = _elements_item;
            }

            res = slidingmax(_elements, windowsize);
            for (int res_i = 0; res_i < res.Length; res_i++)
            {
                Console.WriteLine(res[res_i]);
            }
        }
    }
}
