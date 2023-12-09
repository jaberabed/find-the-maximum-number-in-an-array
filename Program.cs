namespace find_the_maximum_number_in_an_array
{
   internal class Program
   {
      private static void Main(string[] args)
      {
         // Example array of values
         int[] numbers = { 1, 2, 5, 7, 8, 10, 20, 30, 34, 98, 50, 23, 67, 89, 45, 35 };

         // Find the maximum using manual iteration
         int maxNumber = FindMax(numbers);

         // Display the result
         Console.WriteLine($"The maximum value is: {maxNumber}");
      }

      public static int FindMax(int[] array)
      {
         if (array == null || array.Length == 0)
         {
            throw new ArgumentException("Array is null or empty.");
         }

         // Initialize maxNumber to the first element of the array
         int maxNumber = array[0];

         // Iterate through the array to find the maximum value
         for (int i = 1; i < array.Length; i++)
         {
            if (array[i] > maxNumber)
            {
               maxNumber = array[i];
            }
         }
         return maxNumber;
      }
   }
}