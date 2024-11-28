using TestApi.Models;


public static class SeedData
{
    public static List<Test> Tests =
    [
        new () { Id = 1, Name = "C# Basics", Description = "Test on the fundamendals of csharp" }
    ];

    public static List<Question> Questions =
    [
        new () { Id = 1, Description = "Which keyword is used to define a method in C# that does not return a value?" },
        new () { Id = 2, Description = "What is the default access modifier for a class in C#?" },
        new () { Id = 3, Description = "Which of the following is NOT a value type in C#?" },
        new () { Id = 4, Description = "What is the purpose of the 'using' statement in C#?" },
        new () { Id = 5, Description = "What is the correct way to declare a nullable int in C#?" },
        new () { Id = 6, Description = "What does the 'is' keyword do in C#?" },
        new () { Id = 7, Description = "Which exception is thrown when accessing an array element out of bounds in C#?" },
        new () { Id = 8, Description = "What is the purpose of the 'async' keyword in C#?" },
        new () { Id = 9, Description = "Which collection in C# is used to store key-value pairs?" },
        new () { Id = 10, Description = "What is the base class for all types in C#?" }
    ];

    public static List<Option> Options =
    [
        new () { Id = 1, Description = "void", Correct = true, QuestionId = 1 },
        new () { Id = 2, Description = "return", Correct = false, QuestionId = 1 },
        new () { Id = 3, Description = "method", Correct = false, QuestionId = 1 },
        new () { Id = 4, Description = "empty", Correct = false, QuestionId = 1 },

        new () { Id = 5, Description = "private", Correct = false, QuestionId = 2 },
        new () { Id = 6, Description = "public", Correct = false, QuestionId = 2 },
        new () { Id = 7, Description = "internal", Correct = true, QuestionId = 2 },
        new () { Id = 8, Description = "protected", Correct = false, QuestionId = 2 },

        new () { Id = 9, Description = "int", Correct = false, QuestionId = 3 },
        new () { Id = 10, Description = "float", Correct = false, QuestionId = 3 },
        new () { Id = 11, Description = "decimal", Correct = false, QuestionId = 3 },
        new () { Id = 12, Description = "string", Correct = true, QuestionId = 3 },

        new () { Id = 13, Description = "To import namespaces", Correct = true, QuestionId = 4 },
        new () { Id = 14, Description = "To declare variables", Correct = false, QuestionId = 4 },
        new () { Id = 15, Description = "To execute cleanup code", Correct = false, QuestionId = 4 },
        new () { Id = 16, Description = "To define methods", Correct = false, QuestionId = 4 },

        new () { Id = 17, Description = "int num = null;", Correct = false, QuestionId = 5 },
        new () { Id = 18, Description = "int? num = null;", Correct = true, QuestionId = 5 },
        new () { Id = 19, Description = "nullable int num;", Correct = false, QuestionId = 5 },
        new () { Id = 20, Description = "num = null;", Correct = false, QuestionId = 5 },

        new () { Id = 21, Description = "Checks if an object is a specific type", Correct = true, QuestionId = 6 },
        new () { Id = 22, Description = "Creates a new object", Correct = false, QuestionId = 6 },
        new () { Id = 23, Description = "Casts an object to a specific type", Correct = false, QuestionId = 6 },
        new () { Id = 24, Description = "Compares two objects for equality", Correct = false, QuestionId = 6 },

        new () { Id = 25, Description = "ArgumentException", Correct = false, QuestionId = 7 },
        new () { Id = 26, Description = "IndexOutOfRangeException", Correct = true, QuestionId = 7 },
        new () { Id = 27, Description = "OutOfMemoryException", Correct = false, QuestionId = 7 },
        new () { Id = 28, Description = "NullReferenceException", Correct = false, QuestionId = 7 },

        new () { Id = 29, Description = "To define a background thread", Correct = false, QuestionId = 8 },
        new () { Id = 30, Description = "To mark a method for asynchronous execution", Correct = true, QuestionId = 8 },
        new () { Id = 31, Description = "To pause a method", Correct = false, QuestionId = 8 },
        new () { Id = 32, Description = "To cancel a task", Correct = false, QuestionId = 8 },

        new () { Id = 33, Description = "List", Correct = false, QuestionId = 9 },
        new () { Id = 34, Description = "Array", Correct = false, QuestionId = 9 },
        new () { Id = 35, Description = "Dictionary", Correct = true, QuestionId = 9 },
        new () { Id = 36, Description = "Queue", Correct = false, QuestionId = 9 },

        new () { Id = 37, Description = "System.Object", Correct = true, QuestionId = 10 },
        new () { Id = 38, Description = "System.Type", Correct = false, QuestionId = 10 },
        new () { Id = 39, Description = "System.Base", Correct = false, QuestionId = 10 },
        new () { Id = 40, Description = "System.Class", Correct = false, QuestionId = 10 }
    ];

    public static List<TestQuestion> TestQuestions =
    [
        new () { TestId = 1, QuestionId = 1 },
        new () { TestId = 1, QuestionId = 2 },
        new () { TestId = 1, QuestionId = 3 },
        new () { TestId = 1, QuestionId = 4 },
        new () { TestId = 1, QuestionId = 5 },
        new () { TestId = 1, QuestionId = 6 },
        new () { TestId = 1, QuestionId = 7 },
        new () { TestId = 1, QuestionId = 8 },
        new () { TestId = 1, QuestionId = 9 },
        new () { TestId = 1, QuestionId = 10 }
    ];

    public static List<Result> Results =
    [
        new () { Id = 1, TestId = 1, Username = "Mark", Mark = 3, OutOf = 10},
        new () { Id = 2, TestId = 1, Username = "Sarah", Mark = 3, OutOf = 10},
        new () { Id = 3, TestId = 1, Username = "Keisha", Mark = 5, OutOf = 10},
        new () { Id = 4, TestId = 1, Username = "Throca", Mark = 8, OutOf = 10},
        new () { Id = 5, TestId = 1, Username = "Medina", Mark = 3, OutOf = 10},
    ];
}
