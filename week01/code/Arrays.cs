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
        // Creating an array to store multiples of numbers needed
        double[] ArrayOfMultiples = new double[length];
        // Loop to generate the required numbers of multiples
        for(int i = 0; i < length; i++)
        {
           //store each multiple in the array
           ArrayOfMultiples[i] = number * (i + 1); //Multiply the number by (i + 1) to get the correct multiple, starting from number × 1.
        }
        // returning the array of multiples numbers founded on the loop
        return ArrayOfMultiples; // replace this return statement with your own
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
        if (data.Count == 0 || amount % data.Count == 0)
        {
            return;
        }
        //Get the  end part values of data list and store them to  sublist1 
            var lastPart = data.GetRange(data.Count-amount,amount);
       //Get the  start part values of data list and store them  to  sublist2 
        var firstPart = data.GetRange(0, data.Count-amount);

        //Clear the data list to prepare for add subList1 and Subslist2 values
        data.Clear();
        //Add the values of subList1 to data list
        data.AddRange(lastPart);
        //Add the values of subList2 to data list
        data.AddRange(firstPart);
        //Loop the data list to print all the values in it
        foreach (var item in data)
        {
            Console.WriteLine(item);
        }
    }
}
