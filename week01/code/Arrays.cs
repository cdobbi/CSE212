// 9-4-25 10:49 AM

//Christina Dobbins CSE212 W01 Code: Dynamic Arrays Running and Debugging
// Part 1: Arrays
// I will read over the file and understand the requirements for each function before implementing the code.
// In order to understand the requirements fully, I will break down the tasks for each problem.
// For the tasks I'm not understanding I'll consult the documentation, seek help from others to clarify what's expected and to teach me or ask GPT.
// When I ask others or GPT to teach me, I will be specific about what I want to learn, and specify not to give me the answers, to help me learn.

public static class Arrays
{
    /// <summary>
    /// Come up with a plan on how to implement the MultiplesOf function.
    /// The function should create and return an array of multiples of a number.
    /// The starting number and the number of multiples are provided as inputs to the function.
    /// For example, MultiplesOf(3,5), where the 3 is the starting number and 5 is the number of multiples, would result in <double>{3, 6, 9, 12, 15}.
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.
    /// For example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.
    /// Assume that length is a positive integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // Part 1: Arrays 9-4-25 10:56 AM
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        return []; // replace this return statement with your own
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
        // 
        // Part 2: Solving a Complicated Problem Using a List
        // Come up with a plan on how to implement the RotateListRight function.
        // This function receives a list of data and an amount to rotate to the right.
        // For example, if the data is <List>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 5 then the list after the function runs should be <List>{ 5, 6, 7, 8, 9, 1, 2, 3, 4}.
        // If the data is <List>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be <List>{7, 8, 9, 1, 2, 3, 4, 5, 6}. The value of amount will be in the range of 1 and data.Count, inclusive.
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.
    }
}

