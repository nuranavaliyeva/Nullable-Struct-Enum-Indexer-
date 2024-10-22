using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Nullable__Struct__Enum__Indexer.Models
{
    internal class ListInt
    {
        private int[] arr;

        public ListInt()
        {
            arr = new int[0];
        }
        public ListInt(int length)

        {
            arr = new int[length];
        }
        public int this[int index]
        {
            get
            {
                if (index >= arr.Length)
                {
                    return arr[arr.Length - 1];
                }
                return arr[index];

            }
            set
            {
                if (index <= arr.Length)
                {
                    arr[index] = value;
                }

            }
        }
        public ListInt(params int[] nums)
        {
            arr = nums;
        }
        public int Length
        {
            get { return arr.Length; }
        }
        public void Add(int num)
        {
            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length - 1] = num;
            Console.WriteLine($"{num} added");
        }

        public bool Contains(int num)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == num)
                {
                    Console.WriteLine($"{num} var");
                    return true;
                  
                }
            }
            Console.WriteLine($"{num} yoxdu");
            return false;
        }
        public void Sum()
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            Console.WriteLine($" Sum: {sum}");
        }
        public void Remove(int num)
        {
            {
                int j = 0;
                int[] newArr = new int[arr.Length - 1];

                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] != num)
                    {
                        newArr[j] = arr[i];
                        j++;
                    }
                    
                }
                arr = newArr;
                Console.WriteLine($"{num} this num is removed.");
            }

        }
        public void AddRange(params int[] nums)
        {
            
            int oldArrLength = arr.Length;
            Array.Resize(ref arr, arr.Length + nums.Length);

            for (int i = 0; i < nums.Length; i++)
            {
                arr[oldArrLength + i] = nums[i];
            }
            Console.WriteLine("nums are added.");

        }

       
        
        public override string ToString()
        {
            
            string result = "";
            for (int i = 0; i < arr.Length; i++)
            {
                result += arr[i];
                if (i < arr.Length - 1)
                {
                    result += ", "; 
                }
            }
            Console.WriteLine(result);
            return result;
            
        }
    }
}
