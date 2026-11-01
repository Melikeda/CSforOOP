using System;[cite: 9]

class StudentPoll[cite: 9]
{
    static void Main()[cite: 9]
    {
        // student response array (more typically, input at runtime)[cite: 9]
        int[] responses = {1, 2, 5, 4, 3, 5, 2, 1, 3, 3, 1, 4, 3, 3, 2, 3, 3, 2, 14};[cite: 9]
        var frequency = new int[6]; // array of frequency counters[cite: 9]

        // for each answer, select responses element and use that value[cite: 9]
        // as frequency index to determine element to increment[cite: 9]
        for (var answer = 0; answer < responses.Length; ++answer)[cite: 9]
        {
            try
            {
                ++frequency[responses[answer]];
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(
                    $"   responses[{answer}] = {responses[answer]}\n");
            }
        }

        Console.WriteLine($"{"Rating"}{"Frequency",10}");

        // output each array element's value[cite: 9]
        for (var rating = 1; rating < frequency.Length; ++rating)[cite: 9]
        {
            Console.WriteLine($"{rating,6}{frequency[rating],10}");
        }
    }
}
