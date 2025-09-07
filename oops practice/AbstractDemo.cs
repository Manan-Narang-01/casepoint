namespace _02_09_25;


 abstract class Account
{
    private int AcNo;
    private string AcName;
    protected float Bal;

    public Account(int AcNo, string AcName, float Bal)
    {
        this.AcNo = AcNo;
        this.AcName = AcName;
        this.Bal = Bal;
    }
    public abstract void Deposit(float Amount);

    public void Withdraw(float Amount)
    {
        if (Bal - Amount < 0)
        {
            Console.WriteLine("Insuffient Fund");
        }
        else
        {
            Bal -= Amount;
        }
        Console.WriteLine($"Bal :{Bal}\n");
    }
    public virtual void PutData()
    {
        Console.WriteLine($" AcNo :{AcNo}\n AcName :{AcName}\n Bal :{Bal}");

    }

}

class Savingaccount : Account
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
    public override void PutData()
    {
        base.PutData();
        Console.WriteLine($" Rate of Int :{RateOfInt}\n ");

    }
     public override void Deposit(float Amount)
    {
        Bal += Amount;
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
}




public class AbstractDemo
{
    public static void AbstractDemomain()
    {

        Account abs;
        abs = new Savingaccount(1, "v", 10000, 3.5f);
        abs.PutData();
        abs.Deposit(11000);
        abs.Withdraw(2000);
        ((Savingaccount)abs).RaiseInt();


        abs = new CurrentAccount(1, "v", 10000, 250);
        abs.PutData();
        abs.Deposit(11000);
        abs.Withdraw(2000);
        ((CurrentAccount)abs).ChequeIssue();
        
    
    }
}
