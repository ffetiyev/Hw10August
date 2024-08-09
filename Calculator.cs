using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW10August
{
    internal class Calculator
    {

        public decimal Calculation(decimal num1, string operation, decimal num2)
        {
            switch (operation)
            {
                case "+":
                    return num1 + num2;

                case "-":
                    return num1 - num2;

                case "*":
                    return num1 * num2;

                case "/":
                    return num1 / num2;
            }

            return default(decimal);
        }
    }
}
