using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace AllinOneCSharp
{

    public class Calculator
    {
        [Obsolete("Use Add(List<int>Numbers)")]
        public static int CalAdd(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }

        //If Users have more than two numbers to add

        public static int CalAdd(List<int> Numbers)
        {
            int SumAll = 0;

            foreach (int num in Numbers)
            {
                SumAll += num;
            }
            return SumAll;
        }
    }
        
    
}
