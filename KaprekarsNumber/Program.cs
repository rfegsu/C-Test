using System;

namespace KaprekarsNumber
{
    class KaprekarsNumber
    {
        public void printInt32(int[] nums)
        {
            string str = "";
            for(int i=0; i<nums.Length; i++)
            {
                str += nums[i];
            }
            Console.WriteLine(str);
        }
        public int intArrToInt(int[] num)
        {
            string str = "";
            for(int i=0; i<nums.Length; i++)
            {
                str += nums[i];
            }
            return Convert.ToInt32(str);
        }
        public int bubbleSort(int[] nums)
        {
            printInt32(nums);
            bool swap = true;
            int temp;
            while(swap == true)
            {
                swap = false;
                for(int x=0; x<nums.Length-1; x++)
                {
                    if(nums[x] < nums[x+1])
                    {
                        temp = nums[x];
                        nums[x] = nums[x+1];
                        nums[x+1] = temp;
                        swap = true;
                    }
                }
            }
            //printInt32(nums);
            return intArrToInt(nums);
        }
        public int[] bubbleSortReverse(int[] nums)
        {
            printInt32(nums);
            bool swap = true;
            int temp;
            while(swap == true)
            {
                swap = false;
                for(int x=0; x<nums.Length-1; x++)
                {
                    if(nums[x] > nums[x+1])
                    {
                        temp = nums[x];
                        nums[x] = nums[x+1];
                        nums[x+1] = temp;
                        swap = true;
                    }
                }
            }
            //printInt32(nums);
            return intArrToInt(nums);
        }
        public int KaprekarsConstant(int num)
        {
            int count = 0;
            int new;
            string str = num.ToCharArray();
            int[] nums = new int[str.Length];
            for(int i=0; i<str.Length; i++)
            {
                nums[i] = Convert.ToInt32(str.[i]);
            }

            new = bubbleSort(nums) - bubbleSortReverse(nums);

            while(new != num)
            {
                KaprekarsConstant(new);
                count++;
            }
            return count;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            int arr = 6572;
            int num = KaprekarsNumber.KaprekarsConstant(arr);
            Console.WriteLine(num);
        }
    }
}
