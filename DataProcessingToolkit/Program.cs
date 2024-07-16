using Utilities;

public class Program
{
    public static void Main()
    {
        // Проверка UniqueInOrder
        Console.WriteLine(string.Join(", ", UniqueInOrderUtility.UniqueInOrder("AAAABBBCCDAABBB")));  // A, B, C, D, A, B
        Console.WriteLine(string.Join(", ", UniqueInOrderUtility.UniqueInOrder("ABBCcAD")));          // A, B, C, c, A, D
        Console.WriteLine(string.Join(", ", UniqueInOrderUtility.UniqueInOrder(new List<int> { 1, 2, 2, 3, 3 }))); // 1, 2, 3

        // Проверка IsAlphanumeric
        Console.WriteLine(AlphanumericChecker.IsAlphanumeric("Hello123")); // True
        Console.WriteLine(AlphanumericChecker.IsAlphanumeric("Hello 123")); // False
        Console.WriteLine(AlphanumericChecker.IsAlphanumeric("")); // False
        Console.WriteLine(AlphanumericChecker.IsAlphanumeric("123")); // True
        Console.WriteLine(AlphanumericChecker.IsAlphanumeric("hello_world")); // False
        Console.WriteLine(AlphanumericChecker.IsAlphanumeric("HelloWorld")); // True
    }
}
