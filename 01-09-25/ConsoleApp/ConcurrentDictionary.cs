// using System.Collections.Concurrent;

// namespace ConsoleApp;

// public class ConcurrentDictionaryDemo
// {
//     static void Main()
//     {
//         ConcurrentBag<int> cb = new ConcurrentBag<int>();
//         ConcurrentDictionary<string, int> cd = new ConcurrentDictionary<string, int>();
//         Parallel.For(0, 10, i => cd.TryAdd($"Key{i}", i));
//         Console.WriteLine("--Before Update");
//         foreach (var kvp in cd)
//         {
//             Console.WriteLine($"{kvp.Key}:{kvp.Value}");
//         }
//         Parallel.ForEach(cd, kvp =>
//         {
//             cd.TryUpdate(kvp.Key, kvp.Value + 10, kvp.Value);
//         });

//         Console.WriteLine("--After Update");
//         foreach (var kvp in cd)
//         {
//             Console.WriteLine($"{kvp.Key}:{kvp.Value}");
//         }


//     }
// }
