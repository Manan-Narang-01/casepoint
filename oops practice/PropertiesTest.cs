namespace _02_09_25;

public class PropertiesTest
{
    private int _acno;
    public int Acno
    {
        get
        {
            return _acno;
        }
        set
        {
            if (value < 10 || value > 99)
            {
                _acno = 0;
            }
            else
            {
                _acno = value;
            }
        }
    }
    public string AcName { get; set; }
    public float bal { get; set; }

    public override string ToString()
    {
        return $" Acno: {Acno}\n AcName: {AcName}\n Bal:{bal}";
    }

}
class ClassTest2
{
    public static void Propertiesmain()
    {
        PropertiesTest pt = new PropertiesTest();
        pt.Acno = 91;
        pt.AcName = "manan";
        pt.bal = 100000;
        Console.WriteLine(pt);
    }
}
