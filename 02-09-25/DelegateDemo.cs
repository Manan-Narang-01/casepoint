namespace _02_09_25;
delegate int MinMax(int a, int b);
delegate void Updated(ref int score);

public class DelegateDemo
{
    public static int Max(int a,int b){
        return a > b ? a : b;
    }

    public static int Min(int a,int b){
        return a < b ? a : b;
    }

    public static void UpdateScore(ref int score){
        score += 10;
    }

    public static void UpdateScore1(ref int score){
        score *= 5;
    }

    public static void DelegateMain(){
       

        
        MinMax mm = new MinMax(Max);
        Console.WriteLine("Max: "+mm(10,20));
        MinMax mn = new MinMax(Min);
        Console.WriteLine("Min: "+mn(10,20));

        
        Updated updated = new Updated(UpdateScore);
        updated += new Updated(UpdateScore1);
        int score = 100;
        updated(ref score);
        Console.WriteLine("Score: "+score);



    }
}
