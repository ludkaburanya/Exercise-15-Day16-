using System.Collections;
using z1;
namespace z1
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> myList = new MyList<int>();
            myList.Add(6);
            myList.Add(13);
            myList.Add(45);
            myList.Add(0);
            myList.Add(10);
            myList.Add(29);

            Console.WriteLine("Матрица:");
            for (int i = 0; i < myList.Count; i++)
            {
                Console.Write(myList[i] + " ");
            }

            Console.WriteLine("\nВведите индекс элемента из массива:");
            int index = int.Parse(Console.ReadLine());
            Console.WriteLine(new string('-', 35));

            Console.WriteLine($"Элемент содержащий данный индекс: {myList[index]} ");
            Console.WriteLine($"Общее количество элементов: {myList.Count}");
            Console.WriteLine();
        }
    }
}