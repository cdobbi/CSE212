// Christina Dobbins CSE212 W01 Code: Dynamic Arrays Running and Debugging
// 9-4-25 10:49 AM

// Part 1: Arrays
// Read over the file and understand the requirements for each function before implementing code.
// In order to understand the requirements fully, break down the tasks for each problem.
// If not understanding, consult the module documentation, get help from others to clarify, ask GPT what's expected and to teach me.
// When asking others or GPT to teach, be specific about the missunderstanding, specify not to give the answers, to only teach.


public static class Arrays
{
    /// <summary>
    /// Come up with a plan on how to implement the MultiplesOf function.
    /// The function should create and return an array of multiples of a number.
    /// The starting number and the number of multiples are provided as inputs to the function.
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.
    /// For example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.
    /// Assume that length is a positive integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    // public: anyone can use this function
    // static: belongs to the class, not an object
    // double[ ]: returns an array of decimal numbers
    // MultiplesOf: function name
    // (double number, int length): parameters takes a decimal number and a whole number as inputs.
    {
      // Step 1: Create an array to hold the multiples.
        double[] multiples = new double[length];
        // double[]: make an array of decimal numbers
        // multiples: name of teh array
        // = new double[length];: create the array with 'length' spots

        // Step 2: Use a loop to to the math for them.
        for (int i = 0; i < count; i++)
        // for: start a loop
        // int i = 0: start with i at zero
        // i < length: keep going while i is less than length
        // i++: add one to i each time

        // Step 3: Store them to an array.
            multiples[i] = number * (i + 1);
            // multiples[i]: the spot in the array at the position i.
            // =: set it equal to....
            // number * (i +1): the starting number times (i +1)
            // (i +1): makes the multiples start at 1 (not 0).

        // Step 4: Return the array.
        return multiples;
        // return: give back
        // multiples: the array filled with answers
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
       // Step 1: Get the last 'amount' elements.
       List<int> endElements = data.GetRange(data.Count - amount, amount);
       // List<int>: make a new list of intergers.
       // endElements: name of the new list
       // = data.GetRange(...): get a section of the original list.
       // data.Count - amount: start at the right spot
       // amount: how many elements to get

       // Step 2: Remove thos elements fromt the end.
       data.RemoveRange(data.Count - amount, amount);
       // data.RemoveRange(...): remove a section from the list.

       // Step 3: Insert those elements at the front.
       data.InsertRange(0, endElements);
       // data.InsertRange(0, ...): put the elements at the start of the list.
}

