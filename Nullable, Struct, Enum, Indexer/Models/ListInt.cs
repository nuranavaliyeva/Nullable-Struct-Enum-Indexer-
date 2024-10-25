using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Nullable__Struct__Enum__Indexer.Models
{
    internal class CustomList<T>
    {
        private T[] arr;

        
        private int Length
        {
            get
            {
                return arr.Length;
            }
        }

        public int Count
        {
            get
            {
                return arr.Length;
            }
        }
        public T this[int index]
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
        public CustomList(params T[] nums)
        {
            arr = nums;
        }
     
        public void Add(T num)
        {
            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length - 1] = num;
          
        }
 
        public bool Contains(T num)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (num.Equals(arr[i]))
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
                sum += Convert.ToInt32(arr[i]);
            }
            Console.WriteLine($" Sum: {sum}");
        }
        public void Remove(T num)
        {
            int findIndex = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Equals( num))
                {
                    findIndex = i;
                    break;
                }

            }
            for (int i = findIndex; i < arr.Length - 1; i++)
            {
                arr[i] = arr[i + 1];
            }
            Array.Resize(ref arr, arr.Length - 1);
        }
        public void RemoveRange(params T[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Remove(arr[i]);
            }
        }
        public void AddRange(params T[] arr)
        {

            for (int i = 0; i < arr.Length; i++)
            {
                Add(arr[i]);
            }

        }




        public override string ToString()
        {
            return string.Join(", ", arr);
        }
    }
}
