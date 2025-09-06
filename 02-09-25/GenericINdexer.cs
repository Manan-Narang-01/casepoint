namespace _02_09_25;
public class Storage<T>{

    private List<T> List=new List<T>();

    public T this[int index]{
       get
            {
                if (index >= 0 && index < List.Count)
                    return List[index];
                else
                    return default(T);
            }
    }

    public void AddItem(T item){
        List.Add(item);
    }

    public void RemoveItem(T item){
       if (List.Contains(item))
            {
                List.Remove(item);
            }
    }

    public void DisplayItem(){
        Console.WriteLine("Items: ");
        foreach (T item in List)
        {
            Console.Write( item +", ");
        }
    }

    
}
public class GenericINdexer
{
    public static void StorageMain(){

        Storage<int> intStorage = new Storage<int>();
        intStorage.AddItem(10);
        intStorage.AddItem(20);
        intStorage.AddItem(30);

        Storage<string> stringStorage = new Storage<string>();
        stringStorage.AddItem("Manan");
        stringStorage.AddItem("Narang");
        stringStorage.AddItem("Surat");

        Storage<double> doubleStorage = new Storage<double>();
        doubleStorage.AddItem(10.5);
        doubleStorage.AddItem(20.5);
        doubleStorage.AddItem(30.5);


        Console.WriteLine("\nInteger Storage: ");
        intStorage.DisplayItem();
        Console.WriteLine("\nItems on Index 1: "+intStorage[1]);

        Console.WriteLine("\nString Storage: ");
        stringStorage.DisplayItem();
        Console.WriteLine("\nItems on Index 1: "+stringStorage[1]);

        Console.WriteLine("\nDouble Storage: ");
        doubleStorage.DisplayItem();
        Console.WriteLine("\nItems on Index 1: "+doubleStorage[1]);


    }

}
