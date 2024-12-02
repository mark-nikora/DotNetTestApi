using TestApi.Models;

public static class SeedData
{
    public static List<Test> Tests = new()
    {
        new() { Id = 1, Name = "C# Basics", Description = "Test on the fundamentals of C#" }
    };

    public static List<Question> Questions = new()
    {
        new() { Id = 1, Description = "Which keyword is used to define a method in C# that does not return a value?", Code = null },
        new() { Id = 2, Description = "What is the default access modifier for a class in C#?", Code = null },
        new() { Id = 3, Description = "Which of the following is NOT a value type in C#?", Code = null },
        new() { Id = 4, Description = "What is the purpose of the 'using' statement in C#?", Code = null },
        new() { Id = 5, Description = "What is the correct way to declare a nullable int in C#?", Code = null },
        new() { Id = 6, Description = "What does the 'is' keyword do in C#?", Code = null },
        new() { Id = 7, Description = "Which exception is thrown when accessing an array element out of bounds in C#?", Code = null },
        new() { Id = 8, Description = "What is the purpose of the 'async' keyword in C#?", Code = null },
        new() { Id = 9, Description = "Which collection in C# is used to store key-value pairs?", Code = null },
        new() { Id = 10, Description = "What is the base class for all types in C#?", Code = null },

        new() { Id = 11, Description = "What is the output of this code?", Code = "int x = 10; int y = x++; Console.WriteLine(y);" },
        new() { Id = 12, Description = "What will this code return?", Code = "int[] numbers = { 1, 2, 3 }; var result = numbers.Where(x => x > 1).Count();" },
        new() { Id = 13, Description = "Identify the error in the following code.", Code = "if(x == 10) { Console.WriteLine(\"Hello\" }" },
        new() { Id = 14, Description = "What does this LINQ query do?", Code = "var query = list.OrderBy(x => x.Length).ToList();" },
        new() { Id = 15, Description = "What exception will this code throw?", Code = "string[] arr = new string[1]; arr[1] = \"OutOfBounds\";" },
        new() { Id = 16, Description = "What does this method return?", Code = "Task<int> GetResultAsync() { return Task.FromResult(42); }" },
        new() { Id = 17, Description = "What is the purpose of the 'await' keyword in this code?", Code = "await Task.Delay(1000);" },
        new() { Id = 18, Description = "Fix the syntax error in the following code.", Code = "int? num = 5; if(num.HasValue Console.WriteLine(num.Value);" },
        new() { Id = 19, Description = "What will this print to the console?", Code = "Console.WriteLine(\"5\" + 5 + 5);" },
        new() { Id = 20, Description = "What does this delegate do?", Code = "Action greet = () => Console.WriteLine(\"Hello\"); greet();" },
        new() { Id = 21, Description = "Explain what this LINQ method does.", Code = "var max = numbers.Max();" },
        new() { Id = 22, Description = "What will be the output of this ternary operator?", Code = "int x = 5; Console.WriteLine(x > 3 ? \"Yes\" : \"No\");" },
        new() { Id = 23, Description = "What does the 'ref' keyword do in this code?", Code = "void Increment(ref int x) { x++; }" },
        new() { Id = 24, Description = "What exception does this code throw?", Code = "object obj = null; Console.WriteLine(obj.ToString());" },
        new() { Id = 25, Description = "What is the output of this conditional statement?", Code = "if(true) Console.WriteLine(\"True\"); else Console.WriteLine(\"False\");" },
        new() { Id = 26, Description = "What will this loop print?", Code = "for(int i = 0; i < 3; i++) Console.Write(i);" },
        new() { Id = 27, Description = "What is the result of this expression?", Code = "bool result = (5 == 5) && (3 < 4);" },
        new() { Id = 28, Description = "Fix the issue in this lambda expression.", Code = "Func<int, int> square = x => return x * x;" },
        new() { Id = 29, Description = "What will this array print?", Code = "int[] nums = {1, 2, 3}; Console.WriteLine(nums[1]);" },
        new() { Id = 30, Description = "What does this 'switch' statement output?", Code = "switch(2) { case 1: Console.WriteLine(\"One\"); break; default: Console.WriteLine(\"Default\"); }" }
    };

    public static List<Option> Options = new()
    {
        // Question 11 (Code-based question)
        new() { Id = 1, Description = "10", Correct = false, QuestionId = 11 },
        new() { Id = 2, Description = "11", Correct = true, QuestionId = 11 },
        new() { Id = 3, Description = "5", Correct = false, QuestionId = 11 },
        new() { Id = 4, Description = "0", Correct = false, QuestionId = 11 },

        // Question 12 (Code-based question)
        new() { Id = 5, Description = "1", Correct = false, QuestionId = 12 },
        new() { Id = 6, Description = "2", Correct = true, QuestionId = 12 },
        new() { Id = 7, Description = "3", Correct = false, QuestionId = 12 },
        new() { Id = 8, Description = "4", Correct = false, QuestionId = 12 },

        // Question 13 (Code-based question)
        new() { Id = 9, Description = "Syntax error, missing bracket", Correct = true, QuestionId = 13 },
        new() { Id = 10, Description = "No error", Correct = false, QuestionId = 13 },
        new() { Id = 11, Description = "Syntax error, missing semicolon", Correct = false, QuestionId = 13 },
        new() { Id = 12, Description = "Logic error", Correct = false, QuestionId = 13 },

        // Question 14 (Code-based question)
        new() { Id = 13, Description = "Sorts the list by length of each string", Correct = true, QuestionId = 14 },
        new() { Id = 14, Description = "Filters the list based on length", Correct = false, QuestionId = 14 },
        new() { Id = 15, Description = "Returns the list without modification", Correct = false, QuestionId = 14 },
        new() { Id = 16, Description = "Orders the list by string content", Correct = false, QuestionId = 14 },

        // Question 15 (Code-based question)
        new() { Id = 17, Description = "IndexOutOfRangeException", Correct = true, QuestionId = 15 },
        new() { Id = 18, Description = "NullReferenceException", Correct = false, QuestionId = 15 },
        new() { Id = 19, Description = "ArgumentOutOfRangeException", Correct = false, QuestionId = 15 },
        new() { Id = 20, Description = "ArgumentNullException", Correct = false, QuestionId = 15 },

        // Question 16 (Code-based question)
        new() { Id = 21, Description = "Returns 42", Correct = true, QuestionId = 16 },
        new() { Id = 22, Description = "Returns 0", Correct = false, QuestionId = 16 },
        new() { Id = 23, Description = "Returns null", Correct = false, QuestionId = 16 },
        new() { Id = 24, Description = "Throws an exception", Correct = false, QuestionId = 16 },

        // Question 17 (Code-based question)
        new() { Id = 25, Description = "It allows asynchronous execution", Correct = true, QuestionId = 17 },
        new() { Id = 26, Description = "It pauses the execution of a method", Correct = false, QuestionId = 17 },
        new() { Id = 27, Description = "It throws an exception", Correct = false, QuestionId = 17 },
        new() { Id = 28, Description = "It defines a lambda expression", Correct = false, QuestionId = 17 },

        // Question 18 (Code-based question)
        new() { Id = 29, Description = "Add the closing parenthesis", Correct = true, QuestionId = 18 },
        new() { Id = 30, Description = "Add a semicolon after 'HasValue'", Correct = false, QuestionId = 18 },
        new() { Id = 31, Description = "Change 'HasValue' to 'Value'", Correct = false, QuestionId = 18 },
        new() { Id = 32, Description = "Change 'num' to 'num.Value'", Correct = false, QuestionId = 18 },

        // Question 19 (Code-based question)
        new() { Id = 33, Description = "555", Correct = true, QuestionId = 19 },
        new() { Id = 34, Description = "55", Correct = false, QuestionId = 19 },
        new() { Id = 35, Description = "50", Correct = false, QuestionId = 19 },
        new() { Id = 36, Description = "5", Correct = false, QuestionId = 19 },

        // Question 20 (Code-based question)
        new() { Id = 37, Description = "Hello", Correct = true, QuestionId = 20 },
        new() { Id = 38, Description = "Error", Correct = false, QuestionId = 20 },
        new() { Id = 39, Description = "Nothing", Correct = false, QuestionId = 20 },
        new() { Id = 40, Description = "null", Correct = false, QuestionId = 20 },

        // Question 21 (Code-based question)
        new() { Id = 41, Description = "Finds the maximum value", Correct = true, QuestionId = 21 },
        new() { Id = 42, Description = "Sorts the list", Correct = false, QuestionId = 21 },
        new() { Id = 43, Description = "Filters the list", Correct = false, QuestionId = 21 },
        new() { Id = 44, Description = "Reverses the list", Correct = false, QuestionId = 21 },

        // Question 22 (Code-based question)
        new() { Id = 45, Description = "Yes", Correct = true, QuestionId = 22 },
        new() { Id = 46, Description = "No", Correct = false, QuestionId = 22 },
        new() { Id = 47, Description = "Maybe", Correct = false, QuestionId = 22 },
        new() { Id = 48, Description = "None", Correct = false, QuestionId = 22 },

        // Question 23 (Code-based question)
        new() { Id = 49, Description = "Increments the value of x", Correct = true, QuestionId = 23 },
        new() { Id = 50, Description = "Decrements the value of x", Correct = false, QuestionId = 23 },
        new() { Id = 51, Description = "Compares the value of x", Correct = false, QuestionId = 23 },
        new() { Id = 52, Description = "Assigns a new value to x", Correct = false, QuestionId = 23 },

        // Question 24 (Code-based question)
        new() { Id = 53, Description = "NullReferenceException", Correct = true, QuestionId = 24 },
        new() { Id = 54, Description = "IndexOutOfRangeException", Correct = false, QuestionId = 24 },
        new() { Id = 55, Description = "ArgumentNullException", Correct = false, QuestionId = 24 },
        new() { Id = 56, Description = "ArgumentOutOfRangeException", Correct = false, QuestionId = 24 },

        // Question 25 (Code-based question)
        new() { Id = 57, Description = "True", Correct = true, QuestionId = 25 },
        new() { Id = 58, Description = "False", Correct = false, QuestionId = 25 },
        new() { Id = 59, Description = "No Output", Correct = false, QuestionId = 25 },
        new() { Id = 60, Description = "Error", Correct = false, QuestionId = 25 },

        // Question 26 (Code-based question)
        new() { Id = 61, Description = "012", Correct = true, QuestionId = 26 },
        new() { Id = 62, Description = "123", Correct = false, QuestionId = 26 },
        new() { Id = 63, Description = "321", Correct = false, QuestionId = 26 },
        new() { Id = 64, Description = "None", Correct = false, QuestionId = 26 },

        // Question 27 (Code-based question)
        new() { Id = 65, Description = "True", Correct = true, QuestionId = 27 },
        new() { Id = 66, Description = "False", Correct = false, QuestionId = 27 },
        new() { Id = 67, Description = "Error", Correct = false, QuestionId = 27 },
        new() { Id = 68, Description = "None", Correct = false, QuestionId = 27 },

        // Question 28 (Code-based question)
        new() { Id = 69, Description = "Fixes the lambda expression", Correct = true, QuestionId = 28 },
        new() { Id = 70, Description = "Throws a compile error", Correct = false, QuestionId = 28 },
        new() { Id = 71, Description = "Does nothing", Correct = false, QuestionId = 28 },
        new() { Id = 72, Description = "Creates an infinite loop", Correct = false, QuestionId = 28 },

        // Question 29 (Code-based question)
        new() { Id = 73, Description = "2", Correct = true, QuestionId = 29 },
        new() { Id = 74, Description = "1", Correct = false, QuestionId = 29 },
        new() { Id = 75, Description = "3", Correct = false, QuestionId = 29 },
        new() { Id = 76, Description = "4", Correct = false, QuestionId = 29 },

        // Question 30 (Code-based question)
        new() { Id = 77, Description = "Default", Correct = true, QuestionId = 30 },
        new() { Id = 78, Description = "One", Correct = false, QuestionId = 30 },
        new() { Id = 79, Description = "Two", Correct = false, QuestionId = 30 },
        new() { Id = 80, Description = "None", Correct = false, QuestionId = 30 }
    };

    public static List<TestQuestion> TestQuestions = new()
    {
        new() { TestId = 1, QuestionId = 1 },
        new() { TestId = 1, QuestionId = 2 },
        new() { TestId = 1, QuestionId = 3 },
        new() { TestId = 1, QuestionId = 4 },
        new() { TestId = 1, QuestionId = 5 },
        new() { TestId = 1, QuestionId = 6 },
        new() { TestId = 1, QuestionId = 7 },
        new() { TestId = 1, QuestionId = 8 },
        new() { TestId = 1, QuestionId = 9 },
        new() { TestId = 1, QuestionId = 10 },
        new() { TestId = 1, QuestionId = 11 },
        new() { TestId = 1, QuestionId = 12 },
        new() { TestId = 1, QuestionId = 13 },
        new() { TestId = 1, QuestionId = 14 },
        new() { TestId = 1, QuestionId = 15 },
        new() { TestId = 1, QuestionId = 16 },
        new() { TestId = 1, QuestionId = 17 },
        new() { TestId = 1, QuestionId = 18 },
        new() { TestId = 1, QuestionId = 19 },
        new() { TestId = 1, QuestionId = 20 },
        new() { TestId = 1, QuestionId = 21 },
        new() { TestId = 1, QuestionId = 22 },
        new() { TestId = 1, QuestionId = 23 },
        new() { TestId = 1, QuestionId = 24 },
        new() { TestId = 1, QuestionId = 25 },
        new() { TestId = 1, QuestionId = 26 },
        new() { TestId = 1, QuestionId = 27 },
        new() { TestId = 1, QuestionId = 28 },
        new() { TestId = 1, QuestionId = 29 },
        new() { TestId = 1, QuestionId = 30 }
    };

    public static List<Result> Results = new()
    {
        new() { Id = 1, TestId = 1, Username = "Mark", Mark = 3, OutOf = 30 },
        new() { Id = 2, TestId = 1, Username = "Sarah", Mark = 25, OutOf = 30 }
    };
}
