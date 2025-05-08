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
        //Create an array object based on the length peramiter  
        double[] multiplesArray = new double[length];

        // fill each index with a multiple of the number peramiter
        for (int i = 0; i < length; i++)
        {
            multiplesArray[i] = number * (i +1);
        }


        return multiplesArray; // replace this return statement with your own
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
        //Store the size of the data list
        int listLength = data.Count;
        // An empty list that will hold the values of the roatated list
        List<int> dataCopy = new List<int>(new int[listLength]);
        
        //shift the value to the right by the amount of positions, 
        // using madulo to wrap around to the end
        for (int i = 0; i < listLength; i++) {
            int newIndex = (i + amount) % listLength;
            dataCopy[newIndex] = data[i];
        }

        // use the dataCopy list to wrute back on the original data
        for (int i = 0; i < listLength; i++) {
            data[i] = dataCopy[i];
        }
        
    }
}
