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
        }
    }
}