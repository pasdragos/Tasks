namespace Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the string you would like to use ");
            string userInput = Console.ReadLine();
            Console.WriteLine("Input the length of the alphabet you would like to use ");
            var alphabetSize = int.Parse(Console.ReadLine());
            mergedResult(alphabetSize, userInput);

            static int deleteOperation(string userInput)
            {
                var delete = userInput.Length;
                return delete;
            }

            static int insertOperation(string userInput, int alphabetSize)
            {
                var input = (userInput.Length + 1) * alphabetSize;
                return input;
            }

            static int replaceOperation(string userInput, int alphabetSize)
            {
                var replace = userInput.Length * (alphabetSize - 1);
                return replace;
            }

            static int swapOperation(string userInput)
            {
                var swap = userInput.Length - 1;
                return swap;
            }

            static int mergedResult(int alphabetSize, string userInput)
            {
                var result = deleteOperation(userInput)
                       + insertOperation(userInput, alphabetSize)
                       + replaceOperation(userInput, alphabetSize)
                       + swapOperation(userInput);
                Console.WriteLine(result);
                return result;

            }

        }

    }
}






