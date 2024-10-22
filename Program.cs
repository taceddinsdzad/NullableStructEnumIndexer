namespace NullableStructEnumIndexer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListInt myList = new ListInt(10);
            myList.Add(4);
            myList.Add(89);
            myList.Add(78);
            myList.Add(65);
            myList.Add(21);
            myList.AddRange(62, 11);

            Console.WriteLine("List: " + myList.ToString());
            Console.WriteLine("Contains 89: " + myList.Contains(89));
            Console.WriteLine("Sum: " + myList.Sum());

            myList.Remove(20);
            Console.WriteLine("After removing 89: " + myList.ToString());
        }
    }
}
