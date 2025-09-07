namespace _02_09_25;

public class TaskDemo
{
    static void Main() {
        
        Console.WriteLine("Main thread started.");

        Task task1 = Task.Run(() => PrintNumbers());
        Task task2 = Task.Run(() => PrintAlphabets());

        Task.WaitAll(task1, task2);

        Console.WriteLine("Main thread finished.");
    }


    static void PrintNumbers()
    {

        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine($"Numbers Task: {i}");
            Task.Delay(1000).Wait();
            
        }

}

    static void PrintAlphabets()
    {

        for (char c = 'A'; c <= 'E'; c++)
        {
            Console.WriteLine($"Alphabets Task: {c}");
            Task.Delay(1200).Wait();
        }
    }
}
