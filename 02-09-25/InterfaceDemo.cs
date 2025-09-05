namespace _02_09_25;

interface IAccount
{
    void Deposit(float Amount);
    void Withdraw(float Amount);

}
class Savingaccount : IAccount
{
    float RateOfInt;
    public SavingsAccount(int AcNo, string AcName, float Bal, float RateOfInt) : base(AcNo, AcName, Bal)
    {
        this.RateOfInt = RateOfInt;
    }

    public void RaiseInt()
    {
        Bal += Bal * RateOfInt / 100;

        Console.WriteLine($" Bal: {Bal}\n");
    }
    public void PutData()
    {
        base.PutData();
        Console.WriteLine($" Rate of Int :{RateOfInt}\n ");

    }
    public void Deposit(float Amount)
    {
        Bal += Amount;
        Console.WriteLine($" Bal: {Bal}\n");
    }

    public void Withdraw(float Amount)
    {
        if (Bal - Amount < 0)
        {
            Console.WriteLine("insuffient balance");

        }
        else
        {
            Bal -= Amount;
        }
        Console.WriteLine($" Bal: {Bal}\n");

    }

}

class CurrentAccount : Account
{

    int ChequeIssueCharge;
    public CurrentAccount(int AcNo, string AcName, float Bal, int ChequeIssueCharge) : base(AcNo, AcName, Bal)
    {
        this.ChequeIssueCharge = ChequeIssueCharge; ;
    }

    public void ChequeIssue()
    {

        Bal -= ChequeIssueCharge;
        Console.WriteLine($" Bal: {Bal}\n");
    }

    public override void PutData()
    {
        base.PutData();
        Console.WriteLine($" Cheque issue Charge :{ChequeIssueCharge}\n ");

    }
    public override void Deposit(float Amount)
    {
        Bal += Amount;
        if (Amount > 10000)
        {
            Bal -= 10;
        }
        Console.WriteLine($" Bal: {Bal}\n");
    }
    
    public void Withdraw(float Amount)
    {
        if (Bal - Amount < 0)
        {
            Console.WriteLine("insuffient balance");

        }
        else
        {
           Bal += Amount;
            if (Amount > 10000)
            {
                Bal -= 10;
            }
        }
        Console.WriteLine($" Bal: {Bal}\n");

    }
}


public class InterfaceDemo
{
    public static void   Interfacemain()
    {
        IAccount abs;
        abs = new Savingaccount(1, "v", 10000, 3.5f);
        ((Savingaccount)abs).PutData();
        abs.Deposit(11000);
        abs.Withdraw(2000);
        ((Savingaccount)abs).RaiseInt();


        abs = new CurrentAccount(1, "v", 10000, 250);
        ((CurrentAccount)abs).PutData();
        abs.Deposit(11000);
        abs.Withdraw(2000);
        ((CurrentAccount)abs).ChequeIssue();
        
    }
}
