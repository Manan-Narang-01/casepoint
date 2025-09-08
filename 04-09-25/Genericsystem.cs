namespace _04_09_25;

public class Genericsystem
{
    public class Storage<T>
    {
        private List<T> _items;

        public Storage()
        {
            _items = new List<T>();
        }

        public void AddItem(T item)
        {
            _items.Add(item);
        }

        public void RemoveItem(T item)
        {
            if (_items.Contains(item))
            {
                _items.Remove(item);
            }
        }

        public void DisplayItems()
        {
            Console.WriteLine($"Items: [{string.Join(", ", _items)}]");
        }

        public T this[int index]
        {
            get
            {
                if (index >= 0 && index < _items.Count)
                {
                    return _items[index];
                }
                throw new ArgumentOutOfRangeException("Index is out of range.");
            }
        }
    }
    
    public static void Main(string[] args)
        {
            var intStorage = new Storage<int>();
            intStorage.AddItem(1);
            intStorage.AddItem(2);
            intStorage.AddItem(3);
            Console.WriteLine("Integer Storage:");
            intStorage.DisplayItems();
            Console.WriteLine($"Item at index 1: {intStorage[1]}");

            var stringStorage = new Storage<string>();
            stringStorage.AddItem("M");
            stringStorage.AddItem("V");
            stringStorage.AddItem("N");
            Console.WriteLine("\nString Storage:");
            stringStorage.DisplayItems();
            Console.WriteLine($"Item at index 2: {stringStorage[2]}");

            var doubleStorage = new Storage<double>();
            doubleStorage.AddItem(91.99);
            doubleStorage.AddItem(92.99);
            doubleStorage.AddItem(93.99);
            Console.WriteLine("\nDouble Storage:");
            doubleStorage.DisplayItems();
            Console.WriteLine($"Item at index 0: {doubleStorage[1]}");

            intStorage.RemoveItem(102);
            stringStorage.RemoveItem("M");
            doubleStorage.RemoveItem(92.99);

            Console.WriteLine("\nAfter Removal:");
            Console.WriteLine("Integer Storage:");
            intStorage.DisplayItems();
            Console.WriteLine("String Storage:");
            stringStorage.DisplayItems();
            Console.WriteLine("Double Storage:");
            doubleStorage.DisplayItems();
        }
}
