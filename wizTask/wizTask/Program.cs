using System.Text.RegularExpressions;

namespace Task
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\nPlease choose a task by inputing the corresponding number and pressing ENTER\n");
                Console.WriteLine("1. Check if a string is a palindrome");
                Console.WriteLine("2. FooBar ");
                Console.WriteLine("3. Replace email address with user input ");
                Console.WriteLine("4. Exit");
                string option = Console.ReadLine();
                switch (option)
                {
                    case "1": CheckPalindrome(); break;
                    case "2": FooBar(); break;
                    case "3": ReplaceEmails(); break;
                    case "4": return;
                    default: break;
                }
            }
        }
        static void CheckPalindrome()
        {
            string inputWord = string.Empty;
            Console.WriteLine("Input the string you would like to check ");
            inputWord = Console.ReadLine();

            char[] temp = inputWord.ToCharArray();
            Array.Reverse(temp);
            string reverseInputWord = new(temp);

            if (inputWord.ToLower().Equals(reverseInputWord.ToLower()))
            {
                Console.WriteLine("This string is a palindrome.");
                return;
            }
            Console.WriteLine("This string is not a palindrome.");

        }

        static void FooBar()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 15 == 0)
                    Console.WriteLine("FooBar");
                else if (i % 3 == 0)
                    Console.WriteLine("Foo");
                else if (i % 5 == 0)
                    Console.WriteLine("Bar");
                else
                    Console.WriteLine(i);
            }
        }
        static void ReplaceEmails()
        {

            string replacementWord = string.Empty;
            Console.WriteLine("Input the replacement string ");
            replacementWord = Console.ReadLine();
            string text = "Christian has the email address christian+123@gmail.com." +
                "Christian's friend, John Cave-Brown, has the email address john.cave-brown@gmail.com." +
                "John's daughter Kira studies at Oxford University and has the email adress Kira123@oxford.co.uk." +
                "Her Twitter handle is @kira.cavebrown.";
            Regex emailRegex = new("[_\\w0-9-]+(.[a-z0-9-]+)@[a-z0-9-]+(.[a-z0-9-]+)*(.[a-z]{2,4})");
            MatchCollection matches = emailRegex.Matches(text);
            foreach (Match match in matches)
            {
                text = text.Replace(match.Value, replacementWord);
            }
            Console.WriteLine(text);   
        }
    }
}

