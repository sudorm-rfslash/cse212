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
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // I will make a loop that counts from 1 to length.
        // Each time the loop runs, 'number' will be multiplied by the 'count' for that loop.
        // Then I can add the outcome to the end of the array by using arrayName[count] = product of number and count.
        // Alternatively, I could use arrayName.add(product of number and count)
        // Then, the array will be returned.


        double[] multiplesOf = new double[length];
        foreach (double count in multiplesOf) {
            multiplesOf[(int)count] = count * number;
        }

        return multiplesOf; // replace this return statement with your own
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
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // Get the 'size' of the array using .Count subtract by 1 for 0 indexing, use that number to grab the value at the end of the array.
        // Store that value, remove it from the end of the array using .Remove(index) then add it to the beginning of the
        // array using .Insert(value, 0). Then I can loop through this set of steps until I have rotated 'amount' of times.

        int length = data.Count - 1;
        int value = data[length];
        for (int i = 1; i <= amount; i++) {
            value = data[length];
            data.Remove(length);
            data.Insert(value, 0);
        }
    }
}
