// See https://aka.ms/new-console-template for more information

using Longest_Increasing_Subsequence;

do
{
    // Increasing size of inputBuffer array if the Input size is more than 65534 characters( 2 bytes are reserved).
    byte[] inputBuffer = new byte[65536];
    Stream inputStream = Console.OpenStandardInput(inputBuffer.Length);
    Console.SetIn(new StreamReader(inputStream, Console.InputEncoding, false, inputBuffer.Length));

    Console.WriteLine("\nEnter a sequence of integers separated by spaces (Max Characters -: 65534)");
    string input = Console.ReadLine().Trim();

    bool invalidInput = input.Any(x => x != ' ' && !char.IsDigit(x));
    if (invalidInput)
    {
        Console.WriteLine("\nInvalid input!, please enter only integers by spaces");        
    }
    else
    {
        string longestIncreasingSubsequence = LongestIncreasingSubsequence.FindLongestIncreasingSubsequence(input);
        Console.WriteLine("\n\n----------------------------------------------------------------------------------------------------------");
        Console.WriteLine($"Longest Increasing Subsequence: {longestIncreasingSubsequence}");
    }
    Console.WriteLine("\n\n----------------------------------------------------------------------------------------------------------");
    Console.WriteLine("Do you want to continue (Y/N)? ");
}
while (Console.ReadKey().Key == ConsoleKey.Y);
