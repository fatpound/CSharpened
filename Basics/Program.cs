namespace Basics
{
    internal sealed class Program
    {
        static void Main(String[] args)
        {
            int[] dizi = [1, 2, 3, 4, 5];

            foreach (var item in dizi)
            {
                Console.Write(item + " ");
            }
            
            Console.WriteLine();
            Console.WriteLine("Goodbye, cruel world!");

            List<int> list = new List<int>(); // IDE0028 says I should write [1, 2];

            list.Add(1);
            list.Add(2);

            Console.WriteLine(list); // System.Collections.Generic.List`1[System.Int32]

            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
        }
    }
}