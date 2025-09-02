// namespace _02_09_25;

// public class MultiThreadingDemo
// {
//     public static void method1()
//     {
//         for (int i = 0; i <= 10; i++)
//         {
//             Console.WriteLine($"Method1 is: {i}");
//             if (i == 5)
//             {
//                 Thread.Sleep(6000);
//             }
//         }
//     }
//     public static void method2()
//     {
//         for (int i = 0; i <= 10; i++)
//         {
//             Console.WriteLine($"Method2 is : {i}");
            
//         }
//     }
//     static void Main(string[] args)
//     {
//         Thread t1 = new Thread(method1);
//         Thread t2 = new Thread(method2);
//         t1.Start();
//         t2.Start();
//     }
// }
