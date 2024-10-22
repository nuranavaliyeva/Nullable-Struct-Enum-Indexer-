using Nullable__Struct__Enum__Indexer.Models;

namespace Nullable__Struct__Enum__Indexer
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            ListInt arr1= new ListInt(9,6,3,9,10,23,2,2005);
            arr1.Add(1);
            arr1.Remove(1);
            arr1.Contains(10);
            arr1.Sum();
            arr1.AddRange(20, 30, 40);
            arr1.ToString();
            arr1.ToString();

        }
   
    }
}
