// namespace _04_09_25;

// public delegate int ArithmeticOperation(int a, int b);
// public static class Calculator
// {
//     public static int Add(int a, int b)
//     {
//         return a + b;
//     }

//     public static int Subtract(int a, int b)
//     {
//         return a - b;
//     }

//     public static int Multiply(int a, int b)
//     {
//         return a * b;
//     }

//     public static int Divide(int a, int b)
//     {
//         if (b == 0)
//         {
//             Console.WriteLine("Error: Division by zero is not allowed.");
//             return 0;
//         }
//         return a / b;
//     }
//     public static void Main(string[] args)
//     {
//         ArithmeticOperation operation;
//         int num1, num2;
//         Console.WriteLine("Enter first number :");
//         num1 = int.Parse(Console.ReadLine());
        
//         Console.WriteLine("Enter second number :");
//         num2 = int.Parse(Console.ReadLine());
        
//         operation = new ArithmeticOperation(Calculator.Add);
//         Console.WriteLine($"Addition: {num1} + {num2} = {operation(num1, num2)}");

//         operation = new ArithmeticOperation(Calculator.Subtract);
//         Console.WriteLine($"Subtraction: {num1} - {num2} = {operation(num1, num2)}");

//         operation = new ArithmeticOperation(Calculator.Multiply);
//         Console.WriteLine($"Multiplication: {num1} * {num2} = {operation(num1, num2)}");

//         operation = new ArithmeticOperation(Calculator.Divide);
//         Console.WriteLine($"Division: {num1} / {num2} = {operation(num1, num2)}");


//     }
// }

