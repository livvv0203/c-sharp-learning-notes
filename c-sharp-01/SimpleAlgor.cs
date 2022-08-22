using System;
using System.Collections.Generic;

namespace c_sharp_learning
{
    public class SimpleAlgor
    {
       
        public static int findMax(List<int> list)
        { 
            int max = -1;

            for (var i = 0; i < list.Count; i++)
            {

                if (list[i] >= max)
                {
                    max = list[i];

                }
                Console.WriteLine(max);
            }
            return max;
        }
    }
}

