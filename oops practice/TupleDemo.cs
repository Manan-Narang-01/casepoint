namespace _03_09_25;

public class TupleDemo
{
    static void DisplayTuple(Tuple<int, string,string> personTuple){

        Console.WriteLine($"Name: {personTuple.Item2},\n Age: {personTuple.Item1},\n Address: {personTuple.Item3}\n");
    }

    static Tuple<int, string, string> GetPersonDetails(int age, string name, string address){
        return new Tuple<int, string, string>(age, name, address);
    }

    public static void TupleMain(){

        var person=Tuple.Create(1,"Manan","Surat");
        Console.WriteLine(person.Item1);
        Console.WriteLine(person.Item2);
        Console.WriteLine(person.Item3);

        var number=Tuple.Create(1,2,3,4,"Five","Six",7,8);
        Console.WriteLine(number.Item1);
        Console.WriteLine(number.Item2);
        Console.WriteLine(number.Item3);
        Console.WriteLine(number.Item4);
        Console.WriteLine(number.Item5);
        Console.WriteLine(number.Item6);
        Console.WriteLine(number.Item7);
        Console.WriteLine(number.Rest);
        Console.WriteLine(number.Rest.Item1);

         var number2=Tuple.Create(1,2,3,4,"Five","Six",7,Tuple.Create(8,9,10,11,12));
        Console.WriteLine(number2.Item1);
        Console.WriteLine(number2.Item2);
        Console.WriteLine(number2.Item3);
        Console.WriteLine(number2.Item4);
        Console.WriteLine(number2.Item5);
        Console.WriteLine(number2.Item6);
        Console.WriteLine(number2.Item7);
        Console.WriteLine(number2.Rest.Item1);
        Console.WriteLine(number2.Rest.Item1.Item1);

        ValueTuple<int,string,int,int>newone=(1,"MANAN",2,3);
        Console.WriteLine(newone.Item1);
        Console.WriteLine(newone.Item2);
        Console.WriteLine(newone.Item3);
        Console.WriteLine(newone.Item4);

        var persondata =Tuple.Create(1,"MAnan","Surat");
        DisplayTuple(persondata);


        var newPerson=GetPersonDetails(1,"Manan","Surat");
        DisplayTuple(newPerson);
    }

}
