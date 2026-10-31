public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // 1.Create an empty array with the requested number of multiples.
        // 2.Use a for loop to go through the array.
        // 3.Multiply the starting number by the position in the array plus one.
        // 4.Store each result in the array
        // 5.Return the completed array.

        public static double[] MultiplesOf(double number, int count)
{
    // Step 1: Create an array to store the multiples.
    double[] multiples = new double[count];

    // Step 2: Loop through the array.
    for (int i = 0; i < count; i++)
    {
        // Step 3: Multiply the starting number by the current position plus one.
        // Step 4: Store the result in the array.
        multiples[i] = number * (i + 1);
    }

    // Step 5: Return the array containing all the multiples.
    return multiples;
}
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
       //1. Get the number of items in the list using data.Count.
    }
}
