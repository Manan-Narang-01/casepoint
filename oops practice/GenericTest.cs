namespace _02_09_25;
class DataStore<T>{
    public T data{get;set;}
}

class DataStore2<Tkey,Tvalue>{
    public Tkey key{get;set;}
    public Tvalue value{get;set;}

    public Tvalue getValue(Tkey key){
       if(key.Equals(this.key)){
        return this.value;
       }
       return default(Tvalue);
    }
}

public class GenericTest
{
    public static void GenericsMain()
    {
        DataStore<int> intStore = new DataStore<int>();
        intStore.data = 10;

        DataStore2<int,string> intStringStore = new DataStore2<int,string>();
        intStringStore.key = 1;
        intStringStore.value = "M";

        Console.WriteLine(intStringStore.getValue(1));
    }

}
