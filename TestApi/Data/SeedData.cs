using TestApi.Models;


public static class SeedData
{
    public static List<Test> Tests = new List<Test>
    {
        new() { Id = 1, Name = "C# Basics", Description = "Test on the fundamendals of csharp" }
    };

    public static List<Question> Questions = new List<Question>
    {
        new Question { Id = 1, Description = "Which keyword is used to define a method in C# that does not return a value?" },
        new Question { Id = 2, Description = "What is the default access modifier for a class in C#?" },
        new Question { Id = 3, Description = "Which of the following is NOT a value type in C#?" },
        new Question { Id = 4, Description = "What is the purpose of the 'using' statement in C#?" },
        new Question { Id = 5, Description = "What is the correct way to declare a nullable int in C#?" },
        new Question { Id = 6, Description = "What does the 'is' keyword do in C#?" },
        new Question { Id = 7, Description = "Which exception is thrown when accessing an array element out of bounds in C#?" },
        new Question { Id = 8, Description = "What is the purpose of the 'async' keyword in C#?" },
        new Question { Id = 9, Description = "Which collection in C# is used to store key-value pairs?" },
        new Question { Id = 10, Description = "What is the base class for all types in C#?" }
    };

    public static List<Option> Options = new List<Option>
    {
        new Option { Id = 1, Description = "void", Correct = true, QuestionId = 1 },
        new Option { Id = 2, Description = "return", Correct = false, QuestionId = 1 },
        new Option { Id = 3, Description = "method", Correct = false, QuestionId = 1 },
        new Option { Id = 4, Description = "empty", Correct = false, QuestionId = 1 },

        new Option { Id = 5, Description = "private", Correct = false, QuestionId = 2 },
        new Option { Id = 6, Description = "public", Correct = false, QuestionId = 2 },
        new Option { Id = 7, Description = "internal", Correct = true, QuestionId = 2 },
        new Option { Id = 8, Description = "protected", Correct = false, QuestionId = 2 },

        new Option { Id = 9, Description = "int", Correct = false, QuestionId = 3 },
        new Option { Id = 10, Description = "float", Correct = false, QuestionId = 3 },
        new Option { Id = 11, Description = "decimal", Correct = false, QuestionId = 3 },
        new Option { Id = 12, Description = "string", Correct = true, QuestionId = 3 },

        new Option { Id = 13, Description = "To import namespaces", Correct = true, QuestionId = 4 },
        new Option { Id = 14, Description = "To declare variables", Correct = false, QuestionId = 4 },
        new Option { Id = 15, Description = "To execute cleanup code", Correct = false, QuestionId = 4 },
        new Option { Id = 16, Description = "To define methods", Correct = false, QuestionId = 4 },

        new Option { Id = 17, Description = "int num = null;", Correct = false, QuestionId = 5 },
        new Option { Id = 18, Description = "int? num = null;", Correct = true, QuestionId = 5 },
        new Option { Id = 19, Description = "nullable int num;", Correct = false, QuestionId = 5 },
        new Option { Id = 20, Description = "num = null;", Correct = false, QuestionId = 5 },

        new Option { Id = 21, Description = "Checks if an object is a specific type", Correct = true, QuestionId = 6 },
        new Option { Id = 22, Description = "Creates a new object", Correct = false, QuestionId = 6 },
        new Option { Id = 23, Description = "Casts an object to a specific type", Correct = false, QuestionId = 6 },
        new Option { Id = 24, Description = "Compares two objects for equality", Correct = false, QuestionId = 6 },

        new Option { Id = 25, Description = "ArgumentException", Correct = false, QuestionId = 7 },
        new Option { Id = 26, Description = "IndexOutOfRangeException", Correct = true, QuestionId = 7 },
        new Option { Id = 27, Description = "OutOfMemoryException", Correct = false, QuestionId = 7 },
        new Option { Id = 28, Description = "NullReferenceException", Correct = false, QuestionId = 7 },

        new Option { Id = 29, Description = "To define a background thread", Correct = false, QuestionId = 8 },
        new Option { Id = 30, Description = "To mark a method for asynchronous execution", Correct = true, QuestionId = 8 },
        new Option { Id = 31, Description = "To pause a method", Correct = false, QuestionId = 8 },
        new Option { Id = 32, Description = "To cancel a task", Correct = false, QuestionId = 8 },

        new Option { Id = 33, Description = "List", Correct = false, QuestionId = 9 },
        new Option { Id = 34, Description = "Array", Correct = false, QuestionId = 9 },
        new Option { Id = 35, Description = "Dictionary", Correct = true, QuestionId = 9 },
        new Option { Id = 36, Description = "Queue", Correct = false, QuestionId = 9 },

        new Option { Id = 37, Description = "System.Object", Correct = true, QuestionId = 10 },
        new Option { Id = 38, Description = "System.Type", Correct = false, QuestionId = 10 },
        new Option { Id = 39, Description = "System.Base", Correct = false, QuestionId = 10 },
        new Option { Id = 40, Description = "System.Class", Correct = false, QuestionId = 10 }
    };

    public static List<TestQuestion> TestQuestions = new List<TestQuestion>
    {
        new TestQuestion { TestId = 1, QuestionId = 1 },
        new TestQuestion { TestId = 1, QuestionId = 2 },
        new TestQuestion { TestId = 1, QuestionId = 3 },
        new TestQuestion { TestId = 1, QuestionId = 4 },
        new TestQuestion { TestId = 1, QuestionId = 5 },
        new TestQuestion { TestId = 1, QuestionId = 6 },
        new TestQuestion { TestId = 1, QuestionId = 7 },
        new TestQuestion { TestId = 1, QuestionId = 8 },
        new TestQuestion { TestId = 1, QuestionId = 9 },
        new TestQuestion { TestId = 1, QuestionId = 10 }
    };
}
