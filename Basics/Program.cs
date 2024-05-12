namespace Basics
{
    internal sealed class Program
    {
        static void Main(String[] args)
        {
            int[] dizi = { 1, 2, 3, 4, 5 };

            foreach (var item in dizi)
            {
                global::System.Console.Write(item + " ");
            }
            
            global::System.Console.WriteLine();
            global::System.Console.WriteLine("Goodbye, cruel world!");
        }
    }
}