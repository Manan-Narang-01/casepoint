namespace _03_09_25;

public class EventDemo
{
    
    event MyDel MyEvent;

    string str;
    public EventTest(string str){
        this.str = str;
    }

    public string welcome(){
        return "Welcome "+str;
    }

    public string goodBye(){
        return "GoodBye "+str;
    }

    
        public void TriggerEvent()
        {
            if (MyEvent != null)
            {
                foreach (MyDel d in MyEvent.GetInvocationList())
                {
                    Console.WriteLine(d());
                }
            }
        }

    public static void EventMain(){

        EventTest obj= new EventTest("Manan");

        obj.MyEvent += obj.welcome;

        obj.MyEvent += obj.goodBye;

       obj.TriggerEvent();
    }

}
