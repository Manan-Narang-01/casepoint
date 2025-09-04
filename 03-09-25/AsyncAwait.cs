using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace _03_09_25
{
    public class AsyncAwait
    {
        public async static Task Main(string[] args)
        {
            AsyncAwait cook = new AsyncAwait();
            var stopwatch = Stopwatch.StartNew();

            Task<string> teaTask = cook.MakeTeaAsync();
            Task<string> parathaTask = cook.MakeParathaAsync();

            await Task.WhenAll(teaTask, parathaTask);

            stopwatch.Stop();
            Console.WriteLine($"\nTea is ready: {teaTask.Result}");
            Console.WriteLine($"Paratha is ready: {parathaTask.Result}");
            Console.WriteLine($"\nTotal Time taken: {stopwatch.ElapsedMilliseconds} ms");
        }

        public async Task<string> BoilWaterAsync()
        {
            Console.WriteLine("Start the kettle");
            Console.WriteLine("Waiting for the kettle");

            await Task.Delay(2000);

            Console.WriteLine("Kettle finished boiling");
            return "water";
        }

        public async Task<string> MakeTeaAsync()
        {
            var boilingWaterTask = BoilWaterAsync();

            Console.WriteLine("Take the cups out");
            Console.WriteLine("Put tea in cups");

            var water = await boilingWaterTask;

            var tea = $"pour {water} in cups";
            Console.WriteLine(tea);

            return tea;
        }

        public async Task<string> MakeParathaAsync()
        {
            Console.WriteLine("\nStart making dough");
            await Task.Delay(1000);

            Console.WriteLine("Roll the dough");
            await Task.Delay(1000);

            Console.WriteLine("Cook the paratha");
            await Task.Delay(2000);

            string paratha = "paratha";
            Console.WriteLine("Paratha is ready");
            return paratha;
        }
    }
}
