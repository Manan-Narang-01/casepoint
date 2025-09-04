// namespace _03_09_25;
// using System;
// using System.Diagnostics;
// using System.Threading.Tasks;

// public class SynchronousTea
// {
//     public static void Main(string[] args)
//     {
//         SynchronousTea teamaker = new SynchronousTea();

//         var stopwatch = Stopwatch.StartNew();


//         string tea = teamaker.MakeTea();
//         string paratha = teamaker.MakeParatha();

//         stopwatch.Stop();

//         Console.WriteLine($"\nTea is ready: {tea}");
//         Console.WriteLine($"Paratha is ready: {paratha}");
//         Console.WriteLine($"\nTotal Time taken: {stopwatch.ElapsedMilliseconds} ms");
//     }

//     public string BoilWater()
//     {
//         Console.WriteLine("Start the kettle");
//         Console.WriteLine("Waiting for the kettle");

//         Task.Delay(2000).Wait();  

//         Console.WriteLine("Kettle finished boiling");
//         return "water";
//     }

//     public string MakeTea()
//     {
//         var water = BoilWater();

//         Console.WriteLine("Take the cups out");
//         Console.WriteLine("Put tea in cups");

//         var tea = $"pour {water} in cups";
//         Console.WriteLine(tea);

//         return tea;
//     }

//     public string MakeParatha()
//     {
//         Console.WriteLine("\nStart making dough");
//         Task.Delay(1000).Wait();  

//         Console.WriteLine("Roll the dough");
//         Task.Delay(1000).Wait();  

//         Console.WriteLine("Cook the paratha");
//         Task.Delay(2000).Wait();  

//         return "paratha";
//     }
// }
