using z2;

namespace z2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();

            myDictionary.Add(0, "1"); 
            myDictionary.Add(1, "10");
            myDictionary.Add(2, "22"); 
            myDictionary.Add(3, "33");
            myDictionary.Add(4, "44"); 
            myDictionary.Add(5, "55");

            for (int i = 0; i < myDictionary.Count; i++)
            {
                Console.WriteLine(myDictionary[i]);
            }

            Console.WriteLine("\nВведите индекс элемента из массива:");
            int index = int.Parse(Console.ReadLine());
            Console.WriteLine(new string('-', 35));

            Console.WriteLine($"Элемент содержащий данный индекс: {myDictionary[index]} ");

            Console.WriteLine($"Размер словаря: {myDictionary.Count}");
        }
    }
}