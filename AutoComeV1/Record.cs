using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoComeV1
{
   public class Record
    {
        public static String [,] operations=new String [20,2];
        public static String content;
        public static String previousContent;
        public static long startTime;//open the first file
        public static long stopTime;//new txt file generated.

        public static void addToOperationList(String newOperaton, String newTarget)
        {
            for (int i = 0; i < 19; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    operations[i, j] = operations[i + 1, j];
                }

            }
            operations[19, 0] = newOperaton;
            operations[19, 1] = newTarget;
        }

    }
}
