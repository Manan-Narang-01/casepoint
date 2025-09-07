// namespace _03_09_25;

// using System;
// using System.Diagnostics;
// using System.Threading.Tasks;
// public class AsyncWithoutWhenAll
// {


//         public async static Task Main(string[] args)
//         {
//             AsyncWithoutWhenAll cook = new AsyncWithoutWhenAll();
//             var stopwatch = Stopwatch.StartNew();
//             string tea = await  cook.MakeTeaAsync();
//             string paratha = await  cook.MakeParathaAsync();

//             stopwatch.Stop();

//             Console.WriteLine($"\nTea is ready: {tea}");
//             Console.WriteLine($"Paratha is ready: {paratha}");
//             Console.WriteLine($"\nTotal Time taken: {stopwatch.ElapsedMilliseconds} ms");
//         }

//         public async Task<string> BoilWaterAsync()
//         {
//             Console.WriteLine("Start the kettle");
//             Console.WriteLine("Waiting for the kettle");

//             await Task.Delay(2000);

//             Console.WriteLine("Kettle finished boiling");
//             return "water";
//         }

//         public async Task<string> MakeTeaAsync()
//         {
//             var boilingWaterTask = BoilWaterAsync();

//             Console.WriteLine("Take the cups out");
//             Console.WriteLine("Put tea in cups");

//             var water = await boilingWaterTask;

//             var tea = $"pour {water} in cups";
//             Console.WriteLine(tea);

//             return tea;
//         }

//         public async Task<string> MakeParathaAsync()
//         {
//             Console.WriteLine("\nStart making dough");
//             await Task.Delay(1000);

//             Console.WriteLine("Roll the dough");
//             await Task.Delay(1000);

//             Console.WriteLine("Cook the paratha");
//             await Task.Delay(2000);

//             string paratha = "paratha";
//             Console.WriteLine("Paratha is ready");
//             return paratha;
//         }
// }

