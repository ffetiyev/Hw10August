

namespace HW10August
{
    internal class CustomMath
    {

        public int SumOfOddNumbers(int[] arr)
        { 
            int sum = 0;
            error1: for (int i = 0; i < arr.Length; i++)
            {
               
                if (arr[i] % 2 != 0)
                {
                    sum=sum+arr[i];
                }
            }
            return sum;
        }
        
        public string OddOrEven(int num)
        {

            if ((num % 2) == 0)
                return "Number is even";

            return "Number is odd";
        }

        public int SquareSumOfEvenNumbers(int[] arr)
        {
            var sum = 0;
            for (int i = 0; i<arr.Length; i++) 
            {
                if(arr[i] % 2 == 0)
                {
                    sum= sum+arr[i];
                }
            
            }
            var result = sum * sum;
            return result;
        }

        public int ProductOfNumbersUntilN(int n)
        {
            int result = 1;
            for (int i = 1; i <= n; i++)
            {
                result= result*i;

            }
            return result;
        }
    }
}
