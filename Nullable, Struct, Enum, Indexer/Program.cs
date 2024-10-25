using Nullable__Struct__Enum__Indexer.Models;

namespace Nullable__Struct__Enum__Indexer
{
    internal class Program
    {
        static void Main(string[] args)
        {

            CustomList<int> list = new CustomList<int>(15, 1, 3);

            list.Add(145);

            list.Contains(5);

            list.AddRange(25, 2);

            list.RemoveRange(25, 3);


            list.Remove(1);

            list.Sum();
            Console.WriteLine(list.ToString());
        }
   
    }
}
