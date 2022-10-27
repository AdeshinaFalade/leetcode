


using System.Collections;
using System.Linq;

namespace leetcode
{
    internal class Program
    {
        public int maxArea;
        public List<int> list = new List<int>();
        static void Main(string[] args)
        {
            var height = new int[]{ 1,8,6,2,5,4,8,3,7};
            var h = new int[] { 1,1};
            var m = new Program();
            var area = m.MaxArea(height);
            var array1 = new int[]{ 2, 4, 3 };
            var array2 = new int[]{ 5, 6, 4 };

            var sum = m.AddTwoNumbers(array1,array2);
            Console.WriteLine(area);
        }

        public int MaxArea(int[] height)
        {
            int area;
            try
            {
                for (int i = 1; i < height.Length; i++)
                {
                    for (int j = 0; j < i; j++)
                    {
                        if (height[i] > height[j])
                        {
                            area = height[j] * (i -j);
                        }
                        else
                        {
                            area = height[i] * (i - j);
                        }
                        list.Add(area);
                    }
                }
                maxArea = list.Max();
                
            }
            catch (Exception e)
            {

                var error = e.Message;
            }
            return maxArea;
        }

        //Add two numbers
        public int[] AddTwoNumbers(int[] array1, int[] array2)
        {
            string array1String = "";
            string array2String = "";

            int[] result = new int[] {};
            try
            {
                for (int i = 0; i < array1.Length; i++)
                {
                    array1String += array1[i];
                }
                for (int i = 0; i < array2.Length; i++)
                {
                    array2String += array2[i];
                }

                var rev1 = Reverse(array1String);
                var rev2 = Reverse2(array2String);
                var intArray1 = int.Parse(rev1.ToString());
                var intArray2 = int.Parse(rev2.ToString());
                var sum = intArray1 + intArray2;
                char[] res = Reverse(sum.ToString()).ToCharArray();
                result = Array.ConvertAll(res, c => (int)Char.GetNumericValue(c));
            }
            catch (Exception e)
            {
                var error = e.Message;
            }
            return result;
        }



        /// <summary>
        /// This method reverses a string using Last in First Out of stack
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public string Reverse(string str)
        {
            Stack stkl = new Stack(str.Length);
            foreach (var item in str)
            {
                stkl.Push(item);
            }
            string revString = "";
            foreach (var item in str)
            {
                revString += stkl.Pop();
            }
            return revString;
        }

        public string Reverse2(string str)
        {
            char[] chars = str.ToCharArray();
            for (int i = 0, j = str.Length-1; i < j; i++, j--)
            {
                chars[i] = str[j];
                chars[j] = str[i];
            }
            return new string(chars);
        }
    }
}